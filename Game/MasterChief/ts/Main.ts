﻿/// <reference path="Scripts/typings/createjs/createjs.d.ts"/>
/// <reference path="Scripts/typings/easeljs/easeljs.d.ts"/>
/// <reference path="Scripts/typings/preloadjs/preloadjs.d.ts"/>
/// <reference path="Scripts/typings/soundjs/soundjs.d.ts"/>
/// <reference path="Scripts/typings/ndgmr/ndgmr.Collision.d.ts"/>

class Main {
    private canvas: HTMLCanvasElement;
    private stage: createjs.Stage;
    private manifest: any[];
    private queue: createjs.LoadQueue;

    private message: createjs.Text;
    private score: createjs.Text;
    private background: createjs.Bitmap;
    private ground: Ground;
    private masterChief: MasterChief;
    private groundImg: HTMLImageElement;
    private explosionImg: HTMLImageElement;
    private bulletImg: HTMLImageElement;
    private asukaImg: HTMLImageElement;
    private asukaDoc: XMLDocument;

    private asukas: AsukaKamikaze[] = []
    private bullets: Bullet[] = [];    
    private explosions: Explosion[] = [];
       
    private canFire: boolean = true;
    private isGameOver: boolean = false;

    private asukaInterval: number;
    private points: number = 0;     

    constructor(canvas: HTMLCanvasElement) {
        this.canvas = canvas;
        this.stage = new createjs.Stage(canvas);

        this.message = new createjs.Text('', 'bold 30px Segoe UI', '#e66000');
        this.message.textAlign = 'center';
        this.message.x = canvas.width / 2;
        this.message.y = canvas.height / 2;
        this.stage.addChild(this.message);       

        this.manifest =
        [
            { src: 'assets/images/AsukaKamikazeSpriteSheet.png', id: 'asuka' },
            { src: 'assets/images/Background.png', id: 'background' },
            { src: 'assets/images/Bullet.png', id: 'bullet' },
            { src: 'assets/images/ExplosionSpriteSheet.png', id: 'explosion' },
            { src: 'assets/images/ground.png', id: 'ground' },
            { src: 'assets/images/MasterChiefSpriteSheet.png', id: 'masterChief' },
            { src: 'assets/data/AsukaKamikazeSpriteSheet.xml', id: 'asukaData' },
            { src: 'assets/data/MasterChiefSpriteSheet.xml', id: 'chiefData' },
            { src: 'assets/sounds/Glock_17.mp3', id: 'glock' },
            { src: 'assets/sounds/Echinoderm_Regeneration.mp3', id: 'music' },
            { src: 'assets/sounds/Bomb_Exploding.mp3', id: 'bomb' },
        ];

        this.queue = new createjs.LoadQueue();
        this.queue.installPlugin(createjs.Sound);
        this.queue.on('complete', (e: createjs.Event) => { this.onComplete(e) });
        this.queue.on('progress', (e: createjs.Event) => { this.loading(e) });
        this.queue.loadManifest(this.manifest);
    }

    private loading(e: createjs.Event) {
        this.message.text = 'Loading: ' + Math.round(e.progress * 100) + '%';
        this.stage.update();
    }

    private onComplete(e: createjs.Event) {
        this.stage.removeChild(this.message);
        
        var backgroundImg = <HTMLImageElement> this.queue.getResult('background')
        this.background = new createjs.Bitmap(backgroundImg);
        
        var groundImg = <HTMLImageElement> this.queue.getResult('ground');
        this.ground = new Ground(groundImg, this.canvas);
        
        var chiefImg = <HTMLImageElement> this.queue.getResult('masterChief');
        var chiefDoc = <XMLDocument> this.queue.getResult('chiefData');
        this.masterChief = new MasterChief(chiefImg, chiefDoc);
        this.masterChief.x = 180;
        this.masterChief.y = this.ground.y - this.masterChief.getBounds().height;
        
        this.score = new createjs.Text('Score: 0', 'Bold 15px Arial', '#000');
        this.score.textAlign = 'left';
        this.score.shadow = new createjs.Shadow("#000", 3, 4, 8);
        this.score.x = 10;
        this.score.y = 10;        
        // Add elements to stage.
        this.stage.addChild(this.background, this.ground, this.masterChief, this.score);

        this.explosionImg = <HTMLImageElement> this.queue.getResult('explosion');
        this.bulletImg = <HTMLImageElement> this.queue.getResult('bullet');
        this.asukaImg = <HTMLImageElement> this.queue.getResult('asuka');
        this.asukaDoc = <XMLDocument> this.queue.getResult('asukaData');

        createjs.Ticker.setFPS(30);
        createjs.Ticker.on('tick', (e: createjs.TickerEvent) => { this.tick(e) });

        document.addEventListener('keydown', (e: KeyboardEvent) => { this.keyDown(e) });
        document.addEventListener('keyup', (e: KeyboardEvent) => { this.keyUp(e) });

        createjs.Sound.play('music', createjs.Sound.INTERRUPT_NONE, 0, 0, -1, 0.5);

        this.asukaInterval = setInterval(() => { this.createAsuka() }, 6000);
    }

    private tick(e: createjs.TickerEvent) {
        var ds = e.delta / 1000;
                  
        if (this.masterChief.currentAnimation == 'run' && !this.isGameOver) {
            this.ground.tick(ds);
        }

        this.moveBullets(ds);
        this.moveAsukas(ds);

        this.checkBulletAsukaCollision();
        this.checkAsukaMasterChiefCollision();

        this.stageCleanup();

        this.stage.update(e);
    }

    private keyDown(e: KeyboardEvent) { 
        var key = e.keyCode;              
        switch (key) {
            case 39: // Right
                if (this.masterChief.currentAnimation != 'run' && !this.isGameOver) {
                    this.masterChief.gotoAndPlay('run');
                }
                break;
            case 32: // Spacebar             
                if (this.canFire && !this.isGameOver) {
                    this.masterChief.gotoAndPlay('fire');
                    this.createBullet();
                    createjs.Sound.play('glock');
                    this.canFire = false;
                }
                break;
            case 40: // Down
                if (this.masterChief.currentAnimation != 'crouch' && !this.isGameOver) {
                    this.masterChief.gotoAndStop('crouch');
                }
                break;
            case 38: // Up
                if (this.masterChief.currentAnimation != 'stand' && !this.isGameOver) {
                    this.masterChief.gotoAndStop('stand');
                }
                break;
            case 13: // Enter
                if (this.isGameOver) {
                    this.stage.removeChild(this.message);
                    this.masterChief.visible = true;
                    this.asukaInterval = setInterval(() => { this.createAsuka() }, 6000);
                    this.isGameOver = false;
                    this.points = 0;
                    this.score.text = 'Score: 0';
                }
                break;
        }
    }

    private keyUp(e: KeyboardEvent) {
        var key = e.keyCode;
        if (key == 39) {  
            this.masterChief.gotoAndPlay('stand');
        }
        else if (key == 32) { 
            this.canFire = true;
        }
    }

    // Remove element from the stage and from its array.
    private removeElement(el: any, arr: any[]) {
        this.stage.removeChild(el);
        var index = arr.indexOf(el);
        arr.splice(index, 1);
    }
    
    private createBullet() {
        var bullet = new Bullet(this.bulletImg);
        bullet.alpha = 0.3;
        bullet.x = this.masterChief.x + this.masterChief.getBounds().width - 5;
        bullet.y = this.masterChief.y + 32;
        this.bullets.push(bullet);
        this.stage.addChild(bullet);
    }

    private moveBullets(ds: number) {
        for (var i in this.bullets) {
            var bullet = this.bullets[i];
            bullet.tick(ds);
            // Remove bullet from stage, and array, when it reaches end of stage.
            if (bullet.x > this.canvas.width - bullet.getBounds().width) {
                this.removeElement(bullet, this.bullets);
            }
        }
    }    

    private createAsuka() {        
        var asuka = new AsukaKamikaze(this.asukaImg, this.asukaDoc);
        asuka.x = this.canvas.width + asuka.getBounds().width;
        asuka.y = this.ground.y - asuka.getBounds().height;
        this.asukas.push(asuka);
        this.stage.addChild(asuka);              
    }

    // Move created Asukas.
    private moveAsukas(ds: number) {
        for (var i in this.asukas) {
            var asuka = this.asukas[i];
            if (asuka.currentAnimation != 'dead') {
                asuka.tick(ds);
            }
        }
    }

    private checkBulletAsukaCollision() {
        for (var a in this.asukas) {
            var asuka = this.asukas[a];
            for (var b in this.bullets) {
                var bullet = this.bullets[b];
                var collision = ndgmr.checkPixelCollision(asuka, bullet, 0);
                if (collision) {
                    this.removeElement(bullet, this.bullets);
                    asuka.HitCount += 1;
                    if (asuka.HitCount == 5) {
                        asuka.gotoAndPlay('hit');
                        this.points += 1;
                        this.score.text = 'Score: ' + this.points.toString();
                    }
                }
            }
        }
    }   

    private checkAsukaMasterChiefCollision() {
        for (var a in this.asukas) {
            var asuka = this.asukas[a];
            var collision = ndgmr.checkPixelCollision(asuka, this.masterChief, 1);
            if (collision) {
                // Create explosion.                
                var explosion = new Explosion(this.explosionImg);
                explosion.x = this.masterChief.x;
                explosion.y = this.masterChief.y;
                this.explosions.push(explosion);
                this.stage.addChild(explosion);
                // Play explosion sound.
                createjs.Sound.play('bomb');
                               
                window.clearInterval(this.asukaInterval);
                               
                this.removeElement(asuka, this.asukas);
                this.masterChief.visible = false;
                this.isGameOver = true;

                this.message.text = 'Game Over!\nPress Enter to start again';
                this.message.shadow = new createjs.Shadow("#000", 4, 4, 10);
                this.stage.addChild(this.message);              
            }
        }
    } 

    private stageCleanup() {
        // Fade-off and remove dead Asukas.
        for (var i in this.asukas) {
            var asuka = this.asukas[i];
            if (asuka.currentAnimation == 'dead') {
                asuka.alpha -= 0.05;
                if (asuka.alpha <= 0) {
                    this.removeElement(asuka, this.asukas);
                }
            }
        }
        // Remove explosions.
        for (var i in this.explosions) {
            var explosion = this.explosions[i];
            if (explosion.currentAnimationFrame == explosion.LastFrame) {
                this.removeElement(explosion, this.explosions);
            }
        }
    }  
   
}

window.addEventListener('load', () => {
    var canvas = <HTMLCanvasElement> document.getElementById('gameCanvas');
    canvas.style.background = '#000';    
    var main = new Main(canvas);
})
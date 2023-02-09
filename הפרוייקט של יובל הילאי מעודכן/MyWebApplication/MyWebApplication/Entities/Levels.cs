using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using ClassLibraryLibDoQuerise;
using System.Collections;
using System.Drawing;

namespace MyWebApplication.Entities
{
    public class Levels
    
    {
        private int IdLevel;
        private string LevelName;
        private int sumOfBuying;
     
       private decimal DiscountType;

       public Levels()
        {
        }

        public int idLevel
        {
            get { return IdLevel; }
            set { IdLevel = value; }
        }
        public string levelName
        {
            get { return LevelName; }
            set { LevelName = value; }
        }
        public int SumOfBuying
        {
            get { return sumOfBuying; }
            set { sumOfBuying = value; }
        }

        public decimal discountType
        {
            get { return DiscountType; }
            set { DiscountType = value; }
        }
             public DataTable GetDiscontTypeByIdLevel()
        {
            string strSqlName = "GetDiscontTypeByIdLevel";
            ArrayList prmList = new ArrayList();
            prmList.Add(new OleDbParameter("@IdLevel", this.idLevel));
            DataTable dt = DoQueries.GetDataTableByDataReader(Connect.CONNECTION_STRING, strSqlName, prmList);
            return dt;
        }
             public void Levels1()
             {


                 if (SumOfBuying == 0)
                     IdLevel = 0;
                 if (SumOfBuying == 1)
                     IdLevel = 1;
                 if (SumOfBuying == 2)
                     IdLevel = 2;
                 if (SumOfBuying == 3)
                     IdLevel = 3;
                 if (SumOfBuying == 4 && SumOfBuying == 5)
                     IdLevel = 4;
                 if (SumOfBuying == 6 && SumOfBuying == 7)
                     IdLevel = 5;
                 if (SumOfBuying == 8 && SumOfBuying == 9)
                     IdLevel = 6;
                 if (SumOfBuying >= 10 && SumOfBuying < 13)
                     IdLevel = 7;
                 if (SumOfBuying >= 13 && SumOfBuying < 16)
                     IdLevel = 8;
                 if (SumOfBuying >= 16 && SumOfBuying < 19)
                     IdLevel = 9;
                 if (SumOfBuying >= 19 && SumOfBuying < 23)
                     IdLevel = 10;
                 if (SumOfBuying >= 23 && SumOfBuying < 27)
                     IdLevel = 11;
                 if (SumOfBuying >= 27 && SumOfBuying < 35)
                     IdLevel = 12;
                 if (SumOfBuying >= 35 && SumOfBuying < 45)
                     IdLevel = 13;
                 if (SumOfBuying >= 45 && SumOfBuying < 60)
                     IdLevel = 14;
                 if (SumOfBuying >= 60)
                     IdLevel = 15;

             }

      
    }
}
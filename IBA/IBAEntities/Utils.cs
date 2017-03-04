using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;
using IBAEntities;

namespace IBAEntities
{
    public static class Utils
    {

        public static int GetIntValue(object valueFromDB)
        {
            int retVal = Constants.DEFAULTVALUE;
            if (!CheckNull(valueFromDB))
            {
                if(!Int32.TryParse(valueFromDB.ToString(), out retVal))
                    retVal = Constants.DEFAULTVALUE;
            }
            return retVal;
        }

        public static double GetDoubleValue(object valueFromDB)
        {
            double retVal = 0;
            if (!CheckNull(valueFromDB))
            {
                if (!Double.TryParse(valueFromDB.ToString(), out retVal))
                    retVal = 0;
            }
            return retVal;
        }

        public static bool GetBoolValue(object valueFromDB)
        {
            bool retVal = false;
            if (!CheckNull(valueFromDB))
            {
                Boolean.TryParse(valueFromDB.ToString(), out retVal);
            }
         
            return retVal;
        }

        public static string GetStringValue(object valueFromDB)
        {
            string retVal = String.Empty;
            if (!CheckNull(valueFromDB))
            {

                retVal = valueFromDB.ToString().Trim().Replace("\"", "");
            }
 
            return retVal;
        }

        public static DateTime? GetDateTimeValue(object valueFromDB)
        {
            DateTime? retVal = null;
            if (!CheckNull(valueFromDB))
            {
                //string[] formats = { "MM/dd/yyyy", "MM-dd-yyyy", "dd-MM-yyyy", "dd-MM-yyyy HH:mm:ss", "dd/MM/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss" };
                //string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "dd/MM/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss" };
                string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "dd/MM/yyyy HH:mm", "dd/MM/yyyy HH:mm:ss" };
               
                
                try
                {
                    if ((String)valueFromDB == String.Empty)
                        retVal = DateTime.Now;
                    else
                        retVal = DateTime.ParseExact(valueFromDB.ToString(), formats, new CultureInfo("en-US"), DateTimeStyles.None);
                   
                }
                catch (Exception ex)
                {

                   // Logger.Log(DateTime.Now.Hour + ":" + DateTime.Now.Minute + " Utils.GetDateTimeValue(For Value: " + valueFromDB + "): " + ex.Message + ex.StackTrace);
                    //DateTime.TryParse(valueFromDB.ToString(), out retVal);
                   throw ex;
                }
                //DateTime.TryParse(valueFromDB.ToString(), out retVal);
            }

            return retVal;
        }

        public static bool CheckNull(object valueFromDB)
        {
            if (valueFromDB != null && valueFromDB != System.DBNull.Value)
                return false;
            else
                return true;

        }

        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }

    
        public static List<string> BreakStrings(object origList)
        {
            List<string> retVal = null;
            string list = GetStringValue(origList);
            if (!String.IsNullOrEmpty(list))
            {
                retVal = list.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            return retVal;
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;

            }
            finally
            {
                GC.Collect();
            }
        }

   
    
        public static string GetFileServerPath(string fileName)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;

            path = Path.Combine(path, "FileServer", fileName);

            return path;
        
        }

        public static string NumberToWords(int number)
        {
            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 10000000) > 0)
            {
                words += NumberToWords(number / 10000000) + " crores ";
                number %= 10000000;
            }

            if ((number / 100000) > 0)
            {
                words += NumberToWords(number / 100000) + " lac ";
                number %= 100000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";


                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.ToUpper();
        }

        public static double RoundValue(double origVal, int digits)
        {
            return Math.Round(origVal, digits);
        }
    
    }
}

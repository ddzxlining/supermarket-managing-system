using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Login
{
    public static class method
    {
        private static int number = 0;
        public static int Number
        {
            set { number = value; }
            get { return number; }
        }
        public static bool ConverToDouble(string str,out double result)
        {
            if (double.TryParse(str, out result))
                return true;
            else
                return false;              
        }
        public static bool ConverToDateTime(string str, out DateTime result)
        {
            if (DateTime.TryParse(str, out result))
                return true;
            else
                return false;
        }
        public static bool RegexMatch(string str1, string str2, out string result)
        {
            if (Regex.Match(str1,str2).Success) { result = str1; return true; }
            else { result = ""; return false; }          
        }
        public static bool ConverToInt(string str, out int result)
        {
            if (int.TryParse(str, out result))
                return true;
            else
                return false;
        }
        public static string SerialNumber()
        {
            String str ="10"+number.ToString("00000000");
            number += 1;
            return str;
        }
        public static void SerialNumberRollBack()
        {
            number -= 1;
        }
        public static  XmlDocument doc = new XmlDocument();
        public static XmlElement xe;
        public static void loadfile()
        {
            doc.Load("./Data.xml");
            XmlNode root = doc.SelectSingleNode("Data");
            xe = (XmlElement)root;
            method.Number = int.Parse(method.xe.GetAttribute("value"));
        }       
        public static void savefile()
        {
            xe.SetAttribute("value", method.Number.ToString());
            doc.Save("./Data.xml");
        }
    }
}

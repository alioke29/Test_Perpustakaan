using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;
using System.Text;
using System.Xml;

using Microsoft.AspNetCore.Cryptography;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Reflection;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TestPerpustakaan_VS2019.Library.Utilities
{
    public class Functions
    {

        public static bool IsDecimal(string text)
        {
            decimal value;
            bool flag = false;
            if (Decimal.TryParse(text, out value))
                flag = true;

            return flag;
        }

        public static bool IsInteger(string text)
        {
            int value;
            bool flag = false;
            if (int.TryParse(text, out value))
                flag = true;

            return flag;
        }
        public static bool IsValidDate(string txtDate)
        {
            DateTime tempDate;

            return DateTime.TryParse(txtDate, out tempDate) ? true : false;
        }

        public static bool IsValidDateByFormat(string txtDate, string formatDate)
        {
            try
            {
                DateTime.ParseExact(txtDate, formatDate, DateTimeFormatInfo.InvariantInfo);
            }
            catch
            {
                return false;
            }

            return true;
        }


        public static bool IsValidEmail(string emailAddress)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Match matches = Regex.Match(emailAddress, regexPattern);
            return matches.Success;
        }

        public static bool IsAlphaNumeric(string N)
        {
            bool yesNumeric = false;
            bool yesAlpha = false;
            bool bothStatus = false;

            for (int i = 0; i < N.Length; i++)
            {
                if (char.IsLetter(N[i]))
                    yesAlpha = true;

                if (char.IsNumber(N[i]))
                    yesNumeric = true;
            }

            if (yesAlpha == true && yesNumeric == true)
            {
                bothStatus = true;
            }
            else
            {
                bothStatus = false;
            }

            return bothStatus;
        }

        public static bool IsValidCharacter(string password)
        {
            const string REGEX_LOWERCASE = @"[a-z]";
            const string REGEX_UPPERCASE = @"[A-Z]";
            const string REGEX_NUMERIC = @"[\d]";
            const string REGEX_SPECIAL = @"([!#$%&*@\\])+";

            bool lowerCaseIsValid = Regex.IsMatch(password, REGEX_LOWERCASE);
            bool upperCaseIsValid =  Regex.IsMatch(password, REGEX_UPPERCASE);
            bool numericIsValid = Regex.IsMatch(password, REGEX_NUMERIC);
            bool symbolsAreValid = Regex.IsMatch(password, REGEX_SPECIAL);

            return lowerCaseIsValid && upperCaseIsValid && numericIsValid && symbolsAreValid;
        }

        public static bool IsValidFileSize(long imageLength, long maxFileSize)
        {

            bool isNotValid = false;
            var fileSize = imageLength;

            if (fileSize > maxFileSize)
                isNotValid = true;

            return isNotValid;
        }

        public static List<int> GetYear()
        {
            List<int> result = new List<int>();

            for (int x = 2014; x <= DateTime.Now.Year; x++)
            {
                result.Add(x);
            }

            return result;
        }

        public static List<string> GetMonth()
        {
            List<string> result = null;

            for (int x = 2015; x <= DateTime.Now.Year; x++)
            {
                result.Add(GetMonthName(x.ToString()));
            }

            return result;
        }

        public static string GetMonthName(string monthValue)
        {

            string monthName = string.Empty;

            if (monthValue == "1")
                monthName = "Januari";
            else if (monthValue == "2")
                monthName = "Februari";
            else if (monthValue == "3")
                monthName = "Maret";
            else if (monthValue == "4")
                monthName = "April";
            else if (monthValue == "5")
                monthName = "Mei";
            else if (monthValue == "6")
                monthName = "Juni";
            else if (monthValue == "7")
                monthName = "Juli";
            else if (monthValue == "8")
                monthName = "Agustus";
            else if (monthValue == "9")
                monthName = "September";
            else if (monthValue == "10")
                monthName = "Oktober";
            else if (monthValue == "11")
                monthName = "November";
            else if (monthValue == "12")
                monthName = "Desember";

            return monthName;
        }

        public static string ParseDecimalWithComma(decimal value)
        {
            string myDecimal = string.Empty;

            myDecimal = value.ToString("###,###,###,##0.#0");
            return myDecimal;
        }

        public static string ParseInteger(int value)
        {
            string myDecimal = string.Empty;

            myDecimal = value.ToString("##0");
            return myDecimal;
        }

        public static string ParseIntegerWithComma(int value)
        {
            string myDecimal = string.Empty;

            myDecimal = value.ToString("##0.#0");
            return myDecimal;
        }

        public static string ParseDateTime(DateTime? value, string formatDate)
        {
            string myDate = string.Empty;

            myDate = Convert.ToDateTime(value).ToString(formatDate);
            return myDate;
        }
        public static void CreateDirectoryInFolderUploads(string path)
        {

            Directory.CreateDirectory(path);
        }

        public static void DeleteFileInFolderUploads(string path)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

        }

        public static IEnumerable<T> GetEntities<T>(DataTable dt)
        {
            if (dt == null)
            {
                return null;
            }

            List<T> returnValue = new List<T>();
            List<string> typeProperties = new List<string>();

            T typeInstance = Activator.CreateInstance<T>();

            foreach (DataColumn column in dt.Columns)
            {
                var prop = typeInstance.GetType().GetProperty(column.ColumnName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                if (prop != null)
                {
                    typeProperties.Add(column.ColumnName);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                T entity = Activator.CreateInstance<T>();

                foreach (var propertyName in typeProperties)
                {

                    if (row[propertyName] != DBNull.Value)
                    {
                        string str = row[propertyName].GetType().FullName;

                        if (entity.GetType().GetProperty(propertyName).PropertyType == typeof(System.String))
                        {
                            object Val = row[propertyName].ToString();
                            entity.GetType().GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, Val, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public, null, null, null);
                        }
                        else if (entity.GetType().GetProperty(propertyName).PropertyType == typeof(System.Guid))
                        {
                            object Val = Guid.Parse(row[propertyName].ToString());
                            entity.GetType().GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, Val, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public, null, null, null);
                        }
                        else
                        {
                            entity.GetType().GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, row[propertyName], BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public, null, null, null);
                        }
                    }
                    else
                    {
                        entity.GetType().GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public).SetValue(entity, null, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public, null, null, null);
                    }
                }

                returnValue.Add(entity);
            }

            return returnValue.AsEnumerable();
        }

    }

}

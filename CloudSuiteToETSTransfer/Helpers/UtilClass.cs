using Microsoft.Kiota.Abstractions;
using System.Configuration;
using System.Reflection;

namespace CloudSuiteToETSTransfer.Helpers
{
    public class UtilClass
    {
       
        public void WriteToLogFile( string logEntry)
        {
            string applicationPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullFilePath = applicationPath + @"\Logs\Log_" + DateTime.Now.ToString("MM-dd-yyyy") + ".log";
            try
            {
                if (!Path.Exists(fullFilePath))
                {
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(fullFilePath));
                }
                using (StreamWriter w = System.IO.File.AppendText(fullFilePath))
                {
                    w.WriteLine(DateTime.Now.ToString("MM-dd-yy H:mm:ss") + " : " + logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to log file: " + ex.Message);
                // Optionally, you can throw the exception or handle it as needed   
            }
        }
        public bool StartsWith(string value,string startsWith)
        {
            value = value.Trim();
            startsWith = startsWith.Trim();
            if(value.Length==0 || startsWith.Length==0)
            {
                return false;
            }
            if (value.Length < startsWith.Length)
            {
                return false;
            }
                
            if (value.ToUpper().Substring(0, startsWith.ToUpper().Length) == startsWith)
            {
                return true;
            }

                return false;
        }
        public DateTime ConvertSLDateStringToDateTime(string slDateString)
        {
            // SL date format is YYYYMMDD
            if ( slDateString==null || slDateString.Length < 8)
            {
                return DateTime.MinValue;
            }
            try
            {
                int year = Convert.ToInt32(slDateString.Substring(0, 4));
                int month = Convert.ToInt32(slDateString.Substring(4, 2));
                int day = Convert.ToInt32(slDateString.Substring(6, 2));
                return new DateTime(year, month, day);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
        public DateTime ToDateTime(object value) 
        {
            DateTime dateTime;
            try
            {
                dateTime = Convert.ToDateTime(ToStringTrimmed(value));
                return dateTime;
            }catch (Exception) { 
                return DateTime.MinValue;
            }
        }
        
        public bool PartialMatch(string fullString, string subString)
        {
            if (fullString.ToUpper().IndexOf(subString.ToUpper()) != -1)
            {
                return true;
            }
            return false;
        }
        public bool IsNumeric(String value)
        {
            try
            {
                if(Double.TryParse(value, out double number))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool IsInt(String value)
        {
            try
            {
                var number = Convert.ToInt32(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string ToStringTrimmed(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            return value.ToString().Trim();
        }
        public int ToInt(object value)
        {
            if (value == null)
            {
                return 0;
            }
            try
            {
                return Convert.ToInt32(value.ToString().Trim());
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
        public decimal ToDecimal(object value)
        {
            if (value == null)
            {
                return 0;
            }
            try
            {
                var decimalValue = Convert.ToDecimal(value.ToString().Trim());
                var truncatedValue = Math.Truncate(decimalValue * 1000) / 1000;
                return truncatedValue;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public double ToDouble(object value)
        {
            if (value == null)
            {
                return 0;
            }
            try
            {
                var doubleValue = Convert.ToDouble(value.ToString().Trim());
                var truncatedValue = doubleValue;

                return truncatedValue;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public float ToFloat(object value)
        {
            if (value == null)
            {
                return 0;
            }
            try
            {
                var floatValue = float.Parse(value.ToString().Trim());
                var truncatedValue = floatValue;

                return truncatedValue;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public long ToLong(object value)
        {
            if (value == null)
            {
                return 0;
            }
            try
            {
                return Convert.ToInt64(value.ToString().Trim());
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

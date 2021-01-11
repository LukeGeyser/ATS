using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATS.Models;

namespace ATS.Helpers
{
    public static class FileHandler
    {
        private const string _FILENAME = "error_log.txt";

        public static void WriteError(ErrorModel error)
        {
            using (StreamWriter writer = new StreamWriter(_FILENAME, true))
            {
                writer.WriteLine($"{error.DateTime}|{error.Error}|{error.OtherParameter}|{error.Exchange}");
            }
        }

        public static List<ErrorModel> GetErrors()
        {
            List<ErrorModel> errors = new List<ErrorModel>();

            using (StreamReader reader = new StreamReader(_FILENAME))
            {
                string[] _arrayData = new string[4];
                string _tempData;
                _tempData = reader.ReadLine();

                while (_tempData != null)
                {
                    _arrayData = _tempData.Split('|');

                    errors.Add(new ErrorModel(_arrayData[0], _arrayData[1], _arrayData[2], _arrayData[3]));

                    _arrayData = null;
                    _tempData = reader.ReadLine();
                }
            }
            
            return errors.GetRange(errors.Count - 5, 5);
        }
    }
}

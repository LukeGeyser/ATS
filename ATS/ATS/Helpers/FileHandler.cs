using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ATS.Models;
using System.Diagnostics;
using System.Windows.Forms;

namespace ATS.Helpers
{
    public static class FileHandler
    {
        private const string _FILENAME = "error_log.txt";
        static string path = Directory.GetCurrentDirectory() + '\\' + _FILENAME;

        public static void WriteError(ErrorModel error)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Close();
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{error.DateTime}|{error.Error}|{error.OtherParameter}|{error.Exchange}");
            }
        }

        public static List<ErrorModel> GetErrors()
        {
            List<ErrorModel> errors = new List<ErrorModel>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Close();

                using (StreamReader reader = new StreamReader(path))
                {
                    string[] _arrayData = new string[4];
                    string _tempData;
                    _tempData = reader.ReadLine();
                    Debug.WriteLine(_tempData);

                    while (_tempData != null)
                    {
                        _arrayData = _tempData.Split('|');

                        errors.Add(new ErrorModel(_arrayData[0], _arrayData[1], _arrayData[2], _arrayData[3]));

                        _arrayData = null;
                        _tempData = reader.ReadLine();
                    }

                    return errors.GetRange(errors.Count - 5, 5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return errors;
            }
        }
    }
}

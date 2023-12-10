using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PomazDS.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            string str = null;
            string[] strArr = new string[1];
            string[] newStr = new string[File.ReadAllLines(path).Count() - 1];
            using (StreamReader sr = new StreamReader(path))
            {
                if (sr.Peek() > -1)
                {
                    for (int i = 0; i < newStr.Length; i++)
                    {
                        str = sr.ReadLine();
                        strArr = str.Split();
                        if (str != string.Empty)
                        {

                            newStr[i] = strArr[strArr.Length - 2];
                        }

                    }
                }
            }

            str = String.Join("\r\n", newStr);
            return str;
        }
    }
}



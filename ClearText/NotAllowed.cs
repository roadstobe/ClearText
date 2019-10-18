using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearText
{
    class NotAllowed
    {
        public static string GetPath()
        {
            string path = "";
            using (OpenFileDialog file = new OpenFileDialog())
            {
                //file.ShowDialog();
                if (file.ShowDialog() == DialogResult.OK)
                    path = file.FileName;
            }
            
            return path;
        }
        public static string[] LoadNotAllowedWord()
        {
            string[] result = { "" };
            string path = GetPath();

            if (path == "")
            {
                MessageBox.Show("Not found path to file", "Path error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string str = reader.ReadToEnd();
                    char[] spliter =  { ' ', '/'};
                    result = str.Split(spliter);
                }
            }

            return result;
        }
        static char[] MySplitter()
        {
            char[] splitter = new char[50];
            int iteratorForChar = 0;
            for (int i = 32; i <= 64; i++)
            {
                splitter[iteratorForChar] = (char)i;
                iteratorForChar++;
            }
            for (int i = 91; i < 97; i++)
            {
                splitter[iteratorForChar] = (char)i;
                iteratorForChar++;
            }
            for (int i = 123; i < 127; i++)
            {
                splitter[iteratorForChar] = (char)i;
                iteratorForChar++;
            }
            return splitter;
        }
        public static string CheckWord(string text, List<string> notAllow, ref List<string>stat)
        {
            string result = "";
            bool isCorrect = false;
            char[] splitter = MySplitter();

            List<char> temp = new List<char>();
            List<char> saveTemp = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                isCorrect = true;
                while(i != text.Length)
                {
                    if (!splitter.Contains(text[i]))
                    {
                        temp.Add(text[i]);
                        i++;
                        //saveTemp.Add(text[i]);
                    }
                    else
                    {
                        saveTemp.Add(text[i]);
                        break;
                    }
                    
                    
                }
                string readyStr = new string(temp.ToArray());
                string saveStr = new string(saveTemp.ToArray());
                if(readyStr.Length > 2)
                    foreach (var item in notAllow)
                    {
                        if(item.ToLower() == readyStr.ToLower())
                        {
                            stat.Add(item);
                            isCorrect = false;
                            break;
                        }
                    }

                result += isCorrect ? readyStr + saveStr: "*******" + saveStr;
                temp.Clear();
                saveTemp.Clear();
            }
            //string[] textForCheck = text.Split(spliter);
            //foreach (var word in textForCheck)
            //{
            //    isCorrect = true;
            //    foreach (var item in notAllow)
            //    {
            //        if(word.ToString().ToLower() == item.ToString().ToLower())
            //        {
            //            result += "*******";
            //            isCorrect = false;
            //            break;
            //        }
            //    }
            //    result += isCorrect ? word : "";
            //    result += " ";
                
            //}

            return result;
        }
        public static string FillStatic(List<string> stat)
        {
            string result = "";
            int count = 0;
            //stat.ForEach(i => 
            //{

            //    foreach (var item in stat)
            //    {
            //        if (i == item)
            //            count++;
            //    }

            //});
            List<int> order = new List<int>();
            for (int i = 0; i < stat.Count; i++)
            {
                if (order.Contains(i))
                    continue;
                for (int j = i; j < stat.Count; j++)
                {
                    if (stat[i].Equals(stat[j]))
                    {
                        if (order.Contains(j))
                            continue;
                        else
                        {
                            order.Add(j);
                            count++;
                        }
                    }

                }
                result += $"{stat[i]} - ({count}) {(char)13}";
                count = 0;
                
            }
            return result;
        }


    }
}

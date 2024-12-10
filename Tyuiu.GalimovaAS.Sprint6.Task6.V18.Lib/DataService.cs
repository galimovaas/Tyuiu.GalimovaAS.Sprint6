using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GalimovaAS.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder resStr = new StringBuilder(); 

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] res = line.Split(' ');
                    foreach (var word in res) 
                    {
                        if (word.Contains("n", StringComparison.OrdinalIgnoreCase)) 
                        {
                            resStr.Append(word + " "); 
                        }
                    }
                }
            }

            return resStr.ToString().Trim();
        }
    }
}

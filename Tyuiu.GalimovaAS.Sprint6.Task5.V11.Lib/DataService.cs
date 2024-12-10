namespace Tyuiu.GalimovaAS.Sprint6.Task5.V11.Lib
{
    public class DataService : ISprint6Task5V11
    {
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }

            }

            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }


            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double y;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    foreach (string value2 in arr)
                    {
                        bool check = false;
                        foreach (char tempchar in value2)
                        {

    }
}

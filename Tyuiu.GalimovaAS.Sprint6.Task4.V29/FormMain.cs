using Tyuiu.GalimovaAS.Sprint6.Task4.V29.Lib;
namespace Tyuiu.GalimovaAS.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int BoxStart = Convert.ToInt32(textBoxStart.Text);
                int BoxEnd = Convert.ToInt32(textBoxEnd.Text);
                int len = ds.GetMassFunction(BoxStart, BoxEnd).Length;
                double[] arr = new double[len];
                double[] valarr = ds.GetMassFunction(BoxStart, BoxEnd);

                this.chartFunc.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult.Text = "";
                chartFunc.Series[0].Points.AddXY(BoxStart, valarr);
                for (int i = 0; i < len; i++)
                {
                    this.chartFunc.Series[0].Points.AddXY(BoxStart, valarr);
                    textBoxResult.AppendText(valarr[i] + Environment.NewLine);
                    BoxStart++;
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void chartFunc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "Сохранен успешно\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                dialogResult = DialogResult.Yes;
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }
    }
}

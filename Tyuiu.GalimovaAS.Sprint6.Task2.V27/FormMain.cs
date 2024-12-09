using Tyuiu.GalimovaAS.Sprint6.Task2.V27.Lib;
namespace Tyuiu.GalimovaAS.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                double[] valueArray = ds.GetMassFunction(start, end);
                this.dataGridViewFunction.Rows.Clear();
                this.chartFunction.Series[0].Points.Clear();
                this.chartFunction.Titles.Clear();
                this.chartFunction.Titles.Add("График функции sin(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction.Rows.Add(start.ToString(), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void chartFunction_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void chartFunction_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.DarkBlue;
        }

        private void chartFunction_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-24-1 Галимова Алина Салаватовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}

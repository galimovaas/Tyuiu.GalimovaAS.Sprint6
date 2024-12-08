using Tyuiu.GalimovaAS.Sprint6.Task0.V24.Lib;
namespace Tyuiu.GalimovaAS.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void FormMain_Click(object sender, EventArgs e)
        {

        }

        private void textResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelpClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУБ-24-1 Галимова Алина Салаватовна", "Введены неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneClick_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }

}

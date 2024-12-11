namespace Tyuiu.GalimovaAS.Sprint6.Task6.V18
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonSave = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxTask = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            labelTemp = new Label();
            textBox1 = new TextBox();
            buttonHelp = new Button();
            buttonSaveFile = new Button();
            button1 = new Button();
            buttonOpenFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(729, 23);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 57);
            buttonSave.TabIndex = 52;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.AppWorkspace;
            buttonDone.Location = new Point(600, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(105, 57);
            buttonDone.TabIndex = 51;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.AppWorkspace;
            buttonInfo.Location = new Point(493, 23);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(82, 57);
            buttonInfo.TabIndex = 50;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(-2, 12);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(480, 83);
            textBoxTask.TabIndex = 53;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Результат вывести в виде таблицы. ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(399, 157);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(487, 283);
            dataGridView2.TabIndex = 61;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(405, 283);
            dataGridView1.TabIndex = 60;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Location = new Point(-12, 72);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(67, 20);
            labelTemp.TabIndex = 59;
            labelTemp.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(-12, 95);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(898, 56);
            textBox1.TabIndex = 58;
            textBox1.Text = "Дан файл, в котором хранится матрица.Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в третьем столбце значения в диапозоне от 1 до 5 на 7. ";
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(822, 14);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(64, 52);
            buttonHelp.TabIndex = 57;
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(214, 10);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(94, 59);
            buttonSaveFile.TabIndex = 56;
            buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(98, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 59);
            button1.TabIndex = 55;
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(-12, 10);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(94, 59);
            buttonOpenFile.TabIndex = 54;
            buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(labelTemp);
            Controls.Add(textBox1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSaveFile);
            Controls.Add(button1);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxTask);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBoxTask;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label labelTemp;
        private TextBox textBox1;
        private Button buttonHelp;
        private Button buttonSaveFile;
        private Button button1;
        private Button buttonOpenFile;
    }
}

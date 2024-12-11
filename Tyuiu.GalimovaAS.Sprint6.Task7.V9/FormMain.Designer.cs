namespace Tyuiu.GalimovaAS.Sprint6.Task7.V9
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridViewOut = new DataGridView();
            dataGridViewIn = new DataGridView();
            labelTemp = new Label();
            textBox1 = new TextBox();
            buttonHelp = new Button();
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(415, 153);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(487, 283);
            dataGridViewOut.TabIndex = 69;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(4, 153);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(405, 283);
            dataGridViewIn.TabIndex = 68;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Location = new Point(4, 68);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(67, 20);
            labelTemp.TabIndex = 67;
            labelTemp.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(4, 91);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(898, 56);
            textBox1.TabIndex = 66;
            textBox1.Text = "Дан файл, в котором хранится матрица.Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в третьем столбце значения в диапозоне от 1 до 5 на 7. ";
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(838, 10);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(64, 52);
            buttonHelp.TabIndex = 65;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonHelp_MouseEnter;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(230, 6);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(94, 59);
            buttonSaveFile.TabIndex = 64;
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            buttonSaveFile.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(114, 6);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 59);
            buttonDone.TabIndex = 63;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(4, 6);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(94, 59);
            buttonOpenFile.TabIndex = 62;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 451);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(labelTemp);
            Controls.Add(textBox1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSaveFile);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOut;
        private DataGridView dataGridViewIn;
        private Label labelTemp;
        private TextBox textBox1;
        private Button buttonHelp;
        private Button buttonSaveFile;
        private Button buttonDone;
        private Button buttonOpenFile;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private ToolTip toolTipButton;
    }
}

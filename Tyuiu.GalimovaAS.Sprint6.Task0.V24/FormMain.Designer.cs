namespace Tyuiu.GalimovaAS.Sprint6.Task0.V24
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
            textBoxTask_GAS = new TextBox();
            textBoxData_GAS = new TextBox();
            textBoxRes_GAS = new TextBox();
            pictureBox1 = new PictureBox();
            labelTerm_GAS = new Label();
            labelPutData_GAS = new Label();
            labelOutputData_GAS = new Label();
            labelVarX_GAS = new Label();
            labelResult_GAS = new Label();
            textBoxVarX = new TextBox();
            textBoxResult = new TextBox();
            buttonHelpClick = new Button();
            buttonDoneClick = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_GAS
            // 
            textBoxTask_GAS.BackColor = SystemColors.Menu;
            textBoxTask_GAS.Location = new Point(13, 45);
            textBoxTask_GAS.Multiline = true;
            textBoxTask_GAS.Name = "textBoxTask_GAS";
            textBoxTask_GAS.ReadOnly = true;
            textBoxTask_GAS.Size = new Size(775, 224);
            textBoxTask_GAS.TabIndex = 0;
            textBoxTask_GAS.Text = "Вычислить выражение по формуле:";
            // 
            // textBoxData_GAS
            // 
            textBoxData_GAS.BackColor = SystemColors.Menu;
            textBoxData_GAS.Location = new Point(12, 292);
            textBoxData_GAS.Multiline = true;
            textBoxData_GAS.Name = "textBoxData_GAS";
            textBoxData_GAS.Size = new Size(370, 113);
            textBoxData_GAS.TabIndex = 1;
            // 
            // textBoxRes_GAS
            // 
            textBoxRes_GAS.BackColor = SystemColors.Menu;
            textBoxRes_GAS.Location = new Point(388, 292);
            textBoxRes_GAS.Multiline = true;
            textBoxRes_GAS.Name = "textBoxRes_GAS";
            textBoxRes_GAS.Size = new Size(400, 113);
            textBoxRes_GAS.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_12_08_16_25_40;
            pictureBox1.Location = new Point(544, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 78);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelTerm_GAS
            // 
            labelTerm_GAS.AutoSize = true;
            labelTerm_GAS.Font = new Font("Segoe UI", 10F);
            labelTerm_GAS.Location = new Point(13, 19);
            labelTerm_GAS.Name = "labelTerm_GAS";
            labelTerm_GAS.Size = new Size(75, 23);
            labelTerm_GAS.TabIndex = 4;
            labelTerm_GAS.Text = "Условие";
            // 
            // labelPutData_GAS
            // 
            labelPutData_GAS.AutoSize = true;
            labelPutData_GAS.Font = new Font("Segoe UI", 10F);
            labelPutData_GAS.Location = new Point(12, 281);
            labelPutData_GAS.Name = "labelPutData_GAS";
            labelPutData_GAS.Size = new Size(115, 23);
            labelPutData_GAS.TabIndex = 5;
            labelPutData_GAS.Text = "Ввод данных:";
            // 
            // labelOutputData_GAS
            // 
            labelOutputData_GAS.AutoSize = true;
            labelOutputData_GAS.Font = new Font("Segoe UI", 10F);
            labelOutputData_GAS.Location = new Point(388, 281);
            labelOutputData_GAS.Name = "labelOutputData_GAS";
            labelOutputData_GAS.Size = new Size(127, 23);
            labelOutputData_GAS.TabIndex = 6;
            labelOutputData_GAS.Text = "Вывод данных:";
            // 
            // labelVarX_GAS
            // 
            labelVarX_GAS.AutoSize = true;
            labelVarX_GAS.Location = new Point(121, 324);
            labelVarX_GAS.Name = "labelVarX_GAS";
            labelVarX_GAS.Size = new Size(109, 20);
            labelVarX_GAS.TabIndex = 7;
            labelVarX_GAS.Text = "Переменная x";
            // 
            // labelResult_GAS
            // 
            labelResult_GAS.AutoSize = true;
            labelResult_GAS.Location = new Point(564, 324);
            labelResult_GAS.Name = "labelResult_GAS";
            labelResult_GAS.Size = new Size(79, 20);
            labelResult_GAS.TabIndex = 8;
            labelResult_GAS.Text = "Результат ";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(105, 347);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(146, 27);
            textBoxVarX.TabIndex = 9;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(527, 347);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(146, 27);
            textBoxResult.TabIndex = 10;
            textBoxResult.Click += textResult_Click;
            // 
            // buttonHelpClick
            // 
            buttonHelpClick.FlatStyle = FlatStyle.Flat;
            buttonHelpClick.Location = new Point(635, 411);
            buttonHelpClick.Name = "buttonHelpClick";
            buttonHelpClick.Size = new Size(35, 29);
            buttonHelpClick.TabIndex = 11;
            buttonHelpClick.Text = "?";
            buttonHelpClick.UseVisualStyleBackColor = true;
            buttonHelpClick.Click += buttonHelpClick_Click;
            // 
            // buttonDoneClick
            // 
            buttonDoneClick.FlatStyle = FlatStyle.Flat;
            buttonDoneClick.Location = new Point(676, 411);
            buttonDoneClick.Name = "buttonDoneClick";
            buttonDoneClick.Size = new Size(112, 29);
            buttonDoneClick.TabIndex = 12;
            buttonDoneClick.Text = "Выполнить";
            buttonDoneClick.UseVisualStyleBackColor = true;
            buttonDoneClick.Click += buttonDoneClick_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDoneClick);
            Controls.Add(buttonHelpClick);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxVarX);
            Controls.Add(labelResult_GAS);
            Controls.Add(labelVarX_GAS);
            Controls.Add(labelOutputData_GAS);
            Controls.Add(labelPutData_GAS);
            Controls.Add(labelTerm_GAS);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxRes_GAS);
            Controls.Add(textBoxData_GAS);
            Controls.Add(textBoxTask_GAS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Спринт 6 | Таск 0 | Вариант 24 | Галимова А.С.";
            Load += FormMain_Load;
            Click += FormMain_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask_GAS;
        private TextBox textBoxData_GAS;
        private TextBox textBoxRes_GAS;
        private PictureBox pictureBox1;
        private Label labelTerm_GAS;
        private Label labelPutData_GAS;
        private Label labelOutputData_GAS;
        private Label labelVarX_GAS;
        private Label labelResult_GAS;
        private TextBox textBoxVarX;
        private TextBox textBoxResult;
        private Button buttonHelpClick;
        private Button buttonDoneClick;
    }
}

namespace Tyuiu.GalimovaAS.Sprint6.Task1.V22
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
            textBoxTask = new TextBox();
            textBoxResult = new TextBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            textBoxData = new TextBox();
            labelRes = new Label();
            labelPutData = new Label();
            labelTerm = new Label();
            labelOutPutData = new Label();
            labelDone = new Label();
            labelStart = new Label();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(12, 34);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(492, 179);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию cos(x) на заданном диапозоне. Результат вывести в виде таблицы. ";
            textBoxTask.TextChanged += textBox1_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlLight;
            textBoxResult.Location = new Point(510, 34);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(278, 333);
            textBoxResult.TabIndex = 1;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.AppWorkspace;
            buttonInfo.Location = new Point(300, 233);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 118);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.AppWorkspace;
            buttonDone.Location = new Point(400, 233);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 118);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxData
            // 
            textBoxData.BackColor = SystemColors.Menu;
            textBoxData.Location = new Point(12, 233);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(282, 118);
            textBoxData.TabIndex = 4;
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(510, 34);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(78, 20);
            labelRes.TabIndex = 5;
            labelRes.Text = "Результат:";
            // 
            // labelPutData
            // 
            labelPutData.AutoSize = true;
            labelPutData.Location = new Point(12, 216);
            labelPutData.Name = "labelPutData";
            labelPutData.Size = new Size(99, 20);
            labelPutData.TabIndex = 6;
            labelPutData.Text = "Ввод данных";
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Location = new Point(12, 14);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(70, 20);
            labelTerm.TabIndex = 7;
            labelTerm.Text = "Условие:";
            // 
            // labelOutPutData
            // 
            labelOutPutData.AutoSize = true;
            labelOutPutData.Location = new Point(510, 14);
            labelOutPutData.Name = "labelOutPutData";
            labelOutPutData.Size = new Size(110, 20);
            labelOutPutData.TabIndex = 8;
            labelOutPutData.Text = "Вывод данных";
            // 
            // labelDone
            // 
            labelDone.AutoSize = true;
            labelDone.Location = new Point(151, 256);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(94, 20);
            labelDone.TabIndex = 9;
            labelDone.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(12, 256);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(88, 20);
            labelStart.TabIndex = 10;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 293);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(99, 27);
            textBoxStart.TabIndex = 11;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(151, 293);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(103, 27);
            textBoxStop.TabIndex = 12;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(labelStart);
            Controls.Add(labelDone);
            Controls.Add(labelOutPutData);
            Controls.Add(labelTerm);
            Controls.Add(labelPutData);
            Controls.Add(labelRes);
            Controls.Add(textBoxData);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 22 | Галимова А.С.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private Button buttonInfo;
        private Button buttonDone;
        private TextBox textBoxData;
        private Label labelRes;
        private Label labelPutData;
        private Label labelTerm;
        private Label labelOutPutData;
        private Label labelDone;
        private Label labelStart;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
    }
}

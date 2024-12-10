namespace Tyuiu.GalimovaAS.Sprint6.Task4.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            labelStart = new Label();
            labelDone = new Label();
            labelTerm = new Label();
            labelPutData = new Label();
            textBoxData = new TextBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxTask = new TextBox();
            buttonSave = new Button();
            textBoxResult = new TextBox();
            label1 = new Label();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(644, 68);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(91, 27);
            textBoxEnd.TabIndex = 35;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(504, 68);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(87, 27);
            textBoxStart.TabIndex = 34;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(503, 45);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(88, 20);
            labelStart.TabIndex = 33;
            labelStart.Text = "Старт шага:";
            // 
            // labelDone
            // 
            labelDone.AutoSize = true;
            labelDone.Location = new Point(644, 45);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(94, 20);
            labelDone.TabIndex = 32;
            labelDone.Text = "Конец шага:";
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Location = new Point(6, 12);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(70, 20);
            labelTerm.TabIndex = 31;
            labelTerm.Text = "Условие:";
            // 
            // labelPutData
            // 
            labelPutData.AutoSize = true;
            labelPutData.Location = new Point(492, 9);
            labelPutData.Name = "labelPutData";
            labelPutData.Size = new Size(99, 20);
            labelPutData.TabIndex = 30;
            labelPutData.Text = "Ввод данных";
            // 
            // textBoxData
            // 
            textBoxData.BackColor = SystemColors.Menu;
            textBoxData.Location = new Point(492, 32);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(270, 83);
            textBoxData.TabIndex = 29;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.AppWorkspace;
            buttonDone.Location = new Point(859, 49);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(105, 57);
            buttonDone.TabIndex = 28;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.AppWorkspace;
            buttonInfo.Location = new Point(771, 49);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(82, 57);
            buttonInfo.TabIndex = 27;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(6, 32);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(480, 83);
            textBoxTask.TabIndex = 26;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Результат вывести в виде таблицы. ";
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(970, 49);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 57);
            buttonSave.TabIndex = 36;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 136);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(253, 350);
            textBoxResult.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 118);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 38;
            label1.Text = "Вывод";
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(328, 121);
            chartFunc.Name = "chartFunc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(636, 375);
            chartFunc.TabIndex = 39;
            chartFunc.Text = "chart1";
            title1.Name = "Функция sin(x)";
            title1.Text = "Функция sin(x)";
            chartFunc.Titles.Add(title1);
            chartFunc.Click += chartFunc_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 498);
            Controls.Add(chartFunc);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Controls.Add(labelStart);
            Controls.Add(labelDone);
            Controls.Add(labelTerm);
            Controls.Add(labelPutData);
            Controls.Add(textBoxData);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxTask);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Label labelStart;
        private Label labelDone;
        private Label labelTerm;
        private Label labelPutData;
        private TextBox textBoxData;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBoxTask;
        private Button buttonSave;
        private TextBox textBoxResult;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
    }
}

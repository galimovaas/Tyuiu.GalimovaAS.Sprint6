namespace Tyuiu.GalimovaAS.Sprint6.Task2.V27
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
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            labelStart = new Label();
            labelDone = new Label();
            labelOutPutData = new Label();
            labelTerm = new Label();
            labelPutData = new Label();
            labelRes = new Label();
            textBoxData = new TextBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxTask = new TextBox();
            textBox1 = new TextBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(151, 328);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(103, 27);
            textBoxEnd.TabIndex = 25;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 328);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(99, 27);
            textBoxStart.TabIndex = 24;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(12, 291);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(88, 20);
            labelStart.TabIndex = 23;
            labelStart.Text = "Старт шага:";
            // 
            // labelDone
            // 
            labelDone.AutoSize = true;
            labelDone.Location = new Point(151, 291);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(94, 20);
            labelDone.TabIndex = 22;
            labelDone.Text = "Конец шага:";
            // 
            // labelOutPutData
            // 
            labelOutPutData.AutoSize = true;
            labelOutPutData.Location = new Point(510, 49);
            labelOutPutData.Name = "labelOutPutData";
            labelOutPutData.Size = new Size(110, 20);
            labelOutPutData.TabIndex = 21;
            labelOutPutData.Text = "Вывод данных";
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Location = new Point(12, 49);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(70, 20);
            labelTerm.TabIndex = 20;
            labelTerm.Text = "Условие:";
            // 
            // labelPutData
            // 
            labelPutData.AutoSize = true;
            labelPutData.Location = new Point(12, 251);
            labelPutData.Name = "labelPutData";
            labelPutData.Size = new Size(99, 20);
            labelPutData.TabIndex = 19;
            labelPutData.Text = "Ввод данных";
            // 
            // labelRes
            // 
            labelRes.AutoSize = true;
            labelRes.Location = new Point(510, 66);
            labelRes.Name = "labelRes";
            labelRes.Size = new Size(78, 20);
            labelRes.TabIndex = 18;
            labelRes.Text = "Результат:";
            // 
            // textBoxData
            // 
            textBoxData.BackColor = SystemColors.Menu;
            textBoxData.Location = new Point(12, 268);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(282, 118);
            textBoxData.TabIndex = 17;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.AppWorkspace;
            buttonDone.Location = new Point(400, 268);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 118);
            buttonDone.TabIndex = 16;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.AppWorkspace;
            buttonInfo.Location = new Point(300, 268);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 118);
            buttonInfo.TabIndex = 15;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(12, 69);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(492, 179);
            textBoxTask.TabIndex = 13;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Результат вывести в виде таблицы. ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(615, 369);
            textBox1.TabIndex = 26;
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewFunction.Location = new Point(523, 83);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(251, 336);
            dataGridViewFunction.TabIndex = 27;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.MinimumWidth = 6;
            FX.Name = "FX";
            FX.Width = 125;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(790, 74);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(457, 361);
            chartFunction.TabIndex = 28;
            chartFunction.Text = "chart1";
            chartFunction.MouseDown += chartFunction_MouseDown;
            chartFunction.MouseLeave += chartFunction_MouseLeave;
            chartFunction.MouseUp += chartFunction_MouseUp;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 450);
            Controls.Add(chartFunction);
            Controls.Add(dataGridViewFunction);
            Controls.Add(textBox1);
            Controls.Add(textBoxEnd);
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
            Controls.Add(textBoxTask);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Label labelStart;
        private Label labelDone;
        private Label labelOutPutData;
        private Label labelTerm;
        private Label labelPutData;
        private Label labelRes;
        private TextBox textBoxData;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBoxTask;
        private TextBox textBox1;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

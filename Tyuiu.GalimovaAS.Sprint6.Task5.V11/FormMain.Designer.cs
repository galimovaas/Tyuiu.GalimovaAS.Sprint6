namespace Tyuiu.GalimovaAS.Sprint6.Task5.V11
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
            label1 = new Label();
            buttonSave = new Button();
            labelTerm = new Label();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxTask = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-138, 96);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 51;
            label1.Text = "Вывод";
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(702, 31);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 57);
            buttonSave.TabIndex = 49;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Location = new Point(-138, -10);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(70, 20);
            labelTerm.TabIndex = 44;
            labelTerm.Text = "Условие:";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.AppWorkspace;
            buttonDone.Location = new Point(591, 31);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(105, 57);
            buttonDone.TabIndex = 41;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.AppWorkspace;
            buttonInfo.Location = new Point(503, 31);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(82, 57);
            buttonInfo.TabIndex = 40;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(-5, 12);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(480, 83);
            textBoxTask.TabIndex = 39;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Результат вывести в виде таблицы. ";
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(362, 101);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(616, 375);
            chart1.TabIndex = 52;
            chart1.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(12, 118);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(300, 358);
            dataGridViewResult.TabIndex = 53;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 499);
            Controls.Add(dataGridViewResult);
            Controls.Add(chart1);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(labelTerm);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxTask);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSave;
        private Label labelTerm;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBoxTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridViewResult;
    }
}

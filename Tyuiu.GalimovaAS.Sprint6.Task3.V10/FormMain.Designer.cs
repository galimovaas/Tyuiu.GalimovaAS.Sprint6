namespace Tyuiu.GalimovaAS.Sprint6.Task3.V10
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
            labelTerm = new Label();
            textBoxTask = new TextBox();
            buttonDoneClick = new Button();
            buttonHelpClick = new Button();
            label1 = new Label();
            dataGridViewMatrix = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // labelTerm
            // 
            labelTerm.AutoSize = true;
            labelTerm.Location = new Point(1, 1);
            labelTerm.Name = "labelTerm";
            labelTerm.Size = new Size(70, 20);
            labelTerm.TabIndex = 9;
            labelTerm.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(1, 21);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(307, 179);
            textBoxTask.TabIndex = 8;
            textBoxTask.Text = "Протабулировать функцию cos(x) на заданном диапозоне. Результат вывести в виде таблицы. ";
            // 
            // buttonDoneClick
            // 
            buttonDoneClick.FlatStyle = FlatStyle.Flat;
            buttonDoneClick.Location = new Point(767, 171);
            buttonDoneClick.Name = "buttonDoneClick";
            buttonDoneClick.Size = new Size(112, 29);
            buttonDoneClick.TabIndex = 14;
            buttonDoneClick.Text = "Выполнить";
            buttonDoneClick.UseVisualStyleBackColor = true;
            buttonDoneClick.Click += buttonDoneClick_Click;
            // 
            // buttonHelpClick
            // 
            buttonHelpClick.FlatStyle = FlatStyle.Flat;
            buttonHelpClick.Location = new Point(717, 171);
            buttonHelpClick.Name = "buttonHelpClick";
            buttonHelpClick.Size = new Size(35, 29);
            buttonHelpClick.TabIndex = 13;
            buttonHelpClick.Text = "?";
            buttonHelpClick.UseVisualStyleBackColor = true;
            buttonHelpClick.Click += buttonHelpClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(717, 1);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 16;
            label1.Text = "Вывод данных";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewMatrix.Location = new Point(314, 6);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(382, 188);
            dataGridViewMatrix.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 206);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(label1);
            Controls.Add(buttonDoneClick);
            Controls.Add(buttonHelpClick);
            Controls.Add(labelTerm);
            Controls.Add(textBoxTask);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTerm;
        private TextBox textBoxTask;
        private Button buttonDoneClick;
        private Button buttonHelpClick;
        private Label label1;
        private DataGridView dataGridViewMatrix;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}

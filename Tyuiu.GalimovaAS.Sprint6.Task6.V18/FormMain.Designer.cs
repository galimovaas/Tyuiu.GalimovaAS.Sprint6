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
            buttonSave = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxTask = new TextBox();
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(textBoxTask);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBoxTask;
    }
}

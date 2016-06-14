namespace DFS_BFS_Graphics
{
    partial class SelectSearchAlgorithmForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.DFS_Button = new System.Windows.Forms.Button();
            this.BFS_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(108, 41);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Выбрать файл";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 1;
            // 
            // DFS_Button
            // 
            this.DFS_Button.Location = new System.Drawing.Point(127, 16);
            this.DFS_Button.Name = "DFS_Button";
            this.DFS_Button.Size = new System.Drawing.Size(161, 32);
            this.DFS_Button.TabIndex = 2;
            this.DFS_Button.Text = "DFS";
            this.DFS_Button.UseVisualStyleBackColor = true;
            this.DFS_Button.Click += new System.EventHandler(this.DFS_Button_Click);
            // 
            // BFS_Button
            // 
            this.BFS_Button.Location = new System.Drawing.Point(127, 60);
            this.BFS_Button.Name = "BFS_Button";
            this.BFS_Button.Size = new System.Drawing.Size(161, 32);
            this.BFS_Button.TabIndex = 3;
            this.BFS_Button.Text = "BFS";
            this.BFS_Button.UseVisualStyleBackColor = true;
            this.BFS_Button.Click += new System.EventHandler(this.BFS_Button_Click);
            // 
            // SelectSearchAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 104);
            this.Controls.Add(this.BFS_Button);
            this.Controls.Add(this.DFS_Button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectFileButton);
            this.Name = "SelectSearchAlgorithmForm";
            this.Text = "SearchAlgorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button DFS_Button;
        private System.Windows.Forms.Button BFS_Button;
    }
}


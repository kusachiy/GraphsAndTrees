namespace DFS_BFS_Graphics
{
    partial class SelectFindingOstovAlgoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kruskala_Button = new System.Windows.Forms.Button();
            this.Prima_Button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Kruskala_Button
            // 
            this.Kruskala_Button.Location = new System.Drawing.Point(129, 50);
            this.Kruskala_Button.Name = "Kruskala_Button";
            this.Kruskala_Button.Size = new System.Drawing.Size(169, 32);
            this.Kruskala_Button.TabIndex = 7;
            this.Kruskala_Button.Text = "Kruskala";
            this.Kruskala_Button.UseVisualStyleBackColor = true;
            this.Kruskala_Button.Click += new System.EventHandler(this.Kruskala_Button_Click);
            // 
            // Prima_Button
            // 
            this.Prima_Button.Location = new System.Drawing.Point(129, 12);
            this.Prima_Button.Name = "Prima_Button";
            this.Prima_Button.Size = new System.Drawing.Size(169, 32);
            this.Prima_Button.TabIndex = 6;
            this.Prima_Button.Text = "Prima";
            this.Prima_Button.UseVisualStyleBackColor = true;
            this.Prima_Button.Click += new System.EventHandler(this.Prima_Button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 5;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(15, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(108, 70);
            this.selectFileButton.TabIndex = 4;
            this.selectFileButton.Text = "Выбрать файл";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFindingOstovAlgoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 90);
            this.Controls.Add(this.Kruskala_Button);
            this.Controls.Add(this.Prima_Button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectFileButton);
            this.Name = "SelectFindingOstovAlgoForm";
            this.Text = "PrintOstov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kruskala_Button;
        private System.Windows.Forms.Button Prima_Button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
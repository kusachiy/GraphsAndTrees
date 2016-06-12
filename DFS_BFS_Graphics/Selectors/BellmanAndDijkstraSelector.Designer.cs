namespace DFS_BFS_Graphics
{
    partial class BellmanAndDijkstraSelector
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
            this.Dijkstra_Button = new System.Windows.Forms.Button();
            this.Bellman_Button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Dijkstra_Button
            // 
            this.Dijkstra_Button.Location = new System.Drawing.Point(122, 44);
            this.Dijkstra_Button.Name = "Dijkstra_Button";
            this.Dijkstra_Button.Size = new System.Drawing.Size(169, 32);
            this.Dijkstra_Button.TabIndex = 11;
            this.Dijkstra_Button.Text = "Dijksta";
            this.Dijkstra_Button.UseVisualStyleBackColor = true;
            this.Dijkstra_Button.Click += new System.EventHandler(this.Dijkstra_Button_Click);
            // 
            // Bellman_Button
            // 
            this.Bellman_Button.Location = new System.Drawing.Point(122, 6);
            this.Bellman_Button.Name = "Bellman_Button";
            this.Bellman_Button.Size = new System.Drawing.Size(169, 32);
            this.Bellman_Button.TabIndex = 10;
            this.Bellman_Button.Text = "Bellman";
            this.Bellman_Button.UseVisualStyleBackColor = true;
            this.Bellman_Button.Click += new System.EventHandler(this.Bellman_Button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(5, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 9;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(8, 6);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(108, 70);
            this.selectFileButton.TabIndex = 8;
            this.selectFileButton.Text = "Выбрать файл";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BellmanAndDijkstraSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 81);
            this.Controls.Add(this.Dijkstra_Button);
            this.Controls.Add(this.Bellman_Button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectFileButton);
            this.Name = "BellmanAndDijkstraSelector";
            this.Text = "BellmanAndDijkstraSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dijkstra_Button;
        private System.Windows.Forms.Button Bellman_Button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
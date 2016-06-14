namespace DFS_BFS_Graphics
{
    partial class VisualizerFloyd
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
            this.vizualizeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.runButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vizualizeButton
            // 
            this.vizualizeButton.Location = new System.Drawing.Point(693, 12);
            this.vizualizeButton.Name = "vizualizeButton";
            this.vizualizeButton.Size = new System.Drawing.Size(75, 23);
            this.vizualizeButton.TabIndex = 5;
            this.vizualizeButton.Text = "Vizualize";
            this.vizualizeButton.UseVisualStyleBackColor = true;
            this.vizualizeButton.Click += new System.EventHandler(this.vizualizeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 423);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(693, 41);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // VisualizerFloyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 439);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.vizualizeButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VisualizerFloyd";
            this.Text = "VisualizerFloyd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vizualizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button runButton;
    }
}
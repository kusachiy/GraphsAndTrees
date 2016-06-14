namespace DFS_BFS_Graphics
{
    partial class Menu
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
            this.searchesButton = new System.Windows.Forms.Button();
            this.skeletonButton = new System.Windows.Forms.Button();
            this.minamalPathButton = new System.Windows.Forms.Button();
            this.minamalPathButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchesButton
            // 
            this.searchesButton.Location = new System.Drawing.Point(13, 29);
            this.searchesButton.Name = "searchesButton";
            this.searchesButton.Size = new System.Drawing.Size(151, 35);
            this.searchesButton.TabIndex = 0;
            this.searchesButton.Text = "Поиск в графе";
            this.searchesButton.UseVisualStyleBackColor = true;
            this.searchesButton.Click += new System.EventHandler(this.searchesButton_Click);
            // 
            // skeletonButton
            // 
            this.skeletonButton.Location = new System.Drawing.Point(12, 70);
            this.skeletonButton.Name = "skeletonButton";
            this.skeletonButton.Size = new System.Drawing.Size(151, 35);
            this.skeletonButton.TabIndex = 1;
            this.skeletonButton.Text = "Минимальный остов";
            this.skeletonButton.UseVisualStyleBackColor = true;
            this.skeletonButton.Click += new System.EventHandler(this.skeletonButton_Click);
            // 
            // minamalPathButton
            // 
            this.minamalPathButton.Location = new System.Drawing.Point(13, 111);
            this.minamalPathButton.Name = "minamalPathButton";
            this.minamalPathButton.Size = new System.Drawing.Size(151, 35);
            this.minamalPathButton.TabIndex = 2;
            this.minamalPathButton.Text = "Кратчайшие пути из одной вершины до остальных";
            this.minamalPathButton.UseVisualStyleBackColor = true;
            this.minamalPathButton.Click += new System.EventHandler(this.minamalPathButton_Click);
            // 
            // minamalPathButton2
            // 
            this.minamalPathButton2.Location = new System.Drawing.Point(12, 152);
            this.minamalPathButton2.Name = "minamalPathButton2";
            this.minamalPathButton2.Size = new System.Drawing.Size(151, 35);
            this.minamalPathButton2.TabIndex = 3;
            this.minamalPathButton2.Text = "Кратчайшие пути между всеми вершинами";
            this.minamalPathButton2.UseVisualStyleBackColor = true;
            this.minamalPathButton2.Click += new System.EventHandler(this.minamalPathButton2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 200);
            this.Controls.Add(this.minamalPathButton2);
            this.Controls.Add(this.minamalPathButton);
            this.Controls.Add(this.skeletonButton);
            this.Controls.Add(this.searchesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchesButton;
        private System.Windows.Forms.Button skeletonButton;
        private System.Windows.Forms.Button minamalPathButton;
        private System.Windows.Forms.Button minamalPathButton2;
    }
}
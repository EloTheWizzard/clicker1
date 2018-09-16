namespace MouseClicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvl1 = new System.Windows.Forms.Button();
            this.numcl = new System.Windows.Forms.Label();
            this.lvl2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvl1
            // 
            this.lvl1.Image = ((System.Drawing.Image)(resources.GetObject("lvl1.Image")));
            this.lvl1.Location = new System.Drawing.Point(12, 86);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(248, 79);
            this.lvl1.TabIndex = 0;
            this.lvl1.Text = "lvl1";
            this.lvl1.UseVisualStyleBackColor = true;
            this.lvl1.Click += new System.EventHandler(this.Click_Click);
            // 
            // numcl
            // 
            this.numcl.AutoSize = true;
            this.numcl.Location = new System.Drawing.Point(338, 119);
            this.numcl.Name = "numcl";
            this.numcl.Size = new System.Drawing.Size(43, 13);
            this.numcl.TabIndex = 2;
            this.numcl.Text = "counter";
            // 
            // lvl2
            // 
            this.lvl2.Image = ((System.Drawing.Image)(resources.GetObject("lvl2.Image")));
            this.lvl2.Location = new System.Drawing.Point(467, 86);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(250, 79);
            this.lvl2.TabIndex = 3;
            this.lvl2.Text = "lvl2";
            this.lvl2.UseVisualStyleBackColor = true;
            this.lvl2.Click += new System.EventHandler(this.vistest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(319, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "motivation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.numcl);
            this.Controls.Add(this.lvl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mouse Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lvl1;
        private System.Windows.Forms.Label numcl;
        private System.Windows.Forms.Button lvl2;
        private System.Windows.Forms.Label label1;
    }
}


namespace Ula
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRITMETICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGICOToolStripMenuItem,
            this.aRITMETICOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGICOToolStripMenuItem
            // 
            this.lOGICOToolStripMenuItem.Name = "lOGICOToolStripMenuItem";
            this.lOGICOToolStripMenuItem.Size = new System.Drawing.Size(62, 89);
            this.lOGICOToolStripMenuItem.Text = "LOGICO";
            this.lOGICOToolStripMenuItem.Click += new System.EventHandler(this.lOGICOToolStripMenuItem_Click);
            // 
            // aRITMETICOToolStripMenuItem
            // 
            this.aRITMETICOToolStripMenuItem.Name = "aRITMETICOToolStripMenuItem";
            this.aRITMETICOToolStripMenuItem.Size = new System.Drawing.Size(88, 89);
            this.aRITMETICOToolStripMenuItem.Text = "ARITMETICO";
            this.aRITMETICOToolStripMenuItem.Click += new System.EventHandler(this.aRITMETICOToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGICOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRITMETICOToolStripMenuItem;
    }
}
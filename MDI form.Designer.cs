
namespace College_Fee_Record
{
    partial class frmMDI
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mdifrm = new System.Windows.Forms.ToolStripMenuItem();
            this.studentFeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mdifrm,
            this.studentFeeToolStripMenuItem,
            this.feeStructureToolStripMenuItem,
            this.lOGOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mdifrm
            // 
            this.mdifrm.Name = "mdifrm";
            this.mdifrm.Size = new System.Drawing.Size(84, 20);
            this.mdifrm.Text = "Student Info";
            this.mdifrm.Click += new System.EventHandler(this.studentInfoToolStripMenuItem_Click);
            // 
            // studentFeeToolStripMenuItem
            // 
            this.studentFeeToolStripMenuItem.Name = "studentFeeToolStripMenuItem";
            this.studentFeeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.studentFeeToolStripMenuItem.Text = "Student fee";
            this.studentFeeToolStripMenuItem.Click += new System.EventHandler(this.studentFeeToolStripMenuItem_Click);
            // 
            // feeStructureToolStripMenuItem
            // 
            this.feeStructureToolStripMenuItem.Name = "feeStructureToolStripMenuItem";
            this.feeStructureToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.feeStructureToolStripMenuItem.Text = "Fee structure";
            this.feeStructureToolStripMenuItem.Click += new System.EventHandler(this.feeStructureToolStripMenuItem_Click);
            // 
            // lOGOutToolStripMenuItem
            // 
            this.lOGOutToolStripMenuItem.Name = "lOGOutToolStripMenuItem";
            this.lOGOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.lOGOutToolStripMenuItem.Text = "LOG Out";
            this.lOGOutToolStripMenuItem.Click += new System.EventHandler(this.lOGOutToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMDI";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mdifrm;
        private System.Windows.Forms.ToolStripMenuItem studentFeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOutToolStripMenuItem;
    }
}
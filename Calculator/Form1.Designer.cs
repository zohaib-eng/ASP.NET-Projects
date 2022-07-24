
namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.checkBox1Garments = new System.Windows.Forms.CheckBox();
            this.checkBox2jewllery = new System.Windows.Forms.CheckBox();
            this.checkBox3others = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // txtitem
            // 
            this.txtitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Location = new System.Drawing.Point(67, 96);
            this.txtitem.Multiline = true;
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(128, 48);
            this.txtitem.TabIndex = 101;
            this.txtitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtitem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtitem.Enter += new System.EventHandler(this.txtitem_Enter);
            this.txtitem.Leave += new System.EventHandler(this.txtitem_Leave);
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(233, 96);
            this.txtrate.Multiline = true;
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(128, 48);
            this.txtrate.TabIndex = 102;
            this.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrate.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtrate.Enter += new System.EventHandler(this.txtrate_Enter);
            this.txtrate.Leave += new System.EventHandler(this.txtrate_Leave);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(399, 96);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(128, 48);
            this.txttotal.TabIndex = 103;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttotal.Enter += new System.EventHandler(this.txttotal_Enter);
            this.txttotal.Leave += new System.EventHandler(this.txttotal_Leave);
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrandtotal.Location = new System.Drawing.Point(565, 96);
            this.txtgrandtotal.Multiline = true;
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(128, 48);
            this.txtgrandtotal.TabIndex = 104;
            this.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtgrandtotal.Enter += new System.EventHandler(this.txtgrandtotal_Enter);
            this.txtgrandtotal.Leave += new System.EventHandler(this.txtgrandtotal_Leave);
            // 
            // checkBox1Garments
            // 
            this.checkBox1Garments.AutoSize = true;
            this.checkBox1Garments.Location = new System.Drawing.Point(96, 177);
            this.checkBox1Garments.Name = "checkBox1Garments";
            this.checkBox1Garments.Size = new System.Drawing.Size(71, 17);
            this.checkBox1Garments.TabIndex = 105;
            this.checkBox1Garments.Text = "Garments";
            this.checkBox1Garments.UseVisualStyleBackColor = true;
            // 
            // checkBox2jewllery
            // 
            this.checkBox2jewllery.AutoSize = true;
            this.checkBox2jewllery.Location = new System.Drawing.Point(96, 209);
            this.checkBox2jewllery.Name = "checkBox2jewllery";
            this.checkBox2jewllery.Size = new System.Drawing.Size(69, 17);
            this.checkBox2jewllery.TabIndex = 106;
            this.checkBox2jewllery.Text = "Jewellery";
            this.checkBox2jewllery.UseVisualStyleBackColor = true;
            this.checkBox2jewllery.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3others
            // 
            this.checkBox3others.AutoSize = true;
            this.checkBox3others.Location = new System.Drawing.Point(96, 241);
            this.checkBox3others.Name = "checkBox3others";
            this.checkBox3others.Size = new System.Drawing.Size(57, 17);
            this.checkBox3others.TabIndex = 107;
            this.checkBox3others.Text = "Others";
            this.checkBox3others.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 221);
            this.dataGridView1.TabIndex = 110;
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(593, 177);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(100, 39);
            this.btnresult.TabIndex = 108;
            this.btnresult.Text = "Result";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(593, 225);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(100, 39);
            this.btnprint.TabIndex = 109;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 531);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox3others);
            this.Controls.Add(this.checkBox2jewllery);
            this.Controls.Add(this.checkBox1Garments);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.CheckBox checkBox1Garments;
        private System.Windows.Forms.CheckBox checkBox2jewllery;
        private System.Windows.Forms.CheckBox checkBox3others;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}


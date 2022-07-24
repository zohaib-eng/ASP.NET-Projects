
namespace College_Fee_Record
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdetails = new System.Windows.Forms.TextBox();
            this.txtfine = new System.Windows.Forms.TextBox();
            this.txtmonthly = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldaterecieved = new System.Windows.Forms.Label();
            this.lblmonthly = new System.Windows.Forms.Label();
            this.lblfine = new System.Windows.Forms.Label();
            this.lbldetails = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(167, 108);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(205, 38);
            this.txtid.TabIndex = 401;
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
            // 
            // txtdetails
            // 
            this.txtdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetails.Location = new System.Drawing.Point(523, 224);
            this.txtdetails.Multiline = true;
            this.txtdetails.Name = "txtdetails";
            this.txtdetails.Size = new System.Drawing.Size(205, 38);
            this.txtdetails.TabIndex = 406;
            this.txtdetails.Enter += new System.EventHandler(this.txtdetails_Enter);
            this.txtdetails.Leave += new System.EventHandler(this.txtdetails_Leave);
            // 
            // txtfine
            // 
            this.txtfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfine.Location = new System.Drawing.Point(523, 166);
            this.txtfine.Multiline = true;
            this.txtfine.Name = "txtfine";
            this.txtfine.Size = new System.Drawing.Size(205, 38);
            this.txtfine.TabIndex = 405;
            this.txtfine.Enter += new System.EventHandler(this.txtfine_Enter);
            this.txtfine.Leave += new System.EventHandler(this.txtfine_Leave);
            // 
            // txtmonthly
            // 
            this.txtmonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthly.Location = new System.Drawing.Point(523, 108);
            this.txtmonthly.Multiline = true;
            this.txtmonthly.Name = "txtmonthly";
            this.txtmonthly.Size = new System.Drawing.Size(205, 38);
            this.txtmonthly.TabIndex = 404;
            this.txtmonthly.TextChanged += new System.EventHandler(this.txtmonthly_TextChanged);
            this.txtmonthly.Enter += new System.EventHandler(this.txtmonthly_Enter);
            this.txtmonthly.Leave += new System.EventHandler(this.txtmonthly_Leave);
            // 
            // txtstudentid
            // 
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(167, 166);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(205, 38);
            this.txtstudentid.TabIndex = 402;
            this.txtstudentid.Enter += new System.EventHandler(this.txtstudentid_Enter);
            this.txtstudentid.Leave += new System.EventHandler(this.txtstudentid_Leave);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(346, 317);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 38);
            this.btnsave.TabIndex = 407;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(459, 361);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(104, 38);
            this.btnreset.TabIndex = 410;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(459, 317);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 38);
            this.btnupdate.TabIndex = 408;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(346, 361);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 38);
            this.btndelete.TabIndex = 409;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 120);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 24);
            this.lblid.TabIndex = 411;
            this.lblid.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 412;
            this.label2.Text = "STUDENT ID";
            // 
            // lbldaterecieved
            // 
            this.lbldaterecieved.AutoSize = true;
            this.lbldaterecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaterecieved.Location = new System.Drawing.Point(12, 240);
            this.lbldaterecieved.Name = "lbldaterecieved";
            this.lbldaterecieved.Size = new System.Drawing.Size(153, 20);
            this.lbldaterecieved.TabIndex = 413;
            this.lbldaterecieved.Text = "DATE RECIEVED";
            // 
            // lblmonthly
            // 
            this.lblmonthly.AutoSize = true;
            this.lblmonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthly.Location = new System.Drawing.Point(414, 123);
            this.lblmonthly.Name = "lblmonthly";
            this.lblmonthly.Size = new System.Drawing.Size(93, 20);
            this.lblmonthly.TabIndex = 414;
            this.lblmonthly.Text = "MONTHLY";
            // 
            // lblfine
            // 
            this.lblfine.AutoSize = true;
            this.lblfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfine.Location = new System.Drawing.Point(414, 181);
            this.lblfine.Name = "lblfine";
            this.lblfine.Size = new System.Drawing.Size(50, 20);
            this.lblfine.TabIndex = 415;
            this.lblfine.Text = "FINE";
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetails.Location = new System.Drawing.Point(414, 239);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(84, 20);
            this.lbldetails.TabIndex = 416;
            this.lbldetails.Text = "DETAILS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 417;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldetails);
            this.Controls.Add(this.lblfine);
            this.Controls.Add(this.lblmonthly);
            this.Controls.Add(this.lbldaterecieved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtmonthly);
            this.Controls.Add(this.txtfine);
            this.Controls.Add(this.txtdetails);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.Text = "Student Fee";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdetails;
        private System.Windows.Forms.TextBox txtfine;
        private System.Windows.Forms.TextBox txtmonthly;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldaterecieved;
        private System.Windows.Forms.Label lblmonthly;
        private System.Windows.Forms.Label lblfine;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
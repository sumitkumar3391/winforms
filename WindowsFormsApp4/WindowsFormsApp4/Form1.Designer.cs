namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.txtname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.txtposition = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtupdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(139, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(302, 20);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(139, 76);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(302, 20);
            this.txtemail.TabIndex = 2;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(139, 173);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(302, 20);
            this.txtnumber.TabIndex = 4;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Number";
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert.Location = new System.Drawing.Point(3, 217);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(139, 55);
            this.insert.TabIndex = 9;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // txtposition
            // 
            this.txtposition.FormattingEnabled = true;
            this.txtposition.Items.AddRange(new object[] {
            "Tester ",
            "Software developer",
            "Database",
            ""});
            this.txtposition.Location = new System.Drawing.Point(139, 127);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(302, 21);
            this.txtposition.TabIndex = 10;
            this.txtposition.SelectedIndexChanged += new System.EventHandler(this.txtposition_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 188);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1.Location = new System.Drawing.Point(186, 297);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(139, 62);
            this.data1.TabIndex = 12;
            this.data1.Text = "Search Name ";
            this.data1.UseVisualStyleBackColor = false;
            this.data1.Click += new System.EventHandler(this.data1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(4, 339);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(128, 20);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Entries";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(3, 418);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(129, 20);
            this.txtupdate.TabIndex = 15;
            this.txtupdate.TextChanged += new System.EventHandler(this.txtupdate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter Name for Search";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(-1, 380);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(190, 23);
            this.number.TabIndex = 17;
            this.number.Text = "Enter Number to update";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ComboBox txtposition;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button data1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button button2;
    }
}


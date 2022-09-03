
namespace Pharmacy_Management_System
{
    partial class PMS_AddUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.typecategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typegender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typedob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typecontact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.typeusername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.typepassword = new System.Windows.Forms.TextBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category :";
            // 
            // typecategory
            // 
            this.typecategory.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecategory.FormattingEnabled = true;
            this.typecategory.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer"});
            this.typecategory.Location = new System.Drawing.Point(341, 101);
            this.typecategory.Name = "typecategory";
            this.typecategory.Size = new System.Drawing.Size(188, 30);
            this.typecategory.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name :";
            // 
            // typename
            // 
            this.typename.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typename.Location = new System.Drawing.Point(341, 154);
            this.typename.Name = "typename";
            this.typename.Size = new System.Drawing.Size(188, 33);
            this.typename.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender :";
            // 
            // typegender
            // 
            this.typegender.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typegender.FormattingEnabled = true;
            this.typegender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.typegender.Location = new System.Drawing.Point(341, 209);
            this.typegender.Name = "typegender";
            this.typegender.Size = new System.Drawing.Size(188, 30);
            this.typegender.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "DOB :";
            // 
            // typedob
            // 
            this.typedob.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typedob.Location = new System.Drawing.Point(341, 264);
            this.typedob.Name = "typedob";
            this.typedob.Size = new System.Drawing.Size(188, 33);
            this.typedob.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Contact :";
            // 
            // typecontact
            // 
            this.typecontact.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecontact.Location = new System.Drawing.Point(341, 318);
            this.typecontact.Name = "typecontact";
            this.typecontact.Size = new System.Drawing.Size(188, 33);
            this.typecontact.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Username :";
            // 
            // typeusername
            // 
            this.typeusername.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeusername.Location = new System.Drawing.Point(341, 379);
            this.typeusername.Name = "typeusername";
            this.typeusername.Size = new System.Drawing.Size(188, 33);
            this.typeusername.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password :";
            // 
            // typepassword
            // 
            this.typepassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typepassword.Location = new System.Drawing.Point(341, 436);
            this.typepassword.Name = "typepassword";
            this.typepassword.Size = new System.Drawing.Size(188, 33);
            this.typepassword.TabIndex = 25;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.Yellow;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.Location = new System.Drawing.Point(321, 511);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(121, 48);
            this.btnsignup.TabIndex = 26;
            this.btnsignup.Text = "Sign up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnreset.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(475, 511);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(121, 48);
            this.btnreset.TabIndex = 27;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // PMS_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(758, 604);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.typepassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.typeusername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.typecontact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typedob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typegender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typecategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PMS_AddUser";
            this.Text = "PMS_AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typecategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typegender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typedob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox typecontact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeusername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox typepassword;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnreset;
    }
}
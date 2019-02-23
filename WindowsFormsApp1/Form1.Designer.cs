namespace WindowsFormsApp1
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
            this.recipiant = new System.Windows.Forms.TextBox();
            this.myEmailAddress = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAttachement = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.attachement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // recipiant
            // 
            this.recipiant.Location = new System.Drawing.Point(213, 27);
            this.recipiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipiant.Name = "recipiant";
            this.recipiant.Size = new System.Drawing.Size(218, 26);
            this.recipiant.TabIndex = 0;
            // 
            // myEmailAddress
            // 
            this.myEmailAddress.Location = new System.Drawing.Point(213, 347);
            this.myEmailAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myEmailAddress.Name = "myEmailAddress";
            this.myEmailAddress.Size = new System.Drawing.Size(218, 26);
            this.myEmailAddress.TabIndex = 1;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(27, 175);
            this.body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(404, 127);
            this.body.TabIndex = 2;
            this.body.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(213, 85);
            this.subject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(218, 26);
            this.subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subject";
            // 
            // myPassword
            // 
            this.myPassword.Location = new System.Drawing.Point(213, 399);
            this.myPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myPassword.Name = "myPassword";
            this.myPassword.Size = new System.Drawing.Size(218, 26);
            this.myPassword.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // btnAttachement
            // 
            this.btnAttachement.Location = new System.Drawing.Point(27, 463);
            this.btnAttachement.Name = "btnAttachement";
            this.btnAttachement.Size = new System.Drawing.Size(120, 36);
            this.btnAttachement.TabIndex = 12;
            this.btnAttachement.Text = "Attachement";
            this.btnAttachement.UseVisualStyleBackColor = true;
            this.btnAttachement.Click += new System.EventHandler(this.btnAttachement_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(311, 463);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 36);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // attachement
            // 
            this.attachement.Location = new System.Drawing.Point(222, 131);
            this.attachement.Name = "attachement";
            this.attachement.Size = new System.Drawing.Size(100, 26);
            this.attachement.TabIndex = 14;
            this.attachement.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 524);
            this.Controls.Add(this.attachement);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAttachement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.myPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.body);
            this.Controls.Add(this.myEmailAddress);
            this.Controls.Add(this.recipiant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recipiant;
        private System.Windows.Forms.TextBox myEmailAddress;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox myPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAttachement;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox attachement;
    }
}


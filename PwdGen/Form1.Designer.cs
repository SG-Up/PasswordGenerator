namespace PwdGen
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassLength = new System.Windows.Forms.Label();
            this.txtPassLength = new System.Windows.Forms.TextBox();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnCopy = new System.Windows.Forms.Button();
            this.chkSpChar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Green;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 139);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(92, 135);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(284, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.TabStop = false;
            // 
            // lblPassLength
            // 
            this.lblPassLength.AutoSize = true;
            this.lblPassLength.BackColor = System.Drawing.Color.Green;
            this.lblPassLength.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassLength.ForeColor = System.Drawing.Color.White;
            this.lblPassLength.Location = new System.Drawing.Point(12, 9);
            this.lblPassLength.Name = "lblPassLength";
            this.lblPassLength.Size = new System.Drawing.Size(121, 16);
            this.lblPassLength.TabIndex = 2;
            this.lblPassLength.Text = "Password Length:";
            // 
            // txtPassLength
            // 
            this.txtPassLength.Location = new System.Drawing.Point(139, 5);
            this.txtPassLength.Name = "txtPassLength";
            this.txtPassLength.Size = new System.Drawing.Size(28, 20);
            this.txtPassLength.TabIndex = 3;
            this.txtPassLength.TextChanged += new System.EventHandler(this.txtPassLength_TextChanged);
            this.txtPassLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassLength_KeyDown);
            this.txtPassLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassLength_KeyPress);
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.Location = new System.Drawing.Point(92, 171);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(75, 23);
            this.bttnGenerate.TabIndex = 4;
            this.bttnGenerate.Text = "Generate";
            this.bttnGenerate.UseVisualStyleBackColor = true;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(301, 171);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 5;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnCopy
            // 
            this.bttnCopy.Location = new System.Drawing.Point(197, 171);
            this.bttnCopy.Name = "bttnCopy";
            this.bttnCopy.Size = new System.Drawing.Size(75, 23);
            this.bttnCopy.TabIndex = 6;
            this.bttnCopy.Text = "Copy";
            this.bttnCopy.UseVisualStyleBackColor = true;
            this.bttnCopy.Click += new System.EventHandler(this.bttnCopy_Click);
            // 
            // chkSpChar
            // 
            this.chkSpChar.AutoSize = true;
            this.chkSpChar.Location = new System.Drawing.Point(150, 46);
            this.chkSpChar.Name = "chkSpChar";
            this.chkSpChar.Size = new System.Drawing.Size(15, 14);
            this.chkSpChar.TabIndex = 7;
            this.chkSpChar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Special Characters:";
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.BackColor = System.Drawing.Color.Green;
            this.chkMusic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusic.ForeColor = System.Drawing.Color.White;
            this.chkMusic.Location = new System.Drawing.Point(313, 5);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMusic.Size = new System.Drawing.Size(58, 20);
            this.chkMusic.TabIndex = 9;
            this.chkMusic.Text = "Mute";
            this.chkMusic.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkMusic.UseVisualStyleBackColor = false;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "#SG";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSpChar);
            this.Controls.Add(this.bttnCopy);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.txtPassLength);
            this.Controls.Add(this.lblPassLength);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassLength;
        private System.Windows.Forms.TextBox txtPassLength;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnCopy;
        private System.Windows.Forms.CheckBox chkSpChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Label label2;
    }
}


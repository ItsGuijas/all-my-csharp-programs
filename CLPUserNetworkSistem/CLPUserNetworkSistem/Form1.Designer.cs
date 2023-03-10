namespace CLPUserNetworkSistem
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.b_ShowPassW = new System.Windows.Forms.CheckBox();
            this.a_Login = new System.Windows.Forms.TextBox();
            this.a_Pass = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.b_erase = new System.Windows.Forms.Button();
            this.labelInfoCreateAcc = new System.Windows.Forms.Label();
            this.labelCreateAcc = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TitleRightPag = new System.Windows.Forms.PictureBox();
            this.IMGLeftPag = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleRightPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLeftPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.SystemColors.Control;
            this.labelUser.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(309, 140);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(62, 18);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Usuário:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.SystemColors.Control;
            this.labelPass.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.Black;
            this.labelPass.Location = new System.Drawing.Point(309, 181);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(49, 18);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Senha:";
            this.labelPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // b_ShowPassW
            // 
            this.b_ShowPassW.AutoSize = true;
            this.b_ShowPassW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_ShowPassW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ShowPassW.Location = new System.Drawing.Point(516, 186);
            this.b_ShowPassW.Name = "b_ShowPassW";
            this.b_ShowPassW.Size = new System.Drawing.Size(107, 19);
            this.b_ShowPassW.TabIndex = 7;
            this.b_ShowPassW.Text = "Exibir a senha.";
            this.b_ShowPassW.UseVisualStyleBackColor = true;
            this.b_ShowPassW.CheckedChanged += new System.EventHandler(this.b_ShowPassW_CheckedChanged);
            // 
            // a_Login
            // 
            this.a_Login.BackColor = System.Drawing.SystemColors.Window;
            this.a_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.a_Login.Location = new System.Drawing.Point(380, 138);
            this.a_Login.Name = "a_Login";
            this.a_Login.Size = new System.Drawing.Size(130, 19);
            this.a_Login.TabIndex = 10;
            // 
            // a_Pass
            // 
            this.a_Pass.BackColor = System.Drawing.SystemColors.Window;
            this.a_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.a_Pass.Location = new System.Drawing.Point(380, 181);
            this.a_Pass.Name = "a_Pass";
            this.a_Pass.Size = new System.Drawing.Size(130, 19);
            this.a_Pass.TabIndex = 11;
            this.a_Pass.UseSystemPasswordChar = true;
            this.a_Pass.TextChanged += new System.EventHandler(this.a_Pass_TextChanged);
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.b_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.Color.White;
            this.b_login.Location = new System.Drawing.Point(380, 232);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(130, 28);
            this.b_login.TabIndex = 12;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_erase
            // 
            this.b_erase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.b_erase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_erase.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_erase.ForeColor = System.Drawing.Color.White;
            this.b_erase.Location = new System.Drawing.Point(380, 280);
            this.b_erase.Name = "b_erase";
            this.b_erase.Size = new System.Drawing.Size(130, 28);
            this.b_erase.TabIndex = 13;
            this.b_erase.Text = "Apagar";
            this.b_erase.UseVisualStyleBackColor = false;
            // 
            // labelInfoCreateAcc
            // 
            this.labelInfoCreateAcc.AutoSize = true;
            this.labelInfoCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInfoCreateAcc.Location = new System.Drawing.Point(286, 406);
            this.labelInfoCreateAcc.Name = "labelInfoCreateAcc";
            this.labelInfoCreateAcc.Size = new System.Drawing.Size(124, 13);
            this.labelInfoCreateAcc.TabIndex = 14;
            this.labelInfoCreateAcc.Text = "Não tem uma conta?";
            this.labelInfoCreateAcc.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCreateAcc
            // 
            this.labelCreateAcc.AutoSize = true;
            this.labelCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.labelCreateAcc.Location = new System.Drawing.Point(407, 406);
            this.labelCreateAcc.Name = "labelCreateAcc";
            this.labelCreateAcc.Size = new System.Drawing.Size(60, 13);
            this.labelCreateAcc.TabIndex = 15;
            this.labelCreateAcc.Text = "Crie uma.";
            this.labelCreateAcc.Click += new System.EventHandler(this.labelCreateAcc_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::CLPUserNetworkSistem.Properties.Resources.bottonminimizer;
            this.pictureBox7.Location = new System.Drawing.Point(603, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::CLPUserNetworkSistem.Properties.Resources.icon_password2;
            this.pictureBox6.Location = new System.Drawing.Point(289, 180);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CLPUserNetworkSistem.Properties.Resources.icon_Login2;
            this.pictureBox3.Location = new System.Drawing.Point(289, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CLPUserNetworkSistem.Properties.Resources.closeWindows1;
            this.pictureBox2.Location = new System.Drawing.Point(628, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::CLPUserNetworkSistem.Properties.Resources.linha3;
            this.pictureBox5.Location = new System.Drawing.Point(380, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 10);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::CLPUserNetworkSistem.Properties.Resources.linha2;
            this.pictureBox4.Location = new System.Drawing.Point(380, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // TitleRightPag
            // 
            this.TitleRightPag.BackColor = System.Drawing.Color.Transparent;
            this.TitleRightPag.Image = global::CLPUserNetworkSistem.Properties.Resources.clpcontrollername;
            this.TitleRightPag.Location = new System.Drawing.Point(384, 10);
            this.TitleRightPag.Name = "TitleRightPag";
            this.TitleRightPag.Size = new System.Drawing.Size(169, 31);
            this.TitleRightPag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleRightPag.TabIndex = 2;
            this.TitleRightPag.TabStop = false;
            // 
            // IMGLeftPag
            // 
            this.IMGLeftPag.Image = global::CLPUserNetworkSistem.Properties.Resources.LogoSenai1;
            this.IMGLeftPag.Location = new System.Drawing.Point(12, 12);
            this.IMGLeftPag.Name = "IMGLeftPag";
            this.IMGLeftPag.Size = new System.Drawing.Size(93, 29);
            this.IMGLeftPag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGLeftPag.TabIndex = 1;
            this.IMGLeftPag.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLPUserNetworkSistem.Properties.Resources.LadoLogin;
            this.pictureBox1.Location = new System.Drawing.Point(-275, -59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 799);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 437);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCreateAcc);
            this.Controls.Add(this.labelInfoCreateAcc);
            this.Controls.Add(this.b_erase);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.a_Pass);
            this.Controls.Add(this.a_Login);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.b_ShowPassW);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.TitleRightPag);
            this.Controls.Add(this.IMGLeftPag);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLPUserSystemNetWork";
            this.Load += new System.EventHandler(this.CLPUserSystemNetWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleRightPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGLeftPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox IMGLeftPag;
        private System.Windows.Forms.PictureBox TitleRightPag;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.CheckBox b_ShowPassW;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox a_Login;
        private System.Windows.Forms.TextBox a_Pass;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_erase;
        private System.Windows.Forms.Label labelInfoCreateAcc;
        private System.Windows.Forms.Label labelCreateAcc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}


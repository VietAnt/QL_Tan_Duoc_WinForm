namespace WindowsFormsApp1
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Createbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btlReset = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_passWord = new System.Windows.Forms.TextBox();
            this.btn_create = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.istockphoto_520553092_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(174, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đăng Ký Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(209, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(209, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // Createbtn
            // 
            this.Createbtn.ActiveBorderThickness = 1;
            this.Createbtn.ActiveCornerRadius = 20;
            this.Createbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Createbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Createbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Createbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Createbtn.BackgroundImage")));
            this.Createbtn.ButtonText = "Đăng Ký";
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Createbtn.IdleBorderThickness = 1;
            this.Createbtn.IdleCornerRadius = 20;
            this.Createbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Createbtn.IdleForecolor = System.Drawing.Color.Black;
            this.Createbtn.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.Createbtn.Location = new System.Drawing.Point(168, 313);
            this.Createbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(188, 41);
            this.Createbtn.TabIndex = 16;
            this.Createbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // btlReset
            // 
            this.btlReset.AutoSize = true;
            this.btlReset.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlReset.ForeColor = System.Drawing.Color.Black;
            this.btlReset.Location = new System.Drawing.Point(235, 386);
            this.btlReset.Name = "btlReset";
            this.btlReset.Size = new System.Drawing.Size(59, 26);
            this.btlReset.TabIndex = 17;
            this.btlReset.Text = "Reset";
            // 
            // tb_userName
            // 
            this.tb_userName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userName.Location = new System.Drawing.Point(143, 188);
            this.tb_userName.Multiline = true;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(257, 32);
            this.tb_userName.TabIndex = 18;
            // 
            // tb_passWord
            // 
            this.tb_passWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passWord.Location = new System.Drawing.Point(143, 261);
            this.tb_passWord.Multiline = true;
            this.tb_passWord.Name = "tb_passWord";
            this.tb_passWord.Size = new System.Drawing.Size(257, 29);
            this.tb_passWord.TabIndex = 19;
            // 
            // btn_create
            // 
            this.btn_create.ActiveBorderThickness = 1;
            this.btn_create.ActiveCornerRadius = 20;
            this.btn_create.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_create.ActiveForecolor = System.Drawing.Color.White;
            this.btn_create.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_create.BackgroundImage")));
            this.btn_create.ButtonText = "Đăng Nhập";
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_create.IdleBorderThickness = 1;
            this.btn_create.IdleCornerRadius = 20;
            this.btn_create.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_create.IdleForecolor = System.Drawing.Color.Black;
            this.btn_create.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.btn_create.Location = new System.Drawing.Point(30, 371);
            this.btn_create.Margin = new System.Windows.Forms.Padding(5);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(109, 41);
            this.btn_create.TabIndex = 20;
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_passWord);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.btlReset);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 Createbtn;
        private System.Windows.Forms.Label btlReset;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_passWord;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_create;
    }
}
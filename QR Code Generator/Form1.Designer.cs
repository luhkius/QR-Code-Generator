namespace QR_Code_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_save = new QR_Code_Generator.PictureButton();
            this.btn_text = new QR_Code_Generator.PictureButton();
            this.btn_email = new QR_Code_Generator.PictureButton();
            this.btn_web = new QR_Code_Generator.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(16, 63);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(615, 372);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pictureBox1.Location = new System.Drawing.Point(640, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Feedback";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_save.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_save_80px;
            this.btn_save.Location = new System.Drawing.Point(640, 389);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(387, 47);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text_ = "Save";
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_text.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_text_32px;
            this.btn_text.Location = new System.Drawing.Point(432, 15);
            this.btn_text.Margin = new System.Windows.Forms.Padding(5);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(200, 41);
            this.btn_text.TabIndex = 4;
            this.btn_text.Text_ = "Text";
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_email.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_secured_letter_50px;
            this.btn_email.Location = new System.Drawing.Point(224, 15);
            this.btn_email.Margin = new System.Windows.Forms.Padding(5);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(200, 41);
            this.btn_email.TabIndex = 3;
            this.btn_email.Text_ = "Email";
            // 
            // btn_web
            // 
            this.btn_web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_web.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_website_80px;
            this.btn_web.Location = new System.Drawing.Point(16, 15);
            this.btn_web.Margin = new System.Windows.Forms.Padding(5);
            this.btn_web.Name = "btn_web";
            this.btn_web.Size = new System.Drawing.Size(200, 41);
            this.btn_web.TabIndex = 2;
            this.btn_web.Text_ = "Website";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_web);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Code Genorator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private PictureButton btn_web;
        private PictureButton btn_email;
        private PictureButton btn_text;
        private PictureButton btn_save;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


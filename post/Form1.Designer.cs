
namespace post
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.startpost = new MaterialSkin.Controls.MaterialButton();
            this.stoppost = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passtext = new MaterialSkin.Controls.MaterialTextBox();
            this.gmailtext = new MaterialSkin.Controls.MaterialTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linktext = new MaterialSkin.Controls.MaterialTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teamnametext = new MaterialSkin.Controls.MaterialTextBox();
            this.stopnumbertext = new MaterialSkin.Controls.MaterialTextBox();
            this.startnumbertext = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startpost
            // 
            this.startpost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startpost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startpost.Depth = 0;
            this.startpost.HighEmphasis = true;
            this.startpost.Icon = null;
            this.startpost.Location = new System.Drawing.Point(209, 42);
            this.startpost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startpost.MouseState = MaterialSkin.MouseState.HOVER;
            this.startpost.Name = "startpost";
            this.startpost.Size = new System.Drawing.Size(132, 36);
            this.startpost.TabIndex = 3;
            this.startpost.Text = "START POSTING";
            this.startpost.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startpost.UseAccentColor = false;
            this.startpost.UseVisualStyleBackColor = true;
            this.startpost.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // stoppost
            // 
            this.stoppost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stoppost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stoppost.Depth = 0;
            this.stoppost.HighEmphasis = true;
            this.stoppost.Icon = null;
            this.stoppost.Location = new System.Drawing.Point(209, 86);
            this.stoppost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stoppost.MouseState = MaterialSkin.MouseState.HOVER;
            this.stoppost.Name = "stoppost";
            this.stoppost.Size = new System.Drawing.Size(131, 36);
            this.stoppost.TabIndex = 3;
            this.stoppost.Text = "STOP   POSTING ";
            this.stoppost.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stoppost.UseAccentColor = false;
            this.stoppost.UseVisualStyleBackColor = true;
            this.stoppost.Click += new System.EventHandler(this.stoppost_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(306, 64);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(138, 36);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "authtenticate";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passtext);
            this.groupBox1.Controls.Add(this.gmailtext);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Location = new System.Drawing.Point(10, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login informations";
            // 
            // passtext
            // 
            this.passtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtext.Depth = 0;
            this.passtext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passtext.Hint = "password *";
            this.passtext.LeadingIcon = null;
            this.passtext.Location = new System.Drawing.Point(21, 86);
            this.passtext.MaxLength = 50;
            this.passtext.MouseState = MaterialSkin.MouseState.OUT;
            this.passtext.Multiline = false;
            this.passtext.Name = "passtext";
            this.passtext.Password = true;
            this.passtext.Size = new System.Drawing.Size(278, 50);
            this.passtext.TabIndex = 9;
            this.passtext.Text = "";
            this.passtext.TrailingIcon = null;
            // 
            // gmailtext
            // 
            this.gmailtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmailtext.Depth = 0;
            this.gmailtext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gmailtext.Hint = "@gmail.com *";
            this.gmailtext.LeadingIcon = null;
            this.gmailtext.Location = new System.Drawing.Point(21, 30);
            this.gmailtext.MaxLength = 50;
            this.gmailtext.MouseState = MaterialSkin.MouseState.OUT;
            this.gmailtext.Multiline = false;
            this.gmailtext.Name = "gmailtext";
            this.gmailtext.Size = new System.Drawing.Size(278, 50);
            this.gmailtext.TabIndex = 8;
            this.gmailtext.Text = "";
            this.gmailtext.TrailingIcon = null;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // linktext
            // 
            this.linktext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linktext.Depth = 0;
            this.linktext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.linktext.Hint = "Link text *";
            this.linktext.LeadingIcon = null;
            this.linktext.Location = new System.Drawing.Point(17, 88);
            this.linktext.MaxLength = 50;
            this.linktext.MouseState = MaterialSkin.MouseState.OUT;
            this.linktext.Multiline = false;
            this.linktext.Name = "linktext";
            this.linktext.Size = new System.Drawing.Size(168, 50);
            this.linktext.TabIndex = 10;
            this.linktext.Text = "";
            this.linktext.TrailingIcon = null;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(553, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teamnametext);
            this.groupBox2.Controls.Add(this.linktext);
            this.groupBox2.Controls.Add(this.stopnumbertext);
            this.groupBox2.Controls.Add(this.stoppost);
            this.groupBox2.Controls.Add(this.startnumbertext);
            this.groupBox2.Controls.Add(this.startpost);
            this.groupBox2.Location = new System.Drawing.Point(10, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 200);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // teamnametext
            // 
            this.teamnametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamnametext.Depth = 0;
            this.teamnametext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.teamnametext.Hint = "Team name *";
            this.teamnametext.LeadingIcon = null;
            this.teamnametext.Location = new System.Drawing.Point(17, 30);
            this.teamnametext.MaxLength = 50;
            this.teamnametext.MouseState = MaterialSkin.MouseState.OUT;
            this.teamnametext.Multiline = false;
            this.teamnametext.Name = "teamnametext";
            this.teamnametext.Size = new System.Drawing.Size(168, 50);
            this.teamnametext.TabIndex = 12;
            this.teamnametext.Text = "";
            this.teamnametext.TrailingIcon = null;
            // 
            // stopnumbertext
            // 
            this.stopnumbertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stopnumbertext.Depth = 0;
            this.stopnumbertext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stopnumbertext.Hint = "Stop post number *";
            this.stopnumbertext.LeadingIcon = null;
            this.stopnumbertext.Location = new System.Drawing.Point(191, 144);
            this.stopnumbertext.MaxLength = 50;
            this.stopnumbertext.MouseState = MaterialSkin.MouseState.OUT;
            this.stopnumbertext.Multiline = false;
            this.stopnumbertext.Name = "stopnumbertext";
            this.stopnumbertext.Size = new System.Drawing.Size(168, 50);
            this.stopnumbertext.TabIndex = 11;
            this.stopnumbertext.Text = "";
            this.stopnumbertext.TrailingIcon = null;
            // 
            // startnumbertext
            // 
            this.startnumbertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startnumbertext.Depth = 0;
            this.startnumbertext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.startnumbertext.Hint = "Start post number *";
            this.startnumbertext.LeadingIcon = null;
            this.startnumbertext.Location = new System.Drawing.Point(17, 144);
            this.startnumbertext.MaxLength = 50;
            this.startnumbertext.MouseState = MaterialSkin.MouseState.OUT;
            this.startnumbertext.Multiline = false;
            this.startnumbertext.Name = "startnumbertext";
            this.startnumbertext.Size = new System.Drawing.Size(168, 50);
            this.startnumbertext.TabIndex = 10;
            this.startnumbertext.Text = "";
            this.startnumbertext.TrailingIcon = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "autoposter by baris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton startpost;
        private MaterialSkin.Controls.MaterialButton stoppost;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTextBox passtext;
        private MaterialSkin.Controls.MaterialTextBox gmailtext;
        private MaterialSkin.Controls.MaterialTextBox linktext;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox teamnametext;
        private MaterialSkin.Controls.MaterialTextBox stopnumbertext;
        private MaterialSkin.Controls.MaterialTextBox startnumbertext;
    }
}


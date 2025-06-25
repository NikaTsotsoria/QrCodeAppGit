namespace QrCodeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateQrCodeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.txtEnterQrCodeLinkTextBox = new System.Windows.Forms.TextBox();
            this.CustomizeButton = new System.Windows.Forms.Button();
            this.LoadQrCodeButton = new System.Windows.Forms.Button();
            this.ShortenerUrlButton = new System.Windows.Forms.Button();
            this.WaterMarkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR CODE GENERATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "LINK";
            // 
            // GenerateQrCodeButton
            // 
            this.GenerateQrCodeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GenerateQrCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GenerateQrCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateQrCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateQrCodeButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateQrCodeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerateQrCodeButton.Location = new System.Drawing.Point(487, 148);
            this.GenerateQrCodeButton.Name = "GenerateQrCodeButton";
            this.GenerateQrCodeButton.Size = new System.Drawing.Size(138, 73);
            this.GenerateQrCodeButton.TabIndex = 3;
            this.GenerateQrCodeButton.Text = "Generate QR Code";
            this.GenerateQrCodeButton.UseVisualStyleBackColor = false;
            this.GenerateQrCodeButton.Click += new System.EventHandler(this.GenerateQrCodeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveButton.Location = new System.Drawing.Point(487, 227);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 68);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResetButton.Location = new System.Drawing.Point(487, 301);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(138, 75);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(641, 227);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(138, 68);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // txtEnterQrCodeLinkTextBox
            // 
            this.txtEnterQrCodeLinkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterQrCodeLinkTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterQrCodeLinkTextBox.Location = new System.Drawing.Point(3, 82);
            this.txtEnterQrCodeLinkTextBox.Multiline = true;
            this.txtEnterQrCodeLinkTextBox.Name = "txtEnterQrCodeLinkTextBox";
            this.txtEnterQrCodeLinkTextBox.Size = new System.Drawing.Size(464, 41);
            this.txtEnterQrCodeLinkTextBox.TabIndex = 7;
            this.txtEnterQrCodeLinkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomizeButton
            // 
            this.CustomizeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustomizeButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomizeButton.Location = new System.Drawing.Point(641, 382);
            this.CustomizeButton.Name = "CustomizeButton";
            this.CustomizeButton.Size = new System.Drawing.Size(138, 73);
            this.CustomizeButton.TabIndex = 8;
            this.CustomizeButton.Text = "Customize QR code";
            this.CustomizeButton.UseVisualStyleBackColor = false;
            this.CustomizeButton.Click += new System.EventHandler(this.CustomizeButton_Click);
            // 
            // LoadQrCodeButton
            // 
            this.LoadQrCodeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadQrCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadQrCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadQrCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadQrCodeButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadQrCodeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoadQrCodeButton.Location = new System.Drawing.Point(487, 382);
            this.LoadQrCodeButton.Name = "LoadQrCodeButton";
            this.LoadQrCodeButton.Size = new System.Drawing.Size(138, 73);
            this.LoadQrCodeButton.TabIndex = 9;
            this.LoadQrCodeButton.Text = "Load QR Code ";
            this.LoadQrCodeButton.UseVisualStyleBackColor = false;
            this.LoadQrCodeButton.Click += new System.EventHandler(this.LoadQrCodeButton_Click);
            // 
            // ShortenerUrlButton
            // 
            this.ShortenerUrlButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShortenerUrlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShortenerUrlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShortenerUrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShortenerUrlButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortenerUrlButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShortenerUrlButton.Location = new System.Drawing.Point(641, 148);
            this.ShortenerUrlButton.Name = "ShortenerUrlButton";
            this.ShortenerUrlButton.Size = new System.Drawing.Size(138, 71);
            this.ShortenerUrlButton.TabIndex = 10;
            this.ShortenerUrlButton.Text = "Shortener URL";
            this.ShortenerUrlButton.UseVisualStyleBackColor = false;
            this.ShortenerUrlButton.Click += new System.EventHandler(this.ShortenerUrlButton_Click);
            // 
            // WaterMarkButton
            // 
            this.WaterMarkButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.WaterMarkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WaterMarkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaterMarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WaterMarkButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterMarkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WaterMarkButton.Location = new System.Drawing.Point(641, 301);
            this.WaterMarkButton.Name = "WaterMarkButton";
            this.WaterMarkButton.Size = new System.Drawing.Size(138, 75);
            this.WaterMarkButton.TabIndex = 11;
            this.WaterMarkButton.Text = "Add WaterMark";
            this.WaterMarkButton.UseVisualStyleBackColor = false;
            this.WaterMarkButton.Click += new System.EventHandler(this.WaterMarkButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(473, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 533);
            this.panel1.TabIndex = 12;
            // 
            // picQrCode
            // 
            this.picQrCode.Location = new System.Drawing.Point(3, 129);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(464, 334);
            this.picQrCode.TabIndex = 2;
            this.picQrCode.TabStop = false;
            this.picQrCode.Click += new System.EventHandler(this.picQrCode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(796, 467);
            this.Controls.Add(this.GenerateQrCodeButton);
            this.Controls.Add(this.WaterMarkButton);
            this.Controls.Add(this.ShortenerUrlButton);
            this.Controls.Add(this.LoadQrCodeButton);
            this.Controls.Add(this.CustomizeButton);
            this.Controls.Add(this.txtEnterQrCodeLinkTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.picQrCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateQrCodeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox txtEnterQrCodeLinkTextBox;
        private System.Windows.Forms.Button CustomizeButton;
        private System.Windows.Forms.Button LoadQrCodeButton;
        private System.Windows.Forms.Button ShortenerUrlButton;
        private System.Windows.Forms.Button WaterMarkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


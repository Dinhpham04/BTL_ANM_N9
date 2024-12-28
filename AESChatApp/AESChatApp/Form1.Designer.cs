namespace AESChatApp
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxCiphertextClient = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxPlaintextClient = new System.Windows.Forms.TextBox();
            this.btnEncriptionClient = new System.Windows.Forms.Button();
            this.btnDecriptionClient = new System.Windows.Forms.Button();
            this.btnEncriptServer = new System.Windows.Forms.Button();
            this.btnDecryptionServer = new System.Windows.Forms.Button();
            this.textBoxEncriptServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(935, 48);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(205, 26);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập địa chỉ người nhận: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1184, 48);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.ItemHeight = 20;
            this.listBoxMessages.Location = new System.Drawing.Point(720, 90);
            this.listBoxMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(547, 324);
            this.listBoxMessages.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(720, 462);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(437, 26);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1184, 461);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập tin nhắn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1332, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxCiphertextClient
            // 
            this.textBoxCiphertextClient.Location = new System.Drawing.Point(52, 248);
            this.textBoxCiphertextClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCiphertextClient.Multiline = true;
            this.textBoxCiphertextClient.Name = "textBoxCiphertextClient";
            this.textBoxCiphertextClient.Size = new System.Drawing.Size(543, 166);
            this.textBoxCiphertextClient.TabIndex = 0;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(52, 90);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(543, 95);
            this.textBoxKey.TabIndex = 1;
            // 
            // textBoxPlaintextClient
            // 
            this.textBoxPlaintextClient.Location = new System.Drawing.Point(52, 598);
            this.textBoxPlaintextClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlaintextClient.Multiline = true;
            this.textBoxPlaintextClient.Name = "textBoxPlaintextClient";
            this.textBoxPlaintextClient.Size = new System.Drawing.Size(543, 170);
            this.textBoxPlaintextClient.TabIndex = 2;
            // 
            // btnEncriptionClient
            // 
            this.btnEncriptionClient.Location = new System.Drawing.Point(156, 476);
            this.btnEncriptionClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncriptionClient.Name = "btnEncriptionClient";
            this.btnEncriptionClient.Size = new System.Drawing.Size(106, 58);
            this.btnEncriptionClient.TabIndex = 11;
            this.btnEncriptionClient.Text = "Mã hóa";
            this.btnEncriptionClient.UseVisualStyleBackColor = true;
            this.btnEncriptionClient.Click += new System.EventHandler(this.btnEncriptionClient_Click);
            // 
            // btnDecriptionClient
            // 
            this.btnDecriptionClient.Location = new System.Drawing.Point(357, 476);
            this.btnDecriptionClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecriptionClient.Name = "btnDecriptionClient";
            this.btnDecriptionClient.Size = new System.Drawing.Size(108, 58);
            this.btnDecriptionClient.TabIndex = 12;
            this.btnDecriptionClient.Text = "Giải mã";
            this.btnDecriptionClient.UseVisualStyleBackColor = true;
            this.btnDecriptionClient.Click += new System.EventHandler(this.btnDecriptionClient_Click);
            // 
            // btnEncriptServer
            // 
            this.btnEncriptServer.Location = new System.Drawing.Point(958, 522);
            this.btnEncriptServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncriptServer.Name = "btnEncriptServer";
            this.btnEncriptServer.Size = new System.Drawing.Size(84, 41);
            this.btnEncriptServer.TabIndex = 13;
            this.btnEncriptServer.Text = "Mã hóa";
            this.btnEncriptServer.UseVisualStyleBackColor = true;
            this.btnEncriptServer.Click += new System.EventHandler(this.btnEncriptServer_Click);
            // 
            // btnDecryptionServer
            // 
            this.btnDecryptionServer.Location = new System.Drawing.Point(618, 659);
            this.btnDecryptionServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecryptionServer.Name = "btnDecryptionServer";
            this.btnDecryptionServer.Size = new System.Drawing.Size(84, 44);
            this.btnDecryptionServer.TabIndex = 14;
            this.btnDecryptionServer.Text = "Giải mã";
            this.btnDecryptionServer.UseVisualStyleBackColor = true;
            this.btnDecryptionServer.Click += new System.EventHandler(this.btnDecryptionServer_Click);
            // 
            // textBoxEncriptServer
            // 
            this.textBoxEncriptServer.Location = new System.Drawing.Point(720, 598);
            this.textBoxEncriptServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEncriptServer.Multiline = true;
            this.textBoxEncriptServer.Name = "textBoxEncriptServer";
            this.textBoxEncriptServer.Size = new System.Drawing.Size(547, 170);
            this.textBoxEncriptServer.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bản mã";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bản rõ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bản mã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1332, 812);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEncriptServer);
            this.Controls.Add(this.btnDecryptionServer);
            this.Controls.Add(this.btnEncriptServer);
            this.Controls.Add(this.btnDecriptionClient);
            this.Controls.Add(this.btnEncriptionClient);
            this.Controls.Add(this.textBoxPlaintextClient);
            this.Controls.Add(this.textBoxCiphertextClient);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "AES Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxCiphertextClient;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxPlaintextClient;
        private System.Windows.Forms.Button btnEncriptionClient;
        private System.Windows.Forms.Button btnDecriptionClient;
        private System.Windows.Forms.Button btnEncriptServer;
        private System.Windows.Forms.Button btnDecryptionServer;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.TextBox textBoxEncriptServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


namespace RabbitMQ.Publisher
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
            this.txt_MessageToSend = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_MessageToSend
            // 
            this.txt_MessageToSend.Location = new System.Drawing.Point(38, 26);
            this.txt_MessageToSend.Name = "txt_MessageToSend";
            this.txt_MessageToSend.Size = new System.Drawing.Size(242, 20);
            this.txt_MessageToSend.TabIndex = 0;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(62, 62);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(167, 23);
            this.btn_SendMessage.TabIndex = 1;
            this.btn_SendMessage.Text = "Send Message to Subscribers";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.BtnSendMessageClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send Message to All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 131);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.txt_MessageToSend);
            this.Name = "Form1";
            this.Text = "Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MessageToSend;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.Button button1;
    }
}


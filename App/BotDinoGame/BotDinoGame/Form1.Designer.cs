namespace BotDinoGame
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
            this.listBoxCapture = new System.Windows.Forms.ListBox();
            this.buttonAutoRun = new System.Windows.Forms.Button();
            this.buttonDeleteCapture = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.pictureBoxFirstSnip = new System.Windows.Forms.PictureBox();
            this.pictureBoxRealtimeSnip = new System.Windows.Forms.PictureBox();
            this.timerAutoRun = new System.Windows.Forms.Timer(this.components);
            this.checkBoxShowRealTimeSnip = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstSnip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRealtimeSnip)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCapture
            // 
            this.listBoxCapture.FormattingEnabled = true;
            this.listBoxCapture.ItemHeight = 16;
            this.listBoxCapture.Location = new System.Drawing.Point(12, 12);
            this.listBoxCapture.Name = "listBoxCapture";
            this.listBoxCapture.Size = new System.Drawing.Size(625, 244);
            this.listBoxCapture.TabIndex = 0;
            // 
            // buttonAutoRun
            // 
            this.buttonAutoRun.Location = new System.Drawing.Point(235, 272);
            this.buttonAutoRun.Name = "buttonAutoRun";
            this.buttonAutoRun.Size = new System.Drawing.Size(123, 41);
            this.buttonAutoRun.TabIndex = 1;
            this.buttonAutoRun.Text = "Auto Run";
            this.buttonAutoRun.UseVisualStyleBackColor = true;
            this.buttonAutoRun.Click += new System.EventHandler(this.buttonAutoRun_Click);
            // 
            // buttonDeleteCapture
            // 
            this.buttonDeleteCapture.Location = new System.Drawing.Point(375, 272);
            this.buttonDeleteCapture.Name = "buttonDeleteCapture";
            this.buttonDeleteCapture.Size = new System.Drawing.Size(123, 41);
            this.buttonDeleteCapture.TabIndex = 1;
            this.buttonDeleteCapture.Text = "Delete Capture";
            this.buttonDeleteCapture.UseVisualStyleBackColor = true;
            this.buttonDeleteCapture.Click += new System.EventHandler(this.buttonDeleteCapture_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(514, 272);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(123, 41);
            this.buttonCapture.TabIndex = 1;
            this.buttonCapture.Text = "Add Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // pictureBoxFirstSnip
            // 
            this.pictureBoxFirstSnip.Location = new System.Drawing.Point(659, 12);
            this.pictureBoxFirstSnip.Name = "pictureBoxFirstSnip";
            this.pictureBoxFirstSnip.Size = new System.Drawing.Size(281, 244);
            this.pictureBoxFirstSnip.TabIndex = 2;
            this.pictureBoxFirstSnip.TabStop = false;
            // 
            // pictureBoxRealtimeSnip
            // 
            this.pictureBoxRealtimeSnip.Location = new System.Drawing.Point(978, 12);
            this.pictureBoxRealtimeSnip.Name = "pictureBoxRealtimeSnip";
            this.pictureBoxRealtimeSnip.Size = new System.Drawing.Size(281, 244);
            this.pictureBoxRealtimeSnip.TabIndex = 2;
            this.pictureBoxRealtimeSnip.TabStop = false;
            // 
            // timerAutoRun
            // 
            this.timerAutoRun.Interval = 5;
            this.timerAutoRun.Tick += new System.EventHandler(this.timerAutoRun_Tick);
            // 
            // checkBoxShowRealTimeSnip
            // 
            this.checkBoxShowRealTimeSnip.AutoSize = true;
            this.checkBoxShowRealTimeSnip.Checked = true;
            this.checkBoxShowRealTimeSnip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowRealTimeSnip.Location = new System.Drawing.Point(978, 272);
            this.checkBoxShowRealTimeSnip.Name = "checkBoxShowRealTimeSnip";
            this.checkBoxShowRealTimeSnip.Size = new System.Drawing.Size(152, 21);
            this.checkBoxShowRealTimeSnip.TabIndex = 3;
            this.checkBoxShowRealTimeSnip.Text = "ShowRealTimeSnip";
            this.checkBoxShowRealTimeSnip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 353);
            this.Controls.Add(this.checkBoxShowRealTimeSnip);
            this.Controls.Add(this.pictureBoxRealtimeSnip);
            this.Controls.Add(this.pictureBoxFirstSnip);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.buttonDeleteCapture);
            this.Controls.Add(this.buttonAutoRun);
            this.Controls.Add(this.listBoxCapture);
            this.Name = "Form1";
            this.Text = "Bot Dino Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstSnip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRealtimeSnip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCapture;
        private System.Windows.Forms.Button buttonAutoRun;
        private System.Windows.Forms.Button buttonDeleteCapture;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.PictureBox pictureBoxFirstSnip;
        private System.Windows.Forms.PictureBox pictureBoxRealtimeSnip;
        private System.Windows.Forms.Timer timerAutoRun;
        private System.Windows.Forms.CheckBox checkBoxShowRealTimeSnip;
    }
}


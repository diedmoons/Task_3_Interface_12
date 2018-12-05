namespace Task_3_Interface_12
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
            this.button_Output_Data = new System.Windows.Forms.Button();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.button_OnPlayer = new System.Windows.Forms.Button();
            this.button_OfPlayer = new System.Windows.Forms.Button();
            this.button_OnVideo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Output_Data
            // 
            this.button_Output_Data.Location = new System.Drawing.Point(13, 27);
            this.button_Output_Data.Name = "button_Output_Data";
            this.button_Output_Data.Size = new System.Drawing.Size(135, 119);
            this.button_Output_Data.TabIndex = 0;
            this.button_Output_Data.Text = "Вывести информацию о плеерах";
            this.button_Output_Data.UseVisualStyleBackColor = true;
            this.button_Output_Data.Click += new System.EventHandler(this.button_Output_Data_Click);
            // 
            // textBox_Info
            // 
            this.textBox_Info.Location = new System.Drawing.Point(178, 27);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(193, 119);
            this.textBox_Info.TabIndex = 1;
            // 
            // button_OnPlayer
            // 
            this.button_OnPlayer.Location = new System.Drawing.Point(13, 173);
            this.button_OnPlayer.Name = "button_OnPlayer";
            this.button_OnPlayer.Size = new System.Drawing.Size(135, 44);
            this.button_OnPlayer.TabIndex = 2;
            this.button_OnPlayer.Text = "Включить плеер";
            this.button_OnPlayer.UseVisualStyleBackColor = true;
            this.button_OnPlayer.Click += new System.EventHandler(this.button_OnPlayer_Click);
            // 
            // button_OfPlayer
            // 
            this.button_OfPlayer.Location = new System.Drawing.Point(178, 173);
            this.button_OfPlayer.Name = "button_OfPlayer";
            this.button_OfPlayer.Size = new System.Drawing.Size(193, 44);
            this.button_OfPlayer.TabIndex = 3;
            this.button_OfPlayer.Text = "Выключить плеер";
            this.button_OfPlayer.UseVisualStyleBackColor = true;
            this.button_OfPlayer.Click += new System.EventHandler(this.button_OfPlayer_Click);
            // 
            // button_OnVideo
            // 
            this.button_OnVideo.Location = new System.Drawing.Point(13, 232);
            this.button_OnVideo.Name = "button_OnVideo";
            this.button_OnVideo.Size = new System.Drawing.Size(135, 44);
            this.button_OnVideo.TabIndex = 4;
            this.button_OnVideo.Text = "Включить видеоплеер";
            this.button_OnVideo.UseVisualStyleBackColor = true;
            this.button_OnVideo.Click += new System.EventHandler(this.button_OnVideo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выключить видеоплеер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_OnVideo);
            this.Controls.Add(this.button_OfPlayer);
            this.Controls.Add(this.button_OnPlayer);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.button_Output_Data);
            this.Name = "Form1";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Output_Data;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.Button button_OnPlayer;
        private System.Windows.Forms.Button button_OfPlayer;
        private System.Windows.Forms.Button button_OnVideo;
        private System.Windows.Forms.Button button1;
    }
}


namespace PadSound
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
            this.btnLoad_Click = new System.Windows.Forms.Button();
            this.txtAudioFile = new System.Windows.Forms.Label();
            this.btnPlay_Click = new System.Windows.Forms.Button();
            this.btnPause_Click = new System.Windows.Forms.Button();
            this.btnStop_Click = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLoad_Click
            // 
            this.btnLoad_Click.Location = new System.Drawing.Point(12, 393);
            this.btnLoad_Click.Name = "btnLoad_Click";
            this.btnLoad_Click.Size = new System.Drawing.Size(120, 45);
            this.btnLoad_Click.TabIndex = 0;
            this.btnLoad_Click.Text = "browse";
            this.btnLoad_Click.UseVisualStyleBackColor = true;
            this.btnLoad_Click.Click += new System.EventHandler(this.btnLoad_Click_Click);
            // 
            // txtAudioFile
            // 
            this.txtAudioFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAudioFile.Location = new System.Drawing.Point(12, 9);
            this.txtAudioFile.Name = "txtAudioFile";
            this.txtAudioFile.Size = new System.Drawing.Size(776, 53);
            this.txtAudioFile.TabIndex = 1;
            this.txtAudioFile.Text = "label1";
            // 
            // btnPlay_Click
            // 
            this.btnPlay_Click.Location = new System.Drawing.Point(147, 393);
            this.btnPlay_Click.Name = "btnPlay_Click";
            this.btnPlay_Click.Size = new System.Drawing.Size(120, 45);
            this.btnPlay_Click.TabIndex = 2;
            this.btnPlay_Click.Text = "Play";
            this.btnPlay_Click.UseVisualStyleBackColor = true;
            this.btnPlay_Click.Click += new System.EventHandler(this.btnPlay_Click_Click);
            // 
            // btnPause_Click
            // 
            this.btnPause_Click.Location = new System.Drawing.Point(273, 393);
            this.btnPause_Click.Name = "btnPause_Click";
            this.btnPause_Click.Size = new System.Drawing.Size(120, 45);
            this.btnPause_Click.TabIndex = 3;
            this.btnPause_Click.Text = "Pause";
            this.btnPause_Click.UseVisualStyleBackColor = true;
            this.btnPause_Click.Click += new System.EventHandler(this.btnPause_Click_Click);
            // 
            // btnStop_Click
            // 
            this.btnStop_Click.Location = new System.Drawing.Point(399, 393);
            this.btnStop_Click.Name = "btnStop_Click";
            this.btnStop_Click.Size = new System.Drawing.Size(120, 45);
            this.btnStop_Click.TabIndex = 4;
            this.btnStop_Click.Text = "Stop";
            this.btnStop_Click.UseVisualStyleBackColor = true;
            this.btnStop_Click.Click += new System.EventHandler(this.btnStop_Click_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 334);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Tag = "qwe";
            this.checkBox1.Text = "0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 360);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(36, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Tag = "qwe";
            this.checkBox2.Text = "1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnStop_Click);
            this.Controls.Add(this.btnPause_Click);
            this.Controls.Add(this.btnPlay_Click);
            this.Controls.Add(this.txtAudioFile);
            this.Controls.Add(this.btnLoad_Click);
            this.Name = "Form1";
            this.Text = "PadSound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad_Click;
        private System.Windows.Forms.Label txtAudioFile;
        private System.Windows.Forms.Button btnPlay_Click;
        private System.Windows.Forms.Button btnPause_Click;
        private System.Windows.Forms.Button btnStop_Click;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}



namespace Csharp_Arduino_Interface
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_kapat = new System.Windows.Forms.Button();
            this.button_ac = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.label_baud = new System.Windows.Forms.Label();
            this.label_disconnect = new System.Windows.Forms.Label();
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.label_comport = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.richTextBox_textreceiver = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox_send1 = new System.Windows.Forms.TextBox();
            this.textBox_send2 = new System.Windows.Forms.TextBox();
            this.textBox_send3 = new System.Windows.Forms.TextBox();
            this.textBox_send4 = new System.Windows.Forms.TextBox();
            this.label_motor0 = new System.Windows.Forms.Label();
            this.label_motor1 = new System.Windows.Forms.Label();
            this.label_motor2 = new System.Windows.Forms.Label();
            this.label_motor3 = new System.Windows.Forms.Label();
            this.label_motor4 = new System.Windows.Forms.Label();
            this.button_basla = new System.Windows.Forms.Button();
            this.button_dur = new System.Windows.Forms.Button();
            this.button_sifirla = new System.Windows.Forms.Button();
            this.button_sol = new System.Windows.Forms.Button();
            this.button_sag = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_kapat);
            this.groupBox1.Controls.Add(this.button_ac);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.progressBar_status);
            this.groupBox1.Controls.Add(this.comboBox_baud);
            this.groupBox1.Controls.Add(this.label_baud);
            this.groupBox1.Controls.Add(this.label_disconnect);
            this.groupBox1.Controls.Add(this.comboBox_comport);
            this.groupBox1.Controls.Add(this.label_comport);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            // 
            // button_kapat
            // 
            this.button_kapat.Location = new System.Drawing.Point(160, 236);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(98, 45);
            this.button_kapat.TabIndex = 8;
            this.button_kapat.Text = "KAPAT";
            this.button_kapat.UseVisualStyleBackColor = true;
            this.button_kapat.Click += new System.EventHandler(this.button_kapat_Click);
            // 
            // button_ac
            // 
            this.button_ac.Location = new System.Drawing.Point(6, 236);
            this.button_ac.Name = "button_ac";
            this.button_ac.Size = new System.Drawing.Size(98, 45);
            this.button_ac.TabIndex = 7;
            this.button_ac.Text = "AC";
            this.button_ac.UseVisualStyleBackColor = true;
            this.button_ac.Click += new System.EventHandler(this.button_ac_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(30, 130);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(67, 17);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "STATUS:";
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(103, 127);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(121, 23);
            this.progressBar_status.TabIndex = 5;
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_baud.Location = new System.Drawing.Point(103, 87);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baud.TabIndex = 4;
            // 
            // label_baud
            // 
            this.label_baud.AutoSize = true;
            this.label_baud.Location = new System.Drawing.Point(6, 90);
            this.label_baud.Name = "label_baud";
            this.label_baud.Size = new System.Drawing.Size(91, 17);
            this.label_baud.TabIndex = 3;
            this.label_baud.Text = "BAUD RATE:";
            // 
            // label_disconnect
            // 
            this.label_disconnect.AutoSize = true;
            this.label_disconnect.Location = new System.Drawing.Point(100, 164);
            this.label_disconnect.Name = "label_disconnect";
            this.label_disconnect.Size = new System.Drawing.Size(116, 17);
            this.label_disconnect.TabIndex = 2;
            this.label_disconnect.Text = "DISCONNECTED";
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(103, 46);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(121, 24);
            this.comboBox_comport.TabIndex = 1;
            // 
            // label_comport
            // 
            this.label_comport.AutoSize = true;
            this.label_comport.Location = new System.Drawing.Point(11, 49);
            this.label_comport.Name = "label_comport";
            this.label_comport.Size = new System.Drawing.Size(86, 17);
            this.label_comport.TabIndex = 0;
            this.label_comport.Text = "COM PORT:";
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Segoe UI", 18.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.button_send.Location = new System.Drawing.Point(487, 11);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(100, 136);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "SEND";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(383, 11);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(98, 22);
            this.textBox_send.TabIndex = 2;
            // 
            // richTextBox_textreceiver
            // 
            this.richTextBox_textreceiver.Location = new System.Drawing.Point(609, 11);
            this.richTextBox_textreceiver.Name = "richTextBox_textreceiver";
            this.richTextBox_textreceiver.Size = new System.Drawing.Size(179, 309);
            this.richTextBox_textreceiver.TabIndex = 3;
            this.richTextBox_textreceiver.Text = "";
            this.richTextBox_textreceiver.TextChanged += new System.EventHandler(this.richTextBox_textreceiver_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox_send1
            // 
            this.textBox_send1.Location = new System.Drawing.Point(383, 39);
            this.textBox_send1.Name = "textBox_send1";
            this.textBox_send1.Size = new System.Drawing.Size(98, 22);
            this.textBox_send1.TabIndex = 4;
            // 
            // textBox_send2
            // 
            this.textBox_send2.Location = new System.Drawing.Point(383, 67);
            this.textBox_send2.Name = "textBox_send2";
            this.textBox_send2.Size = new System.Drawing.Size(98, 22);
            this.textBox_send2.TabIndex = 5;
            // 
            // textBox_send3
            // 
            this.textBox_send3.Location = new System.Drawing.Point(383, 95);
            this.textBox_send3.Name = "textBox_send3";
            this.textBox_send3.Size = new System.Drawing.Size(98, 22);
            this.textBox_send3.TabIndex = 6;
            // 
            // textBox_send4
            // 
            this.textBox_send4.Location = new System.Drawing.Point(383, 125);
            this.textBox_send4.Name = "textBox_send4";
            this.textBox_send4.Size = new System.Drawing.Size(98, 22);
            this.textBox_send4.TabIndex = 7;
            // 
            // label_motor0
            // 
            this.label_motor0.AutoSize = true;
            this.label_motor0.Location = new System.Drawing.Point(291, 14);
            this.label_motor0.Name = "label_motor0";
            this.label_motor0.Size = new System.Drawing.Size(72, 17);
            this.label_motor0.TabIndex = 8;
            this.label_motor0.Text = "MOTOR 0";
            // 
            // label_motor1
            // 
            this.label_motor1.AutoSize = true;
            this.label_motor1.Location = new System.Drawing.Point(291, 44);
            this.label_motor1.Name = "label_motor1";
            this.label_motor1.Size = new System.Drawing.Size(72, 17);
            this.label_motor1.TabIndex = 9;
            this.label_motor1.Text = "MOTOR 1";
            // 
            // label_motor2
            // 
            this.label_motor2.AutoSize = true;
            this.label_motor2.Location = new System.Drawing.Point(291, 70);
            this.label_motor2.Name = "label_motor2";
            this.label_motor2.Size = new System.Drawing.Size(72, 17);
            this.label_motor2.TabIndex = 10;
            this.label_motor2.Text = "MOTOR 2";
            // 
            // label_motor3
            // 
            this.label_motor3.AutoSize = true;
            this.label_motor3.Location = new System.Drawing.Point(291, 100);
            this.label_motor3.Name = "label_motor3";
            this.label_motor3.Size = new System.Drawing.Size(72, 17);
            this.label_motor3.TabIndex = 11;
            this.label_motor3.Text = "MOTOR 3";
            // 
            // label_motor4
            // 
            this.label_motor4.AutoSize = true;
            this.label_motor4.Location = new System.Drawing.Point(291, 128);
            this.label_motor4.Name = "label_motor4";
            this.label_motor4.Size = new System.Drawing.Size(72, 17);
            this.label_motor4.TabIndex = 12;
            this.label_motor4.Text = "MOTOR 4";
            // 
            // button_basla
            // 
            this.button_basla.Location = new System.Drawing.Point(293, 190);
            this.button_basla.Name = "button_basla";
            this.button_basla.Size = new System.Drawing.Size(98, 45);
            this.button_basla.TabIndex = 13;
            this.button_basla.Text = "BASLA";
            this.button_basla.UseVisualStyleBackColor = true;
            this.button_basla.Click += new System.EventHandler(this.button_basla_Click);
            // 
            // button_dur
            // 
            this.button_dur.Location = new System.Drawing.Point(397, 190);
            this.button_dur.Name = "button_dur";
            this.button_dur.Size = new System.Drawing.Size(98, 45);
            this.button_dur.TabIndex = 14;
            this.button_dur.Text = "DUR";
            this.button_dur.UseVisualStyleBackColor = true;
            this.button_dur.Click += new System.EventHandler(this.button_dur_Click);
            // 
            // button_sifirla
            // 
            this.button_sifirla.Location = new System.Drawing.Point(501, 190);
            this.button_sifirla.Name = "button_sifirla";
            this.button_sifirla.Size = new System.Drawing.Size(98, 45);
            this.button_sifirla.TabIndex = 15;
            this.button_sifirla.Text = "SIFIRLA";
            this.button_sifirla.UseVisualStyleBackColor = true;
            this.button_sifirla.Click += new System.EventHandler(this.button_sifirla_Click);
            // 
            // button_sol
            // 
            this.button_sol.Location = new System.Drawing.Point(294, 275);
            this.button_sol.Name = "button_sol";
            this.button_sol.Size = new System.Drawing.Size(98, 45);
            this.button_sol.TabIndex = 16;
            this.button_sol.Text = "SOL";
            this.button_sol.UseVisualStyleBackColor = true;
            this.button_sol.Click += new System.EventHandler(this.button_sol_Click);
            // 
            // button_sag
            // 
            this.button_sag.Location = new System.Drawing.Point(501, 275);
            this.button_sag.Name = "button_sag";
            this.button_sag.Size = new System.Drawing.Size(98, 45);
            this.button_sag.TabIndex = 17;
            this.button_sag.Text = "SAG";
            this.button_sag.UseVisualStyleBackColor = true;
            this.button_sag.Click += new System.EventHandler(this.button_sag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.button_sag);
            this.Controls.Add(this.button_sol);
            this.Controls.Add(this.button_sifirla);
            this.Controls.Add(this.button_dur);
            this.Controls.Add(this.button_basla);
            this.Controls.Add(this.label_motor4);
            this.Controls.Add(this.label_motor3);
            this.Controls.Add(this.label_motor2);
            this.Controls.Add(this.label_motor1);
            this.Controls.Add(this.label_motor0);
            this.Controls.Add(this.textBox_send4);
            this.Controls.Add(this.textBox_send3);
            this.Controls.Add(this.textBox_send2);
            this.Controls.Add(this.textBox_send1);
            this.Controls.Add(this.richTextBox_textreceiver);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.Label label_comport;
        private System.Windows.Forms.Label label_disconnect;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Label label_baud;
        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.Button button_ac;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.RichTextBox richTextBox_textreceiver;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox_send1;
        private System.Windows.Forms.TextBox textBox_send2;
        private System.Windows.Forms.TextBox textBox_send3;
        private System.Windows.Forms.TextBox textBox_send4;
        private System.Windows.Forms.Label label_motor0;
        private System.Windows.Forms.Label label_motor1;
        private System.Windows.Forms.Label label_motor2;
        private System.Windows.Forms.Label label_motor3;
        private System.Windows.Forms.Label label_motor4;
        private System.Windows.Forms.Button button_basla;
        private System.Windows.Forms.Button button_dur;
        private System.Windows.Forms.Button button_sifirla;
        private System.Windows.Forms.Button button_sol;
        private System.Windows.Forms.Button button_sag;
    }
}


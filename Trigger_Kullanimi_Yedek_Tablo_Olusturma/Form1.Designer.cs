
namespace Trigger_Kullanimi_Yedek_Tablo_Olusturma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtAD = new System.Windows.Forms.TextBox();
            this.TxtSAYFA = new System.Windows.Forms.TextBox();
            this.TxtYAZAR = new System.Windows.Forms.TextBox();
            this.TxtYAYIN = new System.Windows.Forms.TextBox();
            this.TxtTUR = new System.Windows.Forms.TextBox();
            this.BtnEKLE = new System.Windows.Forms.Button();
            this.BTNSIL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblKitap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNSIL);
            this.groupBox1.Controls.Add(this.BtnEKLE);
            this.groupBox1.Controls.Add(this.TxtTUR);
            this.groupBox1.Controls.Add(this.TxtYAYIN);
            this.groupBox1.Controls.Add(this.TxtYAZAR);
            this.groupBox1.Controls.Add(this.TxtSAYFA);
            this.groupBox1.Controls.Add(this.TxtAD);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "YAZAR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "SAYFA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "YAYINEVİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "TÜR:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(119, 44);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(256, 30);
            this.TxtID.TabIndex = 1;
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(119, 95);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(256, 30);
            this.TxtAD.TabIndex = 2;
            // 
            // TxtSAYFA
            // 
            this.TxtSAYFA.Location = new System.Drawing.Point(119, 207);
            this.TxtSAYFA.Name = "TxtSAYFA";
            this.TxtSAYFA.Size = new System.Drawing.Size(256, 30);
            this.TxtSAYFA.TabIndex = 4;
            // 
            // TxtYAZAR
            // 
            this.TxtYAZAR.Location = new System.Drawing.Point(119, 147);
            this.TxtYAZAR.Name = "TxtYAZAR";
            this.TxtYAZAR.Size = new System.Drawing.Size(256, 30);
            this.TxtYAZAR.TabIndex = 3;
            // 
            // TxtYAYIN
            // 
            this.TxtYAYIN.Location = new System.Drawing.Point(119, 257);
            this.TxtYAYIN.Name = "TxtYAYIN";
            this.TxtYAYIN.Size = new System.Drawing.Size(256, 30);
            this.TxtYAYIN.TabIndex = 5;
            // 
            // TxtTUR
            // 
            this.TxtTUR.Location = new System.Drawing.Point(119, 304);
            this.TxtTUR.Name = "TxtTUR";
            this.TxtTUR.Size = new System.Drawing.Size(256, 30);
            this.TxtTUR.TabIndex = 6;
            // 
            // BtnEKLE
            // 
            this.BtnEKLE.BackColor = System.Drawing.Color.Green;
            this.BtnEKLE.Location = new System.Drawing.Point(119, 354);
            this.BtnEKLE.Name = "BtnEKLE";
            this.BtnEKLE.Size = new System.Drawing.Size(119, 39);
            this.BtnEKLE.TabIndex = 7;
            this.BtnEKLE.Text = "EKLE";
            this.BtnEKLE.UseVisualStyleBackColor = false;
            this.BtnEKLE.Click += new System.EventHandler(this.BtnEKLE_Click);
            // 
            // BTNSIL
            // 
            this.BTNSIL.BackColor = System.Drawing.Color.Red;
            this.BTNSIL.Location = new System.Drawing.Point(256, 354);
            this.BTNSIL.Name = "BTNSIL";
            this.BTNSIL.Size = new System.Drawing.Size(119, 39);
            this.BTNSIL.TabIndex = 8;
            this.BTNSIL.Text = "SİL";
            this.BTNSIL.UseVisualStyleBackColor = false;
            this.BTNSIL.Click += new System.EventHandler(this.BTNSIL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 337);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblKitap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(414, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(749, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Adet:";
            // 
            // LblKitap
            // 
            this.LblKitap.AutoSize = true;
            this.LblKitap.Location = new System.Drawing.Point(394, 28);
            this.LblKitap.Name = "LblKitap";
            this.LblKitap.Size = new System.Drawing.Size(24, 25);
            this.LblKitap.TabIndex = 1;
            this.LblKitap.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1166, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Trigger-Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNSIL;
        private System.Windows.Forms.Button BtnEKLE;
        private System.Windows.Forms.TextBox TxtTUR;
        private System.Windows.Forms.TextBox TxtYAYIN;
        private System.Windows.Forms.TextBox TxtYAZAR;
        private System.Windows.Forms.TextBox TxtSAYFA;
        private System.Windows.Forms.TextBox TxtAD;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKitap;
        private System.Windows.Forms.Label label7;
    }
}



namespace U200920021_TAKIM
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
            this.rbBeyaz = new System.Windows.Forms.RadioButton();
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.rbSari = new System.Windows.Forms.RadioButton();
            this.rbYeşil = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYeşil);
            this.groupBox1.Controls.Add(this.rbSari);
            this.groupBox1.Controls.Add(this.rbKirmizi);
            this.groupBox1.Controls.Add(this.rbMavi);
            this.groupBox1.Controls.Add(this.rbBeyaz);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renkler";
            // 
            // rbBeyaz
            // 
            this.rbBeyaz.AutoSize = true;
            this.rbBeyaz.Location = new System.Drawing.Point(167, 49);
            this.rbBeyaz.Name = "rbBeyaz";
            this.rbBeyaz.Size = new System.Drawing.Size(57, 17);
            this.rbBeyaz.TabIndex = 0;
            this.rbBeyaz.TabStop = true;
            this.rbBeyaz.Text = "Beyaz ";
            this.rbBeyaz.UseVisualStyleBackColor = true;
            this.rbBeyaz.CheckedChanged += new System.EventHandler(this.rbBeyaz_CheckedChanged);
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Location = new System.Drawing.Point(167, 86);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(48, 17);
            this.rbMavi.TabIndex = 1;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "Mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            this.rbMavi.CheckedChanged += new System.EventHandler(this.rbMavi_CheckedChanged);
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Location = new System.Drawing.Point(167, 123);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(54, 17);
            this.rbKirmizi.TabIndex = 2;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "Kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            this.rbKirmizi.CheckedChanged += new System.EventHandler(this.rbKirmizi_CheckedChanged);
            // 
            // rbSari
            // 
            this.rbSari.AutoSize = true;
            this.rbSari.Location = new System.Drawing.Point(167, 160);
            this.rbSari.Name = "rbSari";
            this.rbSari.Size = new System.Drawing.Size(43, 17);
            this.rbSari.TabIndex = 3;
            this.rbSari.TabStop = true;
            this.rbSari.Text = "Sarı";
            this.rbSari.UseVisualStyleBackColor = true;
            this.rbSari.CheckedChanged += new System.EventHandler(this.rbSari_CheckedChanged);
            // 
            // rbYeşil
            // 
            this.rbYeşil.AutoSize = true;
            this.rbYeşil.Location = new System.Drawing.Point(167, 197);
            this.rbYeşil.Name = "rbYeşil";
            this.rbYeşil.Size = new System.Drawing.Size(47, 17);
            this.rbYeşil.TabIndex = 4;
            this.rbYeşil.TabStop = true;
            this.rbYeşil.Text = "Yeşil";
            this.rbYeşil.UseVisualStyleBackColor = true;
            this.rbYeşil.CheckedChanged += new System.EventHandler(this.rbYeşil_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 255);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYeşil;
        private System.Windows.Forms.RadioButton rbSari;
        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.RadioButton rbBeyaz;
    }
}


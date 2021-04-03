
namespace UçakSavar
{
    partial class SavaşOyunu
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
            System.Windows.Forms.Label SüreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavaşOyunu));
            this.BilgiPaneli = new System.Windows.Forms.Panel();
            this.BaşlatLabel = new System.Windows.Forms.Label();
            this.BilgiLabel = new System.Windows.Forms.Label();
            this.UçakSavarPanel = new System.Windows.Forms.Panel();
            this.SavaşAlanı = new System.Windows.Forms.Panel();
            SüreLabel = new System.Windows.Forms.Label();
            this.BilgiPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // SüreLabel
            // 
            SüreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            SüreLabel.Font = new System.Drawing.Font("Pricedown Bl", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SüreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            SüreLabel.Location = new System.Drawing.Point(627, 3);
            SüreLabel.Name = "SüreLabel";
            SüreLabel.Size = new System.Drawing.Size(196, 63);
            SüreLabel.TabIndex = 1;
            SüreLabel.Text = "0:00";
            SüreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BilgiPaneli
            // 
            this.BilgiPaneli.BackColor = System.Drawing.Color.Aqua;
            this.BilgiPaneli.Controls.Add(this.BaşlatLabel);
            this.BilgiPaneli.Controls.Add(this.BilgiLabel);
            this.BilgiPaneli.Controls.Add(SüreLabel);
            this.BilgiPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.BilgiPaneli.Location = new System.Drawing.Point(0, 0);
            this.BilgiPaneli.Name = "BilgiPaneli";
            this.BilgiPaneli.Size = new System.Drawing.Size(823, 85);
            this.BilgiPaneli.TabIndex = 0;
            // 
            // BaşlatLabel
            // 
            this.BaşlatLabel.BackColor = System.Drawing.Color.Aqua;
            this.BaşlatLabel.Font = new System.Drawing.Font("Oswald", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaşlatLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BaşlatLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BaşlatLabel.Location = new System.Drawing.Point(3, 42);
            this.BaşlatLabel.Name = "BaşlatLabel";
            this.BaşlatLabel.Size = new System.Drawing.Size(604, 83);
            this.BaşlatLabel.TabIndex = 0;
            this.BaşlatLabel.Text = "Oyunu baslatmak için ENTER tuşuna basınız.\r\n\r\n";
            // 
            // BilgiLabel
            // 
            this.BilgiLabel.AutoSize = true;
            this.BilgiLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BilgiLabel.Location = new System.Drawing.Point(9, 3);
            this.BilgiLabel.Name = "BilgiLabel";
            this.BilgiLabel.Size = new System.Drawing.Size(294, 39);
            this.BilgiLabel.TabIndex = 2;
            this.BilgiLabel.Text = "Oyun tuş takımı bilgisi:\r\nUçaksavarı hareket ettirmek için YÖN TUŞLARINI kullanın" +
    "ız.\r\nAteş etmek için BOŞLUK tuşuna basınız\r\n";
            // 
            // UçakSavarPanel
            // 
            this.UçakSavarPanel.BackColor = System.Drawing.SystemColors.MenuText;
            this.UçakSavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UçakSavarPanel.Location = new System.Drawing.Point(0, 400);
            this.UçakSavarPanel.Name = "UçakSavarPanel";
            this.UçakSavarPanel.Size = new System.Drawing.Size(823, 50);
            this.UçakSavarPanel.TabIndex = 1;
            // 
            // SavaşAlanı
            // 
            this.SavaşAlanı.BackColor = System.Drawing.SystemColors.GrayText;
            this.SavaşAlanı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavaşAlanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SavaşAlanı.Location = new System.Drawing.Point(0, 85);
            this.SavaşAlanı.Name = "SavaşAlanı";
            this.SavaşAlanı.Size = new System.Drawing.Size(823, 315);
            this.SavaşAlanı.TabIndex = 2;
            // 
            // SavaşOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.SavaşAlanı);
            this.Controls.Add(this.UçakSavarPanel);
            this.Controls.Add(this.BilgiPaneli);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SavaşOyunu";
            this.Text = "SavaşOyunu";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SavaşOyunu_KeyDown);
            this.BilgiPaneli.ResumeLayout(false);
            this.BilgiPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BilgiPaneli;
        private System.Windows.Forms.Panel UçakSavarPanel;
        private System.Windows.Forms.Panel SavaşAlanı;
        private System.Windows.Forms.Label BaşlatLabel;
        private System.Windows.Forms.Label BilgiLabel;
    }
}


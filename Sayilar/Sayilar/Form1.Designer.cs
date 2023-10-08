namespace Sayilar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.txtBitis = new System.Windows.Forms.MaskedTextBox();
            this.baslangic = new System.Windows.Forms.Label();
            this.bitis = new System.Windows.Forms.Label();
            this.tabControlSayilar = new System.Windows.Forms.TabControl();
            this.tabTekSayi = new System.Windows.Forms.TabPage();
            this.listTekSayi = new System.Windows.Forms.ListView();
            this.TekSayilistesi = new System.Windows.Forms.ColumnHeader();
            this.tekSayiToplamListesi = new System.Windows.Forms.ColumnHeader();
            this.tekSayiCarpimListesi = new System.Windows.Forms.ColumnHeader();
            this.tabCiftSayi = new System.Windows.Forms.TabPage();
            this.listCiftSayi = new System.Windows.Forms.ListView();
            this.ciftSayiListesi = new System.Windows.Forms.ColumnHeader();
            this.ciftSayiToplamListesi = new System.Windows.Forms.ColumnHeader();
            this.ciftSayiCarpimListesi = new System.Windows.Forms.ColumnHeader();
            this.tabAsalSayi = new System.Windows.Forms.TabPage();
            this.listAsalSayi = new System.Windows.Forms.ListView();
            this.asalSayiListesi = new System.Windows.Forms.ColumnHeader();
            this.asalSayiToplamListesi = new System.Windows.Forms.ColumnHeader();
            this.asalSayiCarpimListesi = new System.Windows.Forms.ColumnHeader();
            this.tabMukemmelSayi = new System.Windows.Forms.TabPage();
            this.listMukemmelSayi = new System.Windows.Forms.ListView();
            this.mukemmelSayiListesi = new System.Windows.Forms.ColumnHeader();
            this.mukemmelSayiToplamListesi = new System.Windows.Forms.ColumnHeader();
            this.mukemmelSayiCarpimListesi = new System.Windows.Forms.ColumnHeader();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tabControlSayilar.SuspendLayout();
            this.tabTekSayi.SuspendLayout();
            this.tabCiftSayi.SuspendLayout();
            this.tabAsalSayi.SuspendLayout();
            this.tabMukemmelSayi.SuspendLayout();
            this.SuspendLayout();
            // 
            // bildirim
            // 
            this.bildirim.Icon = ((System.Drawing.Icon)(resources.GetObject("bildirim.Icon")));
            this.bildirim.Text = "notifyIcon1";
            this.bildirim.Visible = true;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(147, 73);
            this.txtBaslangic.Mask = "00000";
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(64, 23);
            this.txtBaslangic.TabIndex = 0;
            this.txtBaslangic.ValidatingType = typeof(int);
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(319, 73);
            this.txtBitis.Mask = "00000";
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(64, 23);
            this.txtBitis.TabIndex = 1;
            this.txtBitis.ValidatingType = typeof(int);
            // 
            // baslangic
            // 
            this.baslangic.AutoSize = true;
            this.baslangic.Location = new System.Drawing.Point(71, 76);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(70, 15);
            this.baslangic.TabIndex = 2;
            this.baslangic.Text = "Başlangıç";
            // 
            // bitis
            // 
            this.bitis.AutoSize = true;
            this.bitis.Location = new System.Drawing.Point(271, 76);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(42, 15);
            this.bitis.TabIndex = 3;
            this.bitis.Text = "Bitiş";
            // 
            // tabControlSayilar
            // 
            this.tabControlSayilar.Controls.Add(this.tabTekSayi);
            this.tabControlSayilar.Controls.Add(this.tabCiftSayi);
            this.tabControlSayilar.Controls.Add(this.tabAsalSayi);
            this.tabControlSayilar.Controls.Add(this.tabMukemmelSayi);
            this.tabControlSayilar.Location = new System.Drawing.Point(12, 204);
            this.tabControlSayilar.Name = "tabControlSayilar";
            this.tabControlSayilar.SelectedIndex = 0;
            this.tabControlSayilar.Size = new System.Drawing.Size(776, 231);
            this.tabControlSayilar.TabIndex = 4;
            // 
            // tabTekSayi
            // 
            this.tabTekSayi.Controls.Add(this.listTekSayi);
            this.tabTekSayi.Location = new System.Drawing.Point(4, 24);
            this.tabTekSayi.Name = "tabTekSayi";
            this.tabTekSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayi.Size = new System.Drawing.Size(768, 203);
            this.tabTekSayi.TabIndex = 0;
            this.tabTekSayi.Text = "Tek Sayılar";
            this.tabTekSayi.UseVisualStyleBackColor = true;
            // 
            // listTekSayi
            // 
            this.listTekSayi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TekSayilistesi,
            this.tekSayiToplamListesi,
            this.tekSayiCarpimListesi});
            this.listTekSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTekSayi.GridLines = true;
            this.listTekSayi.Location = new System.Drawing.Point(3, 3);
            this.listTekSayi.Name = "listTekSayi";
            this.listTekSayi.Size = new System.Drawing.Size(762, 197);
            this.listTekSayi.TabIndex = 0;
            this.listTekSayi.UseCompatibleStateImageBehavior = false;
            this.listTekSayi.View = System.Windows.Forms.View.Details;
            // 
            // TekSayilistesi
            // 
            this.TekSayilistesi.Text = "TEK SAYILAR";
            this.TekSayilistesi.Width = 150;
            // 
            // tekSayiToplamListesi
            // 
            this.tekSayiToplamListesi.Text = "TEK SAYILARIN TOPLAMI";
            this.tekSayiToplamListesi.Width = 200;
            // 
            // tekSayiCarpimListesi
            // 
            this.tekSayiCarpimListesi.Text = "TEK SAYILARIN ÇARPIMI";
            this.tekSayiCarpimListesi.Width = 200;
            // 
            // tabCiftSayi
            // 
            this.tabCiftSayi.Controls.Add(this.listCiftSayi);
            this.tabCiftSayi.Location = new System.Drawing.Point(4, 24);
            this.tabCiftSayi.Name = "tabCiftSayi";
            this.tabCiftSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayi.Size = new System.Drawing.Size(768, 203);
            this.tabCiftSayi.TabIndex = 1;
            this.tabCiftSayi.Text = "Çift Sayılar";
            this.tabCiftSayi.UseVisualStyleBackColor = true;
            // 
            // listCiftSayi
            // 
            this.listCiftSayi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ciftSayiListesi,
            this.ciftSayiToplamListesi,
            this.ciftSayiCarpimListesi});
            this.listCiftSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCiftSayi.GridLines = true;
            this.listCiftSayi.Location = new System.Drawing.Point(3, 3);
            this.listCiftSayi.Name = "listCiftSayi";
            this.listCiftSayi.Size = new System.Drawing.Size(762, 197);
            this.listCiftSayi.TabIndex = 0;
            this.listCiftSayi.UseCompatibleStateImageBehavior = false;
            this.listCiftSayi.View = System.Windows.Forms.View.Details;
            // 
            // ciftSayiListesi
            // 
            this.ciftSayiListesi.Text = "ÇİFT SAYILAR";
            this.ciftSayiListesi.Width = 150;
            // 
            // ciftSayiToplamListesi
            // 
            this.ciftSayiToplamListesi.Text = "ÇİFT SAYILARIN TOPLAMI";
            this.ciftSayiToplamListesi.Width = 200;
            // 
            // ciftSayiCarpimListesi
            // 
            this.ciftSayiCarpimListesi.Text = "ÇİFT SAYILARIN ÇARPIMI";
            this.ciftSayiCarpimListesi.Width = 200;
            // 
            // tabAsalSayi
            // 
            this.tabAsalSayi.Controls.Add(this.listAsalSayi);
            this.tabAsalSayi.Location = new System.Drawing.Point(4, 24);
            this.tabAsalSayi.Name = "tabAsalSayi";
            this.tabAsalSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayi.Size = new System.Drawing.Size(768, 203);
            this.tabAsalSayi.TabIndex = 2;
            this.tabAsalSayi.Text = "Asal Sayılar";
            this.tabAsalSayi.UseVisualStyleBackColor = true;
            // 
            // listAsalSayi
            // 
            this.listAsalSayi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.asalSayiListesi,
            this.asalSayiToplamListesi,
            this.asalSayiCarpimListesi});
            this.listAsalSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAsalSayi.GridLines = true;
            this.listAsalSayi.Location = new System.Drawing.Point(3, 3);
            this.listAsalSayi.Name = "listAsalSayi";
            this.listAsalSayi.Size = new System.Drawing.Size(762, 197);
            this.listAsalSayi.TabIndex = 0;
            this.listAsalSayi.UseCompatibleStateImageBehavior = false;
            this.listAsalSayi.View = System.Windows.Forms.View.Details;
            // 
            // asalSayiListesi
            // 
            this.asalSayiListesi.Text = "ASAL SAYILAR";
            this.asalSayiListesi.Width = 150;
            // 
            // asalSayiToplamListesi
            // 
            this.asalSayiToplamListesi.Text = "ASAL SAYILARIN TOPLAMI";
            this.asalSayiToplamListesi.Width = 200;
            // 
            // asalSayiCarpimListesi
            // 
            this.asalSayiCarpimListesi.Text = "ASAL SAYILARIN ÇARPIMI";
            this.asalSayiCarpimListesi.Width = 200;
            // 
            // tabMukemmelSayi
            // 
            this.tabMukemmelSayi.Controls.Add(this.listMukemmelSayi);
            this.tabMukemmelSayi.Location = new System.Drawing.Point(4, 24);
            this.tabMukemmelSayi.Name = "tabMukemmelSayi";
            this.tabMukemmelSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabMukemmelSayi.Size = new System.Drawing.Size(768, 203);
            this.tabMukemmelSayi.TabIndex = 3;
            this.tabMukemmelSayi.Text = "Mükemmel Sayılar";
            this.tabMukemmelSayi.UseVisualStyleBackColor = true;
            // 
            // listMukemmelSayi
            // 
            this.listMukemmelSayi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mukemmelSayiListesi,
            this.mukemmelSayiToplamListesi,
            this.mukemmelSayiCarpimListesi});
            this.listMukemmelSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMukemmelSayi.GridLines = true;
            this.listMukemmelSayi.Location = new System.Drawing.Point(3, 3);
            this.listMukemmelSayi.Name = "listMukemmelSayi";
            this.listMukemmelSayi.Size = new System.Drawing.Size(762, 197);
            this.listMukemmelSayi.TabIndex = 0;
            this.listMukemmelSayi.UseCompatibleStateImageBehavior = false;
            this.listMukemmelSayi.View = System.Windows.Forms.View.Details;
            // 
            // mukemmelSayiListesi
            // 
            this.mukemmelSayiListesi.Text = "MÜKEMMEL SAYILAR";
            this.mukemmelSayiListesi.Width = 150;
            // 
            // mukemmelSayiToplamListesi
            // 
            this.mukemmelSayiToplamListesi.Text = "MÜKEMMEL SAYILARIN TOPLAMI";
            this.mukemmelSayiToplamListesi.Width = 200;
            // 
            // mukemmelSayiCarpimListesi
            // 
            this.mukemmelSayiCarpimListesi.Text = "MUKEMMEL SAYILARIN ÇARPIMI";
            this.mukemmelSayiCarpimListesi.Width = 200;
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.Color.LightPink;
            this.btnCalistir.Location = new System.Drawing.Point(439, 67);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(129, 33);
            this.btnCalistir.TabIndex = 5;
            this.btnCalistir.Text = "ÇALIŞTIR";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.LightPink;
            this.btnTemizle.Location = new System.Drawing.Point(593, 67);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(129, 33);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCalistir);
            this.Controls.Add(this.tabControlSayilar);
            this.Controls.Add(this.bitis);
            this.Controls.Add(this.baslangic);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sayılar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlSayilar.ResumeLayout(false);
            this.tabTekSayi.ResumeLayout(false);
            this.tabCiftSayi.ResumeLayout(false);
            this.tabAsalSayi.ResumeLayout(false);
            this.tabMukemmelSayi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon bildirim;
        private MaskedTextBox txtBaslangic;
        private MaskedTextBox txtBitis;
        private Label baslangic;
        private Label bitis;
        private TabControl tabControlSayilar;
        private TabPage tabTekSayi;
        private ListView listTekSayi;
        private TabPage tabCiftSayi;
        private ListView listCiftSayi;
        private TabPage tabAsalSayi;
        private ListView listAsalSayi;
        private TabPage tabMukemmelSayi;
        private ListView listMukemmelSayi;
        private Button btnCalistir;
        private ColumnHeader TekSayilistesi;
        private ColumnHeader tekSayiToplamListesi;
        private ColumnHeader tekSayiCarpimListesi;
        private ColumnHeader ciftSayiListesi;
        private ColumnHeader ciftSayiToplamListesi;
        private ColumnHeader ciftSayiCarpimListesi;
        private ColumnHeader asalSayiListesi;
        private ColumnHeader asalSayiToplamListesi;
        private ColumnHeader asalSayiCarpimListesi;
        private ColumnHeader mukemmelSayiListesi;
        private ColumnHeader mukemmelSayiToplamListesi;
        private ColumnHeader mukemmelSayiCarpimListesi;
        private Button btnTemizle;
    }
}
namespace WindowsFormsApp1
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
            this.iletkenTipi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dortDemet = new System.Windows.Forms.RadioButton();
            this.ucDemet = new System.Windows.Forms.RadioButton();
            this.ciftDemet = new System.Windows.Forms.RadioButton();
            this.tekDemet = new System.Windows.Forms.RadioButton();
            this.hesapla = new System.Windows.Forms.Button();
            this.dau = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.direkTipi = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uzunlukyuzde = new System.Windows.Forms.ComboBox();
            this.uzunluk = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.s2katsayisi = new System.Windows.Forms.ComboBox();
            this.hatsonugerilimi = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.katsayitipi = new System.Windows.Forms.ComboBox();
            this.guckatsayisi = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.uzunhat_vr = new System.Windows.Forms.Label();
            this.uzunhat_m = new System.Windows.Forms.Label();
            this.ortauzunhat_vr = new System.Windows.Forms.Label();
            this.ortauzunhat_m = new System.Windows.Forms.Label();
            this.kisahat_vr = new System.Windows.Forms.Label();
            this.kisahat_m = new System.Windows.Forms.Label();
            this.uzunhat_q1 = new System.Windows.Forms.Label();
            this.uzunhat_p1 = new System.Windows.Forms.Label();
            this.ortauzunhat_q1 = new System.Windows.Forms.Label();
            this.ortauzunhat_p1 = new System.Windows.Forms.Label();
            this.kisahat_q1 = new System.Windows.Forms.Label();
            this.kisahat_p1 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.uzunhat_i1 = new System.Windows.Forms.Label();
            this.uzunhat_u1 = new System.Windows.Forms.Label();
            this.ortauzunhat_i1 = new System.Windows.Forms.Label();
            this.ortauzunhat_u1 = new System.Windows.Forms.Label();
            this.kisahat_i1 = new System.Windows.Forms.Label();
            this.kisahat_u1 = new System.Windows.Forms.Label();
            this.i2 = new System.Windows.Forms.Label();
            this.u2 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.uzunhat_a = new System.Windows.Forms.Label();
            this.uzunhat_b = new System.Windows.Forms.Label();
            this.uzunhat_c = new System.Windows.Forms.Label();
            this.uzunhat_d = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.ortauzunhatt_c = new System.Windows.Forms.Label();
            this.ortauzunhatt_b = new System.Windows.Forms.Label();
            this.ortauzunhatt_d = new System.Windows.Forms.Label();
            this.ortauzunhatt_a = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.ortauzunhat_c = new System.Windows.Forms.Label();
            this.ortauzunhat_b = new System.Windows.Forms.Label();
            this.ortauzunhat_d = new System.Windows.Forms.Label();
            this.ortauzunhat_a = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.kisahat_c = new System.Windows.Forms.Label();
            this.kisahat_a = new System.Windows.Forms.Label();
            this.kisahat_d = new System.Windows.Forms.Label();
            this.kisahat_b = new System.Windows.Forms.Label();
            this.kc = new System.Windows.Forms.Label();
            this.kl = new System.Windows.Forms.Label();
            this.iletimhatuzunlugu = new System.Windows.Forms.Label();
            this.hatsonugerililmi1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // iletkenTipi
            // 
            this.iletkenTipi.FormattingEnabled = true;
            this.iletkenTipi.Items.AddRange(new object[] {
            "Stilt",
            "Grebe",
            "Gannet",
            "Gull",
            "Flamingo",
            "Scoter",
            "Egret",
            "Grosbeak",
            "Goose",
            "Rook",
            "Kingbind",
            "Swirl",
            "Wood Duck",
            "Teal",
            "Drake",
            "Squab",
            "Peacock",
            "Duck",
            "Eagle",
            "Dove",
            "Parakeet",
            "Osprey",
            "Hen",
            "Hawk",
            "Flicker",
            "Pelican",
            "Lark",
            "Ibis",
            "Brant",
            "Chickadee",
            "Oriole",
            "Linnet",
            "Widgeom",
            "Merlin",
            "Piper",
            "Ostrich",
            "Gadwall",
            "Phobe",
            "Junco",
            "Partridge",
            "Waxwing",
            "cardinal",
            "swallow",
            "pheasant"});
            this.iletkenTipi.Location = new System.Drawing.Point(6, 22);
            this.iletkenTipi.Name = "iletkenTipi";
            this.iletkenTipi.Size = new System.Drawing.Size(135, 21);
            this.iletkenTipi.TabIndex = 6;
            this.iletkenTipi.Text = "İletken Tipi";
            this.iletkenTipi.SelectedIndexChanged += new System.EventHandler(this.iletkenTipi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dortDemet);
            this.groupBox2.Controls.Add(this.ucDemet);
            this.groupBox2.Controls.Add(this.ciftDemet);
            this.groupBox2.Controls.Add(this.tekDemet);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 112);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Demet Seçimi";
            // 
            // dortDemet
            // 
            this.dortDemet.AutoSize = true;
            this.dortDemet.Location = new System.Drawing.Point(6, 88);
            this.dortDemet.Name = "dortDemet";
            this.dortDemet.Size = new System.Drawing.Size(79, 17);
            this.dortDemet.TabIndex = 12;
            this.dortDemet.TabStop = true;
            this.dortDemet.Text = "Dört Demet";
            this.dortDemet.UseVisualStyleBackColor = true;
            // 
            // ucDemet
            // 
            this.ucDemet.AutoSize = true;
            this.ucDemet.Location = new System.Drawing.Point(6, 65);
            this.ucDemet.Name = "ucDemet";
            this.ucDemet.Size = new System.Drawing.Size(73, 17);
            this.ucDemet.TabIndex = 11;
            this.ucDemet.TabStop = true;
            this.ucDemet.Text = "Üç Demet";
            this.ucDemet.UseVisualStyleBackColor = true;
            // 
            // ciftDemet
            // 
            this.ciftDemet.AutoSize = true;
            this.ciftDemet.Location = new System.Drawing.Point(6, 42);
            this.ciftDemet.Name = "ciftDemet";
            this.ciftDemet.Size = new System.Drawing.Size(74, 17);
            this.ciftDemet.TabIndex = 10;
            this.ciftDemet.TabStop = true;
            this.ciftDemet.Text = "Çift Demet";
            this.ciftDemet.UseVisualStyleBackColor = true;
            // 
            // tekDemet
            // 
            this.tekDemet.AutoSize = true;
            this.tekDemet.Location = new System.Drawing.Point(6, 19);
            this.tekDemet.Name = "tekDemet";
            this.tekDemet.Size = new System.Drawing.Size(78, 17);
            this.tekDemet.TabIndex = 9;
            this.tekDemet.TabStop = true;
            this.tekDemet.Text = "Tek Demet";
            this.tekDemet.UseVisualStyleBackColor = true;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(586, 41);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(118, 83);
            this.hesapla.TabIndex = 10;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // dau
            // 
            this.dau.Location = new System.Drawing.Point(6, 19);
            this.dau.Name = "dau";
            this.dau.Size = new System.Drawing.Size(116, 20);
            this.dau.TabIndex = 11;
            this.dau.Click += new System.EventHandler(this.v);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dau);
            this.groupBox4.Location = new System.Drawing.Point(127, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 47);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Demetler Arası Uzaklık";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iletkenTipi);
            this.groupBox1.Location = new System.Drawing.Point(261, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 52);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İletken Tipi Seçimi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // direkTipi
            // 
            this.direkTipi.FormattingEnabled = true;
            this.direkTipi.Items.AddRange(new object[] {
            "34.5 KV Direk Tiplleri",
            "4CN3",
            "LA",
            "R",
            "P",
            "BER",
            "BES",
            "BET-BEY",
            "K",
            "L",
            "PA",
            "PT",
            "PAT",
            "1NJ",
            "PKD",
            "PKN",
            "4ÇT3",
            "4ÇN3",
            "6N",
            "DB",
            "N-NA-NB",
            "6T",
            "TB",
            "DA",
            "TA1",
            "ZA1",
            "154 KV Direk Tipleri",
            "B2",
            "A2",
            "C2",
            "D2",
            "T1",
            "N1",
            "F1",
            "E1",
            "AS",
            "BS",
            "CS",
            "DT",
            "ET",
            "TA1",
            "RA1",
            "VA1",
            "ZA1",
            "PB",
            "PC",
            "PD",
            "PE(N)",
            "2FA",
            "2FB",
            "2FD",
            "2FN",
            "CP2",
            "CP1",
            "380 KV Direk Tipi",
            "CP3"});
            this.direkTipi.Location = new System.Drawing.Point(6, 18);
            this.direkTipi.Name = "direkTipi";
            this.direkTipi.Size = new System.Drawing.Size(135, 21);
            this.direkTipi.TabIndex = 19;
            this.direkTipi.Text = "Direk Tipleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.direkTipi);
            this.groupBox3.Location = new System.Drawing.Point(261, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 47);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Direk Tipi Seçimi";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Dosya";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem2.Text = "Yardım";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.uzunlukyuzde);
            this.groupBox5.Controls.Add(this.uzunluk);
            this.groupBox5.Location = new System.Drawing.Point(127, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 52);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İletim Hattı Uzunluğu";
            // 
            // uzunlukyuzde
            // 
            this.uzunlukyuzde.FormattingEnabled = true;
            this.uzunlukyuzde.Items.AddRange(new object[] {
            "10 %",
            "20 %",
            "30 %",
            "40 %",
            "50 %",
            "60 %",
            "70 %",
            "80 %",
            "90 %",
            "100 %"});
            this.uzunlukyuzde.Location = new System.Drawing.Point(69, 22);
            this.uzunlukyuzde.Name = "uzunlukyuzde";
            this.uzunlukyuzde.Size = new System.Drawing.Size(53, 21);
            this.uzunlukyuzde.TabIndex = 21;
            this.uzunlukyuzde.Text = "100 %";
            // 
            // uzunluk
            // 
            this.uzunluk.Location = new System.Drawing.Point(6, 22);
            this.uzunluk.Name = "uzunluk";
            this.uzunluk.Size = new System.Drawing.Size(57, 20);
            this.uzunluk.TabIndex = 11;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.s2katsayisi);
            this.groupBox7.Controls.Add(this.hatsonugerilimi);
            this.groupBox7.Location = new System.Drawing.Point(414, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(147, 47);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hat Sonu Gerilimi";
            // 
            // s2katsayisi
            // 
            this.s2katsayisi.FormattingEnabled = true;
            this.s2katsayisi.Items.AddRange(new object[] {
            "0,1",
            "0,5",
            "1,0",
            "1,5"});
            this.s2katsayisi.Location = new System.Drawing.Point(6, 19);
            this.s2katsayisi.Name = "s2katsayisi";
            this.s2katsayisi.Size = new System.Drawing.Size(46, 21);
            this.s2katsayisi.TabIndex = 20;
            this.s2katsayisi.Text = "1,0";
            // 
            // hatsonugerilimi
            // 
            this.hatsonugerilimi.FormattingEnabled = true;
            this.hatsonugerilimi.Items.AddRange(new object[] {
            "34500",
            "154000",
            "380000"});
            this.hatsonugerilimi.Location = new System.Drawing.Point(58, 18);
            this.hatsonugerilimi.Name = "hatsonugerilimi";
            this.hatsonugerilimi.Size = new System.Drawing.Size(83, 21);
            this.hatsonugerilimi.TabIndex = 19;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.katsayitipi);
            this.groupBox8.Controls.Add(this.guckatsayisi);
            this.groupBox8.Location = new System.Drawing.Point(414, 80);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(147, 52);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Güç Katsayısı";
            // 
            // katsayitipi
            // 
            this.katsayitipi.FormattingEnabled = true;
            this.katsayitipi.Items.AddRange(new object[] {
            "Endüktif",
            "Kapasitif"});
            this.katsayitipi.Location = new System.Drawing.Point(58, 22);
            this.katsayitipi.Name = "katsayitipi";
            this.katsayitipi.Size = new System.Drawing.Size(83, 21);
            this.katsayitipi.TabIndex = 20;
            // 
            // guckatsayisi
            // 
            this.guckatsayisi.Location = new System.Drawing.Point(6, 23);
            this.guckatsayisi.Name = "guckatsayisi";
            this.guckatsayisi.Size = new System.Drawing.Size(46, 20);
            this.guckatsayisi.TabIndex = 11;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.uzunhat_vr);
            this.groupBox9.Controls.Add(this.uzunhat_m);
            this.groupBox9.Controls.Add(this.ortauzunhat_vr);
            this.groupBox9.Controls.Add(this.ortauzunhat_m);
            this.groupBox9.Controls.Add(this.kisahat_vr);
            this.groupBox9.Controls.Add(this.kisahat_m);
            this.groupBox9.Controls.Add(this.uzunhat_q1);
            this.groupBox9.Controls.Add(this.uzunhat_p1);
            this.groupBox9.Controls.Add(this.ortauzunhat_q1);
            this.groupBox9.Controls.Add(this.ortauzunhat_p1);
            this.groupBox9.Controls.Add(this.kisahat_q1);
            this.groupBox9.Controls.Add(this.kisahat_p1);
            this.groupBox9.Controls.Add(this.q2);
            this.groupBox9.Controls.Add(this.p2);
            this.groupBox9.Controls.Add(this.uzunhat_i1);
            this.groupBox9.Controls.Add(this.uzunhat_u1);
            this.groupBox9.Controls.Add(this.ortauzunhat_i1);
            this.groupBox9.Controls.Add(this.ortauzunhat_u1);
            this.groupBox9.Controls.Add(this.kisahat_i1);
            this.groupBox9.Controls.Add(this.kisahat_u1);
            this.groupBox9.Controls.Add(this.i2);
            this.groupBox9.Controls.Add(this.u2);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.uzunhat_a);
            this.groupBox9.Controls.Add(this.uzunhat_b);
            this.groupBox9.Controls.Add(this.uzunhat_c);
            this.groupBox9.Controls.Add(this.uzunhat_d);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.ortauzunhatt_c);
            this.groupBox9.Controls.Add(this.ortauzunhatt_b);
            this.groupBox9.Controls.Add(this.ortauzunhatt_d);
            this.groupBox9.Controls.Add(this.ortauzunhatt_a);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Controls.Add(this.ortauzunhat_c);
            this.groupBox9.Controls.Add(this.ortauzunhat_b);
            this.groupBox9.Controls.Add(this.ortauzunhat_d);
            this.groupBox9.Controls.Add(this.ortauzunhat_a);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.kisahat_c);
            this.groupBox9.Controls.Add(this.kisahat_a);
            this.groupBox9.Controls.Add(this.kisahat_d);
            this.groupBox9.Controls.Add(this.kisahat_b);
            this.groupBox9.Controls.Add(this.kc);
            this.groupBox9.Controls.Add(this.kl);
            this.groupBox9.Location = new System.Drawing.Point(12, 145);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1132, 270);
            this.groupBox9.TabIndex = 41;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // uzunhat_vr
            // 
            this.uzunhat_vr.AutoSize = true;
            this.uzunhat_vr.Location = new System.Drawing.Point(699, 227);
            this.uzunhat_vr.Name = "uzunhat_vr";
            this.uzunhat_vr.Size = new System.Drawing.Size(30, 13);
            this.uzunhat_vr.TabIndex = 58;
            this.uzunhat_vr.Text = "%VR";
            // 
            // uzunhat_m
            // 
            this.uzunhat_m.AutoSize = true;
            this.uzunhat_m.Location = new System.Drawing.Point(699, 197);
            this.uzunhat_m.Name = "uzunhat_m";
            this.uzunhat_m.Size = new System.Drawing.Size(24, 13);
            this.uzunhat_m.TabIndex = 57;
            this.uzunhat_m.Text = "%M";
            // 
            // ortauzunhat_vr
            // 
            this.ortauzunhat_vr.AutoSize = true;
            this.ortauzunhat_vr.Location = new System.Drawing.Point(699, 157);
            this.ortauzunhat_vr.Name = "ortauzunhat_vr";
            this.ortauzunhat_vr.Size = new System.Drawing.Size(30, 13);
            this.ortauzunhat_vr.TabIndex = 56;
            this.ortauzunhat_vr.Text = "%VR";
            // 
            // ortauzunhat_m
            // 
            this.ortauzunhat_m.AutoSize = true;
            this.ortauzunhat_m.Location = new System.Drawing.Point(699, 127);
            this.ortauzunhat_m.Name = "ortauzunhat_m";
            this.ortauzunhat_m.Size = new System.Drawing.Size(24, 13);
            this.ortauzunhat_m.TabIndex = 55;
            this.ortauzunhat_m.Text = "%M";
            // 
            // kisahat_vr
            // 
            this.kisahat_vr.AutoSize = true;
            this.kisahat_vr.Location = new System.Drawing.Point(699, 88);
            this.kisahat_vr.Name = "kisahat_vr";
            this.kisahat_vr.Size = new System.Drawing.Size(30, 13);
            this.kisahat_vr.TabIndex = 54;
            this.kisahat_vr.Text = "%VR";
            // 
            // kisahat_m
            // 
            this.kisahat_m.AutoSize = true;
            this.kisahat_m.Location = new System.Drawing.Point(699, 58);
            this.kisahat_m.Name = "kisahat_m";
            this.kisahat_m.Size = new System.Drawing.Size(24, 13);
            this.kisahat_m.TabIndex = 53;
            this.kisahat_m.Text = "%M";
            // 
            // uzunhat_q1
            // 
            this.uzunhat_q1.AutoSize = true;
            this.uzunhat_q1.Location = new System.Drawing.Point(482, 227);
            this.uzunhat_q1.Name = "uzunhat_q1";
            this.uzunhat_q1.Size = new System.Drawing.Size(21, 13);
            this.uzunhat_q1.TabIndex = 52;
            this.uzunhat_q1.Text = "Q1";
            // 
            // uzunhat_p1
            // 
            this.uzunhat_p1.AutoSize = true;
            this.uzunhat_p1.Location = new System.Drawing.Point(482, 197);
            this.uzunhat_p1.Name = "uzunhat_p1";
            this.uzunhat_p1.Size = new System.Drawing.Size(20, 13);
            this.uzunhat_p1.TabIndex = 51;
            this.uzunhat_p1.Text = "P1";
            // 
            // ortauzunhat_q1
            // 
            this.ortauzunhat_q1.AutoSize = true;
            this.ortauzunhat_q1.Location = new System.Drawing.Point(482, 154);
            this.ortauzunhat_q1.Name = "ortauzunhat_q1";
            this.ortauzunhat_q1.Size = new System.Drawing.Size(21, 13);
            this.ortauzunhat_q1.TabIndex = 50;
            this.ortauzunhat_q1.Text = "Q1";
            // 
            // ortauzunhat_p1
            // 
            this.ortauzunhat_p1.AutoSize = true;
            this.ortauzunhat_p1.Location = new System.Drawing.Point(482, 124);
            this.ortauzunhat_p1.Name = "ortauzunhat_p1";
            this.ortauzunhat_p1.Size = new System.Drawing.Size(20, 13);
            this.ortauzunhat_p1.TabIndex = 49;
            this.ortauzunhat_p1.Text = "P1";
            // 
            // kisahat_q1
            // 
            this.kisahat_q1.AutoSize = true;
            this.kisahat_q1.Location = new System.Drawing.Point(482, 88);
            this.kisahat_q1.Name = "kisahat_q1";
            this.kisahat_q1.Size = new System.Drawing.Size(21, 13);
            this.kisahat_q1.TabIndex = 48;
            this.kisahat_q1.Text = "Q1";
            // 
            // kisahat_p1
            // 
            this.kisahat_p1.AutoSize = true;
            this.kisahat_p1.Location = new System.Drawing.Point(482, 58);
            this.kisahat_p1.Name = "kisahat_p1";
            this.kisahat_p1.Size = new System.Drawing.Size(20, 13);
            this.kisahat_p1.TabIndex = 47;
            this.kisahat_p1.Text = "P1";
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Location = new System.Drawing.Point(846, 22);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(21, 13);
            this.q2.TabIndex = 46;
            this.q2.Text = "Q2";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(580, 22);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(20, 13);
            this.p2.TabIndex = 45;
            this.p2.Text = "P2";
            // 
            // uzunhat_i1
            // 
            this.uzunhat_i1.AutoSize = true;
            this.uzunhat_i1.Location = new System.Drawing.Point(267, 227);
            this.uzunhat_i1.Name = "uzunhat_i1";
            this.uzunhat_i1.Size = new System.Drawing.Size(16, 13);
            this.uzunhat_i1.TabIndex = 44;
            this.uzunhat_i1.Text = "I1";
            // 
            // uzunhat_u1
            // 
            this.uzunhat_u1.AutoSize = true;
            this.uzunhat_u1.Location = new System.Drawing.Point(267, 197);
            this.uzunhat_u1.Name = "uzunhat_u1";
            this.uzunhat_u1.Size = new System.Drawing.Size(21, 13);
            this.uzunhat_u1.TabIndex = 43;
            this.uzunhat_u1.Text = "U1";
            // 
            // ortauzunhat_i1
            // 
            this.ortauzunhat_i1.AutoSize = true;
            this.ortauzunhat_i1.Location = new System.Drawing.Point(267, 154);
            this.ortauzunhat_i1.Name = "ortauzunhat_i1";
            this.ortauzunhat_i1.Size = new System.Drawing.Size(16, 13);
            this.ortauzunhat_i1.TabIndex = 42;
            this.ortauzunhat_i1.Text = "I1";
            // 
            // ortauzunhat_u1
            // 
            this.ortauzunhat_u1.AutoSize = true;
            this.ortauzunhat_u1.Location = new System.Drawing.Point(267, 124);
            this.ortauzunhat_u1.Name = "ortauzunhat_u1";
            this.ortauzunhat_u1.Size = new System.Drawing.Size(21, 13);
            this.ortauzunhat_u1.TabIndex = 41;
            this.ortauzunhat_u1.Text = "U1";
            // 
            // kisahat_i1
            // 
            this.kisahat_i1.AutoSize = true;
            this.kisahat_i1.Location = new System.Drawing.Point(267, 88);
            this.kisahat_i1.Name = "kisahat_i1";
            this.kisahat_i1.Size = new System.Drawing.Size(16, 13);
            this.kisahat_i1.TabIndex = 40;
            this.kisahat_i1.Text = "I1";
            // 
            // kisahat_u1
            // 
            this.kisahat_u1.AutoSize = true;
            this.kisahat_u1.Location = new System.Drawing.Point(267, 58);
            this.kisahat_u1.Name = "kisahat_u1";
            this.kisahat_u1.Size = new System.Drawing.Size(21, 13);
            this.kisahat_u1.TabIndex = 39;
            this.kisahat_u1.Text = "U1";
            // 
            // i2
            // 
            this.i2.AutoSize = true;
            this.i2.Location = new System.Drawing.Point(380, 22);
            this.i2.Name = "i2";
            this.i2.Size = new System.Drawing.Size(16, 13);
            this.i2.TabIndex = 38;
            this.i2.Text = "I2";
            // 
            // u2
            // 
            this.u2.AutoSize = true;
            this.u2.Location = new System.Drawing.Point(222, 22);
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(21, 13);
            this.u2.TabIndex = 37;
            this.u2.Text = "U2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 207);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Uzun Hat = ";
            // 
            // uzunhat_a
            // 
            this.uzunhat_a.AutoSize = true;
            this.uzunhat_a.Location = new System.Drawing.Point(122, 197);
            this.uzunhat_a.Name = "uzunhat_a";
            this.uzunhat_a.Size = new System.Drawing.Size(14, 13);
            this.uzunhat_a.TabIndex = 35;
            this.uzunhat_a.Text = "A";
            // 
            // uzunhat_b
            // 
            this.uzunhat_b.AutoSize = true;
            this.uzunhat_b.Location = new System.Drawing.Point(181, 197);
            this.uzunhat_b.Name = "uzunhat_b";
            this.uzunhat_b.Size = new System.Drawing.Size(14, 13);
            this.uzunhat_b.TabIndex = 34;
            this.uzunhat_b.Text = "B";
            // 
            // uzunhat_c
            // 
            this.uzunhat_c.AutoSize = true;
            this.uzunhat_c.Location = new System.Drawing.Point(122, 220);
            this.uzunhat_c.Name = "uzunhat_c";
            this.uzunhat_c.Size = new System.Drawing.Size(14, 13);
            this.uzunhat_c.TabIndex = 33;
            this.uzunhat_c.Text = "C";
            // 
            // uzunhat_d
            // 
            this.uzunhat_d.AutoSize = true;
            this.uzunhat_d.Location = new System.Drawing.Point(181, 220);
            this.uzunhat_d.Name = "uzunhat_d";
            this.uzunhat_d.Size = new System.Drawing.Size(15, 13);
            this.uzunhat_d.TabIndex = 32;
            this.uzunhat_d.Text = "D";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(865, 137);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "Orta Uzun Hat(T) = ";
            // 
            // ortauzunhatt_c
            // 
            this.ortauzunhatt_c.AutoSize = true;
            this.ortauzunhatt_c.Location = new System.Drawing.Point(974, 150);
            this.ortauzunhatt_c.Name = "ortauzunhatt_c";
            this.ortauzunhatt_c.Size = new System.Drawing.Size(14, 13);
            this.ortauzunhatt_c.TabIndex = 30;
            this.ortauzunhatt_c.Text = "C";
            // 
            // ortauzunhatt_b
            // 
            this.ortauzunhatt_b.AutoSize = true;
            this.ortauzunhatt_b.Location = new System.Drawing.Point(1046, 127);
            this.ortauzunhatt_b.Name = "ortauzunhatt_b";
            this.ortauzunhatt_b.Size = new System.Drawing.Size(14, 13);
            this.ortauzunhatt_b.TabIndex = 29;
            this.ortauzunhatt_b.Text = "B";
            // 
            // ortauzunhatt_d
            // 
            this.ortauzunhatt_d.AutoSize = true;
            this.ortauzunhatt_d.Location = new System.Drawing.Point(1046, 150);
            this.ortauzunhatt_d.Name = "ortauzunhatt_d";
            this.ortauzunhatt_d.Size = new System.Drawing.Size(15, 13);
            this.ortauzunhatt_d.TabIndex = 28;
            this.ortauzunhatt_d.Text = "D";
            // 
            // ortauzunhatt_a
            // 
            this.ortauzunhatt_a.AutoSize = true;
            this.ortauzunhatt_a.Location = new System.Drawing.Point(974, 127);
            this.ortauzunhatt_a.Name = "ortauzunhatt_a";
            this.ortauzunhatt_a.Size = new System.Drawing.Size(14, 13);
            this.ortauzunhatt_a.TabIndex = 27;
            this.ortauzunhatt_a.Text = "A";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(13, 137);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(103, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "Orta Uzun Hat(PI) = ";
            // 
            // ortauzunhat_c
            // 
            this.ortauzunhat_c.AutoSize = true;
            this.ortauzunhat_c.Location = new System.Drawing.Point(122, 150);
            this.ortauzunhat_c.Name = "ortauzunhat_c";
            this.ortauzunhat_c.Size = new System.Drawing.Size(14, 13);
            this.ortauzunhat_c.TabIndex = 25;
            this.ortauzunhat_c.Text = "C";
            // 
            // ortauzunhat_b
            // 
            this.ortauzunhat_b.AutoSize = true;
            this.ortauzunhat_b.Location = new System.Drawing.Point(181, 127);
            this.ortauzunhat_b.Name = "ortauzunhat_b";
            this.ortauzunhat_b.Size = new System.Drawing.Size(14, 13);
            this.ortauzunhat_b.TabIndex = 24;
            this.ortauzunhat_b.Text = "B";
            // 
            // ortauzunhat_d
            // 
            this.ortauzunhat_d.AutoSize = true;
            this.ortauzunhat_d.Location = new System.Drawing.Point(181, 150);
            this.ortauzunhat_d.Name = "ortauzunhat_d";
            this.ortauzunhat_d.Size = new System.Drawing.Size(15, 13);
            this.ortauzunhat_d.TabIndex = 23;
            this.ortauzunhat_d.Text = "D";
            // 
            // ortauzunhat_a
            // 
            this.ortauzunhat_a.AutoSize = true;
            this.ortauzunhat_a.Location = new System.Drawing.Point(122, 127);
            this.ortauzunhat_a.Name = "ortauzunhat_a";
            this.ortauzunhat_a.Size = new System.Drawing.Size(14, 13);
            this.ortauzunhat_a.TabIndex = 22;
            this.ortauzunhat_a.Text = "A";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(13, 73);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(59, 13);
            this.label42.TabIndex = 21;
            this.label42.Text = "Kısa Hat = ";
            // 
            // kisahat_c
            // 
            this.kisahat_c.AutoSize = true;
            this.kisahat_c.Location = new System.Drawing.Point(122, 88);
            this.kisahat_c.Name = "kisahat_c";
            this.kisahat_c.Size = new System.Drawing.Size(14, 13);
            this.kisahat_c.TabIndex = 20;
            this.kisahat_c.Text = "C";
            // 
            // kisahat_a
            // 
            this.kisahat_a.AutoSize = true;
            this.kisahat_a.Location = new System.Drawing.Point(122, 58);
            this.kisahat_a.Name = "kisahat_a";
            this.kisahat_a.Size = new System.Drawing.Size(14, 13);
            this.kisahat_a.TabIndex = 19;
            this.kisahat_a.Text = "A";
            // 
            // kisahat_d
            // 
            this.kisahat_d.AutoSize = true;
            this.kisahat_d.Location = new System.Drawing.Point(181, 88);
            this.kisahat_d.Name = "kisahat_d";
            this.kisahat_d.Size = new System.Drawing.Size(15, 13);
            this.kisahat_d.TabIndex = 18;
            this.kisahat_d.Text = "D";
            // 
            // kisahat_b
            // 
            this.kisahat_b.AutoSize = true;
            this.kisahat_b.Location = new System.Drawing.Point(181, 58);
            this.kisahat_b.Name = "kisahat_b";
            this.kisahat_b.Size = new System.Drawing.Size(14, 13);
            this.kisahat_b.TabIndex = 17;
            this.kisahat_b.Text = "B";
            // 
            // kc
            // 
            this.kc.AutoSize = true;
            this.kc.Location = new System.Drawing.Point(104, 22);
            this.kc.Name = "kc";
            this.kc.Size = new System.Drawing.Size(14, 13);
            this.kc.TabIndex = 15;
            this.kc.Text = "C";
            // 
            // kl
            // 
            this.kl.AutoSize = true;
            this.kl.Location = new System.Drawing.Point(13, 22);
            this.kl.Name = "kl";
            this.kl.Size = new System.Drawing.Size(13, 13);
            this.kl.TabIndex = 16;
            this.kl.Text = "L";
            // 
            // iletimhatuzunlugu
            // 
            this.iletimhatuzunlugu.AutoSize = true;
            this.iletimhatuzunlugu.Location = new System.Drawing.Point(832, 48);
            this.iletimhatuzunlugu.Name = "iletimhatuzunlugu";
            this.iletimhatuzunlugu.Size = new System.Drawing.Size(110, 13);
            this.iletimhatuzunlugu.TabIndex = 47;
            this.iletimhatuzunlugu.Text = "İletim Hattı Uzunluğu: ";
            // 
            // hatsonugerililmi1
            // 
            this.hatsonugerililmi1.AutoSize = true;
            this.hatsonugerililmi1.Location = new System.Drawing.Point(832, 102);
            this.hatsonugerililmi1.Name = "hatsonugerililmi1";
            this.hatsonugerililmi1.Size = new System.Drawing.Size(26, 13);
            this.hatsonugerililmi1.TabIndex = 48;
            this.hatsonugerililmi1.Text = "S2: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 427);
            this.Controls.Add(this.hatsonugerililmi1);
            this.Controls.Add(this.iletimhatuzunlugu);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.v);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox iletkenTipi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dortDemet;
        private System.Windows.Forms.RadioButton ucDemet;
        private System.Windows.Forms.RadioButton ciftDemet;
        private System.Windows.Forms.RadioButton tekDemet;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox dau;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox direkTipi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox uzunluk;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox hatsonugerilimi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox guckatsayisi;
        private System.Windows.Forms.ComboBox katsayitipi;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label uzunhat_vr;
        private System.Windows.Forms.Label uzunhat_m;
        private System.Windows.Forms.Label ortauzunhat_vr;
        private System.Windows.Forms.Label ortauzunhat_m;
        private System.Windows.Forms.Label kisahat_vr;
        private System.Windows.Forms.Label kisahat_m;
        private System.Windows.Forms.Label uzunhat_q1;
        private System.Windows.Forms.Label uzunhat_p1;
        private System.Windows.Forms.Label ortauzunhat_q1;
        private System.Windows.Forms.Label ortauzunhat_p1;
        private System.Windows.Forms.Label kisahat_q1;
        private System.Windows.Forms.Label kisahat_p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label uzunhat_i1;
        private System.Windows.Forms.Label uzunhat_u1;
        private System.Windows.Forms.Label ortauzunhat_i1;
        private System.Windows.Forms.Label ortauzunhat_u1;
        private System.Windows.Forms.Label kisahat_i1;
        private System.Windows.Forms.Label kisahat_u1;
        private System.Windows.Forms.Label i2;
        private System.Windows.Forms.Label u2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label uzunhat_a;
        private System.Windows.Forms.Label uzunhat_b;
        private System.Windows.Forms.Label uzunhat_c;
        private System.Windows.Forms.Label uzunhat_d;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label ortauzunhatt_c;
        private System.Windows.Forms.Label ortauzunhatt_b;
        private System.Windows.Forms.Label ortauzunhatt_d;
        private System.Windows.Forms.Label ortauzunhatt_a;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label ortauzunhat_c;
        private System.Windows.Forms.Label ortauzunhat_b;
        private System.Windows.Forms.Label ortauzunhat_d;
        private System.Windows.Forms.Label ortauzunhat_a;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label kisahat_c;
        private System.Windows.Forms.Label kisahat_a;
        private System.Windows.Forms.Label kisahat_d;
        private System.Windows.Forms.Label kisahat_b;
        private System.Windows.Forms.Label kc;
        private System.Windows.Forms.Label kl;
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.ComboBox uzunlukyuzde;
        private System.Windows.Forms.ComboBox s2katsayisi;
        private System.Windows.Forms.Label iletimhatuzunlugu;
        private System.Windows.Forms.Label hatsonugerililmi1;
    }
}


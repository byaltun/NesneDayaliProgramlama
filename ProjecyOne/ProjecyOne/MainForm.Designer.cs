namespace ProjecyOne
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ögrenciToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.öğrenciDersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Okul Yönetim Sistemine Hoşgeldiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjecyOne.Properties.Resources.zyro_image__3_;
            this.pictureBox1.Location = new System.Drawing.Point(205, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 313);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_folder_50;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_close_window_50;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ögrenciToolStripMenuItem
            // 
            this.ögrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem1,
            this.öğrenciListeleToolStripMenuItem1});
            this.ögrenciToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_student_64;
            this.ögrenciToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ögrenciToolStripMenuItem.Name = "ögrenciToolStripMenuItem";
            this.ögrenciToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.ögrenciToolStripMenuItem.Text = "Ögrenci";
            this.ögrenciToolStripMenuItem.Click += new System.EventHandler(this.ögrenciToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem1
            // 
            this.öğrenciToolStripMenuItem1.Image = global::ProjecyOne.Properties.Resources.icons8_student_64;
            this.öğrenciToolStripMenuItem1.Name = "öğrenciToolStripMenuItem1";
            this.öğrenciToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.öğrenciToolStripMenuItem1.Text = "Öğrenci";
            this.öğrenciToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciToolStripMenuItem1_Click);
            // 
            // öğrenciListeleToolStripMenuItem1
            // 
            this.öğrenciListeleToolStripMenuItem1.Image = global::ProjecyOne.Properties.Resources.icons8_bullet_list_50;
            this.öğrenciListeleToolStripMenuItem1.Name = "öğrenciListeleToolStripMenuItem1";
            this.öğrenciListeleToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.öğrenciListeleToolStripMenuItem1.Text = "Öğrenci Listele";
            this.öğrenciListeleToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem1_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersToolStripMenuItem1,
            this.dersListeleToolStripMenuItem});
            this.dersToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_lesson_64;
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.dersToolStripMenuItem.Text = "Ders";
            this.dersToolStripMenuItem.Click += new System.EventHandler(this.dersToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem1
            // 
            this.dersToolStripMenuItem1.Image = global::ProjecyOne.Properties.Resources.icons8_lesson_64;
            this.dersToolStripMenuItem1.Name = "dersToolStripMenuItem1";
            this.dersToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.dersToolStripMenuItem1.Text = "Ders";
            this.dersToolStripMenuItem1.Click += new System.EventHandler(this.dersToolStripMenuItem1_Click);
            // 
            // dersListeleToolStripMenuItem
            // 
            this.dersListeleToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_bullet_list_50;
            this.dersListeleToolStripMenuItem.Name = "dersListeleToolStripMenuItem";
            this.dersListeleToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.dersListeleToolStripMenuItem.Text = "Ders Listele";
            this.dersListeleToolStripMenuItem.Click += new System.EventHandler(this.dersListeleToolStripMenuItem_Click);
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetimToolStripMenuItem1,
            this.yönetimListeleToolStripMenuItem});
            this.yönetimToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_microsoft_admin_48;
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            this.yönetimToolStripMenuItem.Click += new System.EventHandler(this.yönetimToolStripMenuItem_Click);
            // 
            // yönetimToolStripMenuItem1
            // 
            this.yönetimToolStripMenuItem1.Image = global::ProjecyOne.Properties.Resources.icons8_microsoft_admin_48;
            this.yönetimToolStripMenuItem1.Name = "yönetimToolStripMenuItem1";
            this.yönetimToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.yönetimToolStripMenuItem1.Text = "Yönetim";
            this.yönetimToolStripMenuItem1.Click += new System.EventHandler(this.yönetimToolStripMenuItem1_Click);
            // 
            // yönetimListeleToolStripMenuItem
            // 
            this.yönetimListeleToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_bullet_list_50;
            this.yönetimListeleToolStripMenuItem.Name = "yönetimListeleToolStripMenuItem";
            this.yönetimListeleToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.yönetimListeleToolStripMenuItem.Text = "Yönetim Listele";
            this.yönetimListeleToolStripMenuItem.Click += new System.EventHandler(this.yönetimListeleToolStripMenuItem_Click);
            // 
            // öğrenciDersToolStripMenuItem
            // 
            this.öğrenciDersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.öğrenciListeleToolStripMenuItem});
            this.öğrenciDersToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_teacher_50;
            this.öğrenciDersToolStripMenuItem.Name = "öğrenciDersToolStripMenuItem";
            this.öğrenciDersToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.öğrenciDersToolStripMenuItem.Text = "Öğrenci Ders";
            this.öğrenciDersToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.öğrenciDersToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDersToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_teacher_50;
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            this.öğrenciToolStripMenuItem.Click += new System.EventHandler(this.öğrenciToolStripMenuItem_Click);
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            this.öğrenciListeleToolStripMenuItem.Image = global::ProjecyOne.Properties.Resources.icons8_bullet_list_50;
            this.öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            this.öğrenciListeleToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.öğrenciListeleToolStripMenuItem.Text = "Öğrenci Listele";
            this.öğrenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(257, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to the School Management System.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yönetimListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
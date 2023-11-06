namespace SmartEye2
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.BtnWindowMax = new System.Windows.Forms.PictureBox();
            this.BtnWindowLow = new System.Windows.Forms.PictureBox();
            this.BtnWindowHide = new System.Windows.Forms.PictureBox();
            this.BtnWindowExit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFırma = new System.Windows.Forms.Button();
            this.BtnMakina = new System.Windows.Forms.Button();
            this.BtnVardiya = new System.Windows.Forms.Button();
            this.BtnIP = new System.Windows.Forms.Button();
            this.BtnKullanıcı = new System.Windows.Forms.Button();
            this.BtnAlanDuz = new System.Windows.Forms.Button();
            this.BtnAlanIs = new System.Windows.Forms.Button();
            this.seDropDownMenu1 = new FromControls.SEDropDownMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowExit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.seDropDownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.PanelTitleBar.Controls.Add(this.BtnWindowMax);
            this.PanelTitleBar.Controls.Add(this.BtnWindowLow);
            this.PanelTitleBar.Controls.Add(this.BtnWindowHide);
            this.PanelTitleBar.Controls.Add(this.BtnWindowExit);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(1280, 38);
            this.PanelTitleBar.TabIndex = 5;
            this.PanelTitleBar.Resize += new System.EventHandler(this.PanelTitleBar_Resize_1);
            // 
            // BtnWindowMax
            // 
            this.BtnWindowMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowMax.Image")));
            this.BtnWindowMax.Location = new System.Drawing.Point(1228, 8);
            this.BtnWindowMax.Margin = new System.Windows.Forms.Padding(2);
            this.BtnWindowMax.Name = "BtnWindowMax";
            this.BtnWindowMax.Size = new System.Drawing.Size(20, 19);
            this.BtnWindowMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnWindowMax.TabIndex = 2;
            this.BtnWindowMax.TabStop = false;
            // 
            // BtnWindowLow
            // 
            this.BtnWindowLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowLow.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowLow.Image")));
            this.BtnWindowLow.Location = new System.Drawing.Point(1228, 8);
            this.BtnWindowLow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnWindowLow.Name = "BtnWindowLow";
            this.BtnWindowLow.Size = new System.Drawing.Size(20, 19);
            this.BtnWindowLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnWindowLow.TabIndex = 1;
            this.BtnWindowLow.TabStop = false;
            this.BtnWindowLow.Visible = false;
            // 
            // BtnWindowHide
            // 
            this.BtnWindowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowHide.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowHide.Image")));
            this.BtnWindowHide.Location = new System.Drawing.Point(1201, 8);
            this.BtnWindowHide.Margin = new System.Windows.Forms.Padding(2);
            this.BtnWindowHide.Name = "BtnWindowHide";
            this.BtnWindowHide.Size = new System.Drawing.Size(21, 19);
            this.BtnWindowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnWindowHide.TabIndex = 0;
            this.BtnWindowHide.TabStop = false;
            // 
            // BtnWindowExit
            // 
            this.BtnWindowExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWindowExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowExit.Image")));
            this.BtnWindowExit.Location = new System.Drawing.Point(1254, 8);
            this.BtnWindowExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnWindowExit.Name = "BtnWindowExit";
            this.BtnWindowExit.Size = new System.Drawing.Size(20, 19);
            this.BtnWindowExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnWindowExit.TabIndex = 0;
            this.BtnWindowExit.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BtnFırma, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnMakina, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnVardiya, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnIP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnKullanıcı, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnAlanDuz, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAlanIs, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 742);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BtnFırma
            // 
            this.BtnFırma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnFırma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFırma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFırma.Image = global::SmartEye2.Properties.Resources.factory;
            this.BtnFırma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFırma.Location = new System.Drawing.Point(927, 575);
            this.BtnFırma.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnFırma.Name = "BtnFırma";
            this.BtnFırma.Size = new System.Drawing.Size(278, 86);
            this.BtnFırma.TabIndex = 9;
            this.BtnFırma.Text = "  Firma Bilgi Güncelle";
            this.BtnFırma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFırma.UseVisualStyleBackColor = false;
            // 
            // BtnMakina
            // 
            this.BtnMakina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnMakina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMakina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMakina.Image = global::SmartEye2.Properties.Resources.backup;
            this.BtnMakina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMakina.Location = new System.Drawing.Point(75, 575);
            this.BtnMakina.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnMakina.Name = "BtnMakina";
            this.BtnMakina.Size = new System.Drawing.Size(276, 86);
            this.BtnMakina.TabIndex = 6;
            this.BtnMakina.Text = "  Makina Yedekleme";
            this.BtnMakina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMakina.UseVisualStyleBackColor = false;
            // 
            // BtnVardiya
            // 
            this.BtnVardiya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnVardiya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVardiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVardiya.Image = global::SmartEye2.Properties.Resources.shift;
            this.BtnVardiya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVardiya.Location = new System.Drawing.Point(927, 328);
            this.BtnVardiya.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnVardiya.Name = "BtnVardiya";
            this.BtnVardiya.Size = new System.Drawing.Size(278, 85);
            this.BtnVardiya.TabIndex = 5;
            this.BtnVardiya.Text = "Vardiya/Birim Güncelle";
            this.BtnVardiya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVardiya.UseVisualStyleBackColor = false;
            // 
            // BtnIP
            // 
            this.BtnIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIP.Image = global::SmartEye2.Properties.Resources.ip;
            this.BtnIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIP.Location = new System.Drawing.Point(501, 328);
            this.BtnIP.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnIP.Name = "BtnIP";
            this.BtnIP.Size = new System.Drawing.Size(276, 85);
            this.BtnIP.TabIndex = 4;
            this.BtnIP.Text = "       IP Tarama";
            this.BtnIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIP.UseVisualStyleBackColor = false;
            // 
            // BtnKullanıcı
            // 
            this.BtnKullanıcı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnKullanıcı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKullanıcı.Image = global::SmartEye2.Properties.Resources.profile;
            this.BtnKullanıcı.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKullanıcı.Location = new System.Drawing.Point(75, 328);
            this.BtnKullanıcı.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnKullanıcı.Name = "BtnKullanıcı";
            this.BtnKullanıcı.Size = new System.Drawing.Size(276, 85);
            this.BtnKullanıcı.TabIndex = 3;
            this.BtnKullanıcı.Text = "  Kullanıcı Tanımla";
            this.BtnKullanıcı.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKullanıcı.UseVisualStyleBackColor = false;
            // 
            // BtnAlanDuz
            // 
            this.BtnAlanDuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnAlanDuz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAlanDuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlanDuz.Image = global::SmartEye2.Properties.Resources.handwriting;
            this.BtnAlanDuz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlanDuz.Location = new System.Drawing.Point(75, 81);
            this.BtnAlanDuz.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnAlanDuz.Name = "BtnAlanDuz";
            this.BtnAlanDuz.Size = new System.Drawing.Size(276, 85);
            this.BtnAlanDuz.TabIndex = 0;
            this.BtnAlanDuz.Text = "      Alan Düzenle";
            this.BtnAlanDuz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlanDuz.UseVisualStyleBackColor = false;
            this.BtnAlanDuz.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAlanIs
            // 
            this.BtnAlanIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.BtnAlanIs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAlanIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlanIs.Image = global::SmartEye2.Properties.Resources.plus;
            this.BtnAlanIs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlanIs.Location = new System.Drawing.Point(927, 81);
            this.BtnAlanIs.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
            this.BtnAlanIs.Name = "BtnAlanIs";
            this.BtnAlanIs.Size = new System.Drawing.Size(278, 85);
            this.BtnAlanIs.TabIndex = 2;
            this.BtnAlanIs.Text = "    Alan İşlemleri";
            this.BtnAlanIs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlanIs.UseVisualStyleBackColor = false;
            // 
            // seDropDownMenu1
            // 
            this.seDropDownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.seDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.seDropDownMenu1.Name = "seDropDownMenu1";
            this.seDropDownMenu1.Size = new System.Drawing.Size(179, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem1.Text = "Final";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem2.Text = "Üretim";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem3.Text = "Arge Test Alanı";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PanelTitleBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1114, 777);
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWindowExit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.seDropDownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.PictureBox BtnWindowMax;
        private System.Windows.Forms.PictureBox BtnWindowLow;
        private System.Windows.Forms.PictureBox BtnWindowHide;
        private System.Windows.Forms.PictureBox BtnWindowExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAlanDuz;
        private System.Windows.Forms.Button BtnFırma;
        private System.Windows.Forms.Button BtnMakina;
        private System.Windows.Forms.Button BtnVardiya;
        private System.Windows.Forms.Button BtnIP;
        private System.Windows.Forms.Button BtnKullanıcı;
        private System.Windows.Forms.Button BtnAlanIs;
        private FromControls.SEDropDownMenu seDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
namespace TwoQ
{
    partial class frmReferencia2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReferencia2));
            this.ll_ref01 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ll_ref02 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ll_ref04 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ll_ref03 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ll_ref05 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_pg_anterior = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ll_ref07 = new System.Windows.Forms.LinkLabel();
            this.ll_ref06 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pg_anterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ll_ref01
            // 
            this.ll_ref01.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref01.AutoSize = true;
            this.ll_ref01.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref01.ForeColor = System.Drawing.Color.White;
            this.ll_ref01.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref01.LinkColor = System.Drawing.Color.White;
            this.ll_ref01.Location = new System.Drawing.Point(96, 160);
            this.ll_ref01.Name = "ll_ref01";
            this.ll_ref01.Size = new System.Drawing.Size(251, 40);
            this.ll_ref01.TabIndex = 8;
            this.ll_ref01.TabStop = true;
            this.ll_ref01.Text = "https://www.einstein.br";
            this.ll_ref01.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref01_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hospital Israelita Albert Einstein";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TwoQ.Properties.Resources.Referencias_Pesquisadas;
            this.pictureBox1.Location = new System.Drawing.Point(86, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 63);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 85);
            this.panel1.TabIndex = 17;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.Location = new System.Drawing.Point(6, 25);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(54, 55);
            this.btn_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar para página inicial");
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            this.btn_voltar.MouseEnter += new System.EventHandler(this.btn_voltar_MouseEnter);
            this.btn_voltar.MouseLeave += new System.EventHandler(this.btn_voltar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 100);
            this.panel2.TabIndex = 18;
            // 
            // ll_ref02
            // 
            this.ll_ref02.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref02.AutoSize = true;
            this.ll_ref02.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref02.ForeColor = System.Drawing.Color.White;
            this.ll_ref02.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref02.LinkColor = System.Drawing.Color.White;
            this.ll_ref02.Location = new System.Drawing.Point(96, 241);
            this.ll_ref02.Name = "ll_ref02";
            this.ll_ref02.Size = new System.Drawing.Size(317, 40);
            this.ll_ref02.TabIndex = 20;
            this.ll_ref02.TabStop = true;
            this.ll_ref02.Text = "http://www.hiperbarica.med.br";
            this.ll_ref02.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref02_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Instituto de Medicina Hiperbárica";
            // 
            // ll_ref04
            // 
            this.ll_ref04.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref04.AutoSize = true;
            this.ll_ref04.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref04.ForeColor = System.Drawing.Color.White;
            this.ll_ref04.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref04.LinkColor = System.Drawing.Color.White;
            this.ll_ref04.Location = new System.Drawing.Point(96, 403);
            this.ll_ref04.Name = "ll_ref04";
            this.ll_ref04.Size = new System.Drawing.Size(420, 40);
            this.ll_ref04.TabIndex = 24;
            this.ll_ref04.TabStop = true;
            this.ll_ref04.Text = "http://www.pensaracademico.facig.edu.br";
            this.ll_ref04.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref04_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 40);
            this.label2.TabIndex = 23;
            this.label2.Text = "O Paciente Queimado";
            // 
            // ll_ref03
            // 
            this.ll_ref03.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref03.AutoSize = true;
            this.ll_ref03.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref03.ForeColor = System.Drawing.Color.White;
            this.ll_ref03.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref03.LinkColor = System.Drawing.Color.White;
            this.ll_ref03.Location = new System.Drawing.Point(96, 322);
            this.ll_ref03.Name = "ll_ref03";
            this.ll_ref03.Size = new System.Drawing.Size(277, 40);
            this.ll_ref03.TabIndex = 22;
            this.ll_ref03.TabStop = true;
            this.ll_ref03.Text = "https://www.fepecs.edu.br";
            this.ll_ref03.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref03_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 40);
            this.label3.TabIndex = 21;
            this.label3.Text = "Manual de Queimaduras para Estudantes";
            // 
            // ll_ref05
            // 
            this.ll_ref05.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref05.AutoSize = true;
            this.ll_ref05.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref05.ForeColor = System.Drawing.Color.White;
            this.ll_ref05.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref05.LinkColor = System.Drawing.Color.White;
            this.ll_ref05.Location = new System.Drawing.Point(96, 484);
            this.ll_ref05.Name = "ll_ref05";
            this.ll_ref05.Size = new System.Drawing.Size(355, 40);
            this.ll_ref05.TabIndex = 26;
            this.ll_ref05.TabStop = true;
            this.ll_ref05.Text = "https://www.sbqueimaduras.org.br";
            this.ll_ref05.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref05_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 40);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sociedade Brasileira de Queimaduras";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_pg_anterior);
            this.panel3.Location = new System.Drawing.Point(921, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 69);
            this.panel3.TabIndex = 27;
            // 
            // btn_pg_anterior
            // 
            this.btn_pg_anterior.Location = new System.Drawing.Point(6, 8);
            this.btn_pg_anterior.Name = "btn_pg_anterior";
            this.btn_pg_anterior.Size = new System.Drawing.Size(54, 55);
            this.btn_pg_anterior.TabIndex = 28;
            this.btn_pg_anterior.TabStop = false;
            this.btn_pg_anterior.Click += new System.EventHandler(this.btn_pg_anterior_Click);
            this.btn_pg_anterior.MouseEnter += new System.EventHandler(this.btn_pg_anterior_MouseEnter);
            this.btn_pg_anterior.MouseLeave += new System.EventHandler(this.btn_pg_anterior_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TwoQ.Properties.Resources.Mascote_Referencia;
            this.pictureBox4.Location = new System.Drawing.Point(518, 167);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(478, 495);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 40);
            this.label6.TabIndex = 31;
            this.label6.Text = "NULL";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 40);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tua Saúde";
            // 
            // ll_ref07
            // 
            this.ll_ref07.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref07.AutoSize = true;
            this.ll_ref07.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref07.ForeColor = System.Drawing.Color.White;
            this.ll_ref07.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref07.LinkColor = System.Drawing.Color.White;
            this.ll_ref07.Location = new System.Drawing.Point(96, 646);
            this.ll_ref07.Name = "ll_ref07";
            this.ll_ref07.Size = new System.Drawing.Size(70, 40);
            this.ll_ref07.TabIndex = 32;
            this.ll_ref07.TabStop = true;
            this.ll_ref07.Text = "NULL";
            this.ll_ref07.Visible = false;
            this.ll_ref07.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref07_LinkClicked);
            // 
            // ll_ref06
            // 
            this.ll_ref06.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.ll_ref06.AutoSize = true;
            this.ll_ref06.Font = new System.Drawing.Font("K2D SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ll_ref06.ForeColor = System.Drawing.Color.White;
            this.ll_ref06.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_ref06.LinkColor = System.Drawing.Color.White;
            this.ll_ref06.Location = new System.Drawing.Point(96, 565);
            this.ll_ref06.Name = "ll_ref06";
            this.ll_ref06.Size = new System.Drawing.Size(278, 40);
            this.ll_ref06.TabIndex = 30;
            this.ll_ref06.TabStop = true;
            this.ll_ref06.Text = "https://www.tuasaude.com";
            this.ll_ref06.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ref06_LinkClicked);
            // 
            // frmReferencia2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ll_ref07);
            this.Controls.Add(this.ll_ref06);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ll_ref05);
            this.Controls.Add(this.ll_ref04);
            this.Controls.Add(this.ll_ref03);
            this.Controls.Add(this.ll_ref02);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ll_ref01);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReferencia2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TwoQ";
            this.Load += new System.EventHandler(this.frmReferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_pg_anterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel ll_ref01;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox btn_voltar;
        private Panel panel2;
        private ToolTip toolTip1;
        private LinkLabel ll_ref02;
        private Label label1;
        private LinkLabel ll_ref04;
        private Label label2;
        private LinkLabel ll_ref03;
        private Label label3;
        private LinkLabel ll_ref05;
        private Label label5;
        private Panel panel3;
        private PictureBox btn_pg_anterior;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label7;
        private LinkLabel ll_ref07;
        private LinkLabel ll_ref06;
    }
}
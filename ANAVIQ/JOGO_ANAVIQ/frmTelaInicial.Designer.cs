namespace TwoQ
{
    partial class frmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_referencias = new System.Windows.Forms.PictureBox();
            this.btn_sobre = new System.Windows.Forms.PictureBox();
            this.btn_jogar = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_referencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(252, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 310);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TwoQ.Properties.Resources.QUIZ;
            this.pictureBox1.Location = new System.Drawing.Point(70, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 121);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TwoQ.Properties.Resources.Teste_Seus_Conhecimentos;
            this.pictureBox2.Location = new System.Drawing.Point(125, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(739, 109);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_referencias);
            this.panel3.Controls.Add(this.btn_sobre);
            this.panel3.Controls.Add(this.btn_jogar);
            this.panel3.Location = new System.Drawing.Point(16, 593);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 100);
            this.panel3.TabIndex = 10;
            // 
            // btn_referencias
            // 
            this.btn_referencias.Location = new System.Drawing.Point(615, 32);
            this.btn_referencias.Name = "btn_referencias";
            this.btn_referencias.Size = new System.Drawing.Size(208, 68);
            this.btn_referencias.TabIndex = 2;
            this.btn_referencias.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_referencias, "Referências utilizadas");
            this.btn_referencias.Click += new System.EventHandler(this.btn_referencias_Click);
            this.btn_referencias.MouseEnter += new System.EventHandler(this.btn_referencias_MouseEnter);
            this.btn_referencias.MouseLeave += new System.EventHandler(this.btn_referencias_MouseLeave);
            // 
            // btn_sobre
            // 
            this.btn_sobre.Location = new System.Drawing.Point(387, 32);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(208, 68);
            this.btn_sobre.TabIndex = 1;
            this.btn_sobre.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_sobre, "Sobre o Quiz");
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            this.btn_sobre.MouseEnter += new System.EventHandler(this.btn_sobre_MouseEnter);
            this.btn_sobre.MouseLeave += new System.EventHandler(this.btn_sobre_MouseLeave);
            // 
            // btn_jogar
            // 
            this.btn_jogar.Location = new System.Drawing.Point(159, 32);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(208, 68);
            this.btn_jogar.TabIndex = 0;
            this.btn_jogar.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_jogar, "Começar a Jogar");
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            this.btn_jogar.MouseEnter += new System.EventHandler(this.btn_jogar_MouseEnter);
            this.btn_jogar.MouseLeave += new System.EventHandler(this.btn_jogar_MouseLeave);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(143, 66);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_sair, "Sair do Quiz");
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            this.btn_sair.MouseEnter += new System.EventHandler(this.btn_sair_MouseEnter);
            this.btn_sair.MouseLeave += new System.EventHandler(this.btn_sair_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_sair);
            this.panel5.Location = new System.Drawing.Point(857, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(143, 100);
            this.panel5.TabIndex = 12;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwoQ";
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_referencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox btn_jogar;
        private PictureBox btn_referencias;
        private PictureBox btn_sobre;
        private PictureBox btn_sair;
        private Panel panel5;
        private ToolTip toolTip1;
    }
}
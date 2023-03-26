namespace TwoQ
{
    partial class frmTelaFinal_Parabens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaFinal_Parabens));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.PictureBox();
            this.btn_prevencao = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.lbl_pontuacao = new System.Windows.Forms.Label();
            this.mascote = new System.Windows.Forms.PictureBox();
            this.vidas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prevencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_sair);
            this.panel3.Controls.Add(this.btn_prevencao);
            this.panel3.Controls.Add(this.btn_menu);
            this.panel3.Location = new System.Drawing.Point(12, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 74);
            this.panel3.TabIndex = 11;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(640, 6);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(243, 68);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_sair, "Sair do jogo");
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            this.btn_sair.MouseEnter += new System.EventHandler(this.btn_sair_MouseEnter);
            this.btn_sair.MouseLeave += new System.EventHandler(this.btn_sair_MouseLeave);
            // 
            // btn_prevencao
            // 
            this.btn_prevencao.Location = new System.Drawing.Point(371, 6);
            this.btn_prevencao.Name = "btn_prevencao";
            this.btn_prevencao.Size = new System.Drawing.Size(243, 68);
            this.btn_prevencao.TabIndex = 1;
            this.btn_prevencao.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_prevencao, "Dicas de prevenção");
            this.btn_prevencao.Click += new System.EventHandler(this.btn_prevencao_Click);
            this.btn_prevencao.MouseEnter += new System.EventHandler(this.btn_prevencao_MouseEnter);
            this.btn_prevencao.MouseLeave += new System.EventHandler(this.btn_prevencao_MouseLeave);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(102, 6);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(243, 68);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_menu, "Menu principal");
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            this.btn_menu.MouseEnter += new System.EventHandler(this.btn_menu_MouseEnter);
            this.btn_menu.MouseLeave += new System.EventHandler(this.btn_menu_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(86)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(252, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 134);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TwoQ.Properties.Resources.Parabens;
            this.pictureBox1.Location = new System.Drawing.Point(7, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 98);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Jost SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_texto.ForeColor = System.Drawing.Color.White;
            this.lbl_texto.Location = new System.Drawing.Point(197, 135);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(603, 54);
            this.lbl_texto.TabIndex = 13;
            this.lbl_texto.Text = "Você conseguiu completar o quiz !";
            // 
            // lbl_pontuacao
            // 
            this.lbl_pontuacao.AutoSize = true;
            this.lbl_pontuacao.Font = new System.Drawing.Font("Jost SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pontuacao.ForeColor = System.Drawing.Color.White;
            this.lbl_pontuacao.Location = new System.Drawing.Point(346, 176);
            this.lbl_pontuacao.Name = "lbl_pontuacao";
            this.lbl_pontuacao.Size = new System.Drawing.Size(316, 54);
            this.lbl_pontuacao.TabIndex = 14;
            this.lbl_pontuacao.Text = "Pontuação: 11/12";
            // 
            // mascote
            // 
            this.mascote.Location = new System.Drawing.Point(293, 221);
            this.mascote.Name = "mascote";
            this.mascote.Size = new System.Drawing.Size(400, 377);
            this.mascote.TabIndex = 15;
            this.mascote.TabStop = false;
            // 
            // vidas
            // 
            this.vidas.Location = new System.Drawing.Point(118, 674);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(285, 45);
            this.vidas.TabIndex = 23;
            this.vidas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jost SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vidas:";
            // 
            // frmTelaFinal_Parabens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.vidas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.lbl_pontuacao);
            this.Controls.Add(this.mascote);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaFinal_Parabens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwoQ";
            this.Load += new System.EventHandler(this.frmTelaFinal_Parabens_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prevencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel3;
        private PictureBox btn_sair;
        private PictureBox btn_prevencao;
        private PictureBox btn_menu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_texto;
        private Label lbl_pontuacao;
        private PictureBox mascote;
        private PictureBox vidas;
        private Label label1;
        private ToolTip toolTip1;
    }
}
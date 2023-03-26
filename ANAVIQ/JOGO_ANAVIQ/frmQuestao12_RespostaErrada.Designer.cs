namespace TwoQ
{
    partial class frmQuestao12_RespostaErrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestao12_RespostaErrada));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_proximo = new System.Windows.Forms.PictureBox();
            this.btn_resposta_correta = new System.Windows.Forms.PictureBox();
            this.btn_voltar_dica = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resposta_errada = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_proximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resposta_correta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar_dica)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resposta_errada)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(920, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 732);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_proximo);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 85);
            this.panel2.TabIndex = 19;
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.Color.Transparent;
            this.btn_proximo.Location = new System.Drawing.Point(6, 25);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(54, 55);
            this.btn_proximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_proximo.TabIndex = 0;
            this.btn_proximo.TabStop = false;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            this.btn_proximo.MouseEnter += new System.EventHandler(this.btn_proximo_MouseEnter);
            this.btn_proximo.MouseLeave += new System.EventHandler(this.btn_proximo_MouseLeave);
            // 
            // btn_resposta_correta
            // 
            this.btn_resposta_correta.Location = new System.Drawing.Point(3, 3);
            this.btn_resposta_correta.Name = "btn_resposta_correta";
            this.btn_resposta_correta.Size = new System.Drawing.Size(208, 68);
            this.btn_resposta_correta.TabIndex = 28;
            this.btn_resposta_correta.TabStop = false;
            this.btn_resposta_correta.Click += new System.EventHandler(this.btn_resposta_correta_Click);
            this.btn_resposta_correta.MouseEnter += new System.EventHandler(this.btn_resposta_correta_MouseEnter);
            this.btn_resposta_correta.MouseLeave += new System.EventHandler(this.btn_resposta_correta_MouseLeave);
            // 
            // btn_voltar_dica
            // 
            this.btn_voltar_dica.Location = new System.Drawing.Point(3, 3);
            this.btn_voltar_dica.Name = "btn_voltar_dica";
            this.btn_voltar_dica.Size = new System.Drawing.Size(208, 68);
            this.btn_voltar_dica.TabIndex = 29;
            this.btn_voltar_dica.TabStop = false;
            this.btn_voltar_dica.Visible = false;
            this.btn_voltar_dica.Click += new System.EventHandler(this.btn_voltar_dica_Click);
            this.btn_voltar_dica.MouseEnter += new System.EventHandler(this.btn_voltar_dica_MouseEnter);
            this.btn_voltar_dica.MouseLeave += new System.EventHandler(this.btn_voltar_dica_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_resposta_correta);
            this.panel3.Controls.Add(this.btn_voltar_dica);
            this.panel3.Location = new System.Drawing.Point(66, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 153);
            this.panel3.TabIndex = 30;
            // 
            // resposta_errada
            // 
            this.resposta_errada.BackColor = System.Drawing.Color.Transparent;
            this.resposta_errada.Location = new System.Drawing.Point(24, 13);
            this.resposta_errada.Name = "resposta_errada";
            this.resposta_errada.Size = new System.Drawing.Size(873, 708);
            this.resposta_errada.TabIndex = 27;
            this.resposta_errada.TabStop = false;
            // 
            // frmQuestao12_RespostaErrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(187)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.resposta_errada);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuestao12_RespostaErrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TwoQ";
            this.Load += new System.EventHandler(this.frmQuestao12_RespostaErrada_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_proximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resposta_correta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar_dica)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resposta_errada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btn_proximo;
        private PictureBox btn_resposta_correta;
        private PictureBox btn_voltar_dica;
        private Panel panel3;
        private PictureBox resposta_errada;
    }
}
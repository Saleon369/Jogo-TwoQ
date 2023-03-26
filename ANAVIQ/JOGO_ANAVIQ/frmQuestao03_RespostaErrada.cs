﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoQ;

namespace TwoQ
{    public partial class frmQuestao03_RespostaErrada : Form
    {

        // === Imagem Pergunta Errada 03
        Image img_resposta_errada_03;
        Image img_resposta_errada_certa_03;

        // ==== BOTÃO proximo
        Image btn_proximo_normal;   // botão normal
        Image btn_proximo_high;     // quando o mouse passa por cima do botão

        // ==== BOTÃO  resposta correta
        Image btn_resposta_correta_normal; // botão normal
        Image btn_resposta_correta_high;  /// quando o mouse passa por cima do botão

        // ==== BOTÃO voltar dica
        Image btn_voltar_dica_normal;  // botão normal
        Image btn_voltar_dica_high; /// quando o mouse passa por cima do botão

        

        public frmQuestao03_RespostaErrada()
        {
            InitializeComponent();

            img_resposta_errada_03 = Properties.Resources.Resposta_Errada_03;   // atribui a imagem da pasta "images" na variavel btn_resposta_errada_03
            img_resposta_errada_certa_03 = Properties.Resources.Resposta_Errada_Certa_03; // atribui a imagem da pasta "images" na variavel btn_resposta_errada_cerca_03

            btn_proximo_normal = Properties.Resources.btn_proximo_normal; // atribui a imagem da pasta "images" na variavel btn_proximo_normal
            btn_proximo_high = Properties.Resources.btn_proximo_high; // atribui a imagem da pasta "images" na variavel btn_proximo_high

            btn_resposta_correta_normal = Properties.Resources.btn_resposta_correta_normal; // atribui a imagem da pasta "images" na variavel btn_resposta_correta_normal
            btn_resposta_correta_high = Properties.Resources.btn_resposta_correta_high; // atribui a imagem da pasta "images" na variavel btn_respsota_correta_high

            btn_voltar_dica_normal = Properties.Resources.btn_voltar_dica_normal; // atribui a imagem da pasta "images" na variavel btn_voltar_dica_normal
            btn_voltar_dica_high = Properties.Resources.btn_voltar_dica_high; // atribui a imagem da pasta "images" na variavel btn_voltar_dica_high
        }


        private void frmQuestao03_RespostaErrada_Load(object sender, EventArgs e)
        {
            btn_proximo.BackgroundImage = btn_proximo_normal;  // atribuição da imagem na picturebox ( btn_proximo )
            btn_resposta_correta.BackgroundImage = btn_resposta_correta_normal; // atribuição da imagem na picturebox ( btn_resposta_correta )
            btn_voltar_dica.BackgroundImage = btn_voltar_dica_normal; // atribuição da imagem na picturebox (btn_voltar_dica )
            resposta_errada.BackgroundImage = img_resposta_errada_03;  // atribuição da imagem na picturebox (resposta_errada_03)
        }



        // ===== Botão Proximo
        private void btn_proximo_Click(object sender, EventArgs e)
        {
            frmQuestao04 Questao04 = new frmQuestao04();
            this.Visible = false;
            Questao04.ShowDialog();
            this.Close();
        }

        private void btn_proximo_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_proximo.BackgroundImage = btn_proximo_high; // atribuição da imagem na picturebox ( btn_proximo )
        }

        private void btn_proximo_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_proximo.BackgroundImage = btn_proximo_normal; // atribuição da imagem na picturebox ( btn_proximo )
        }


        // ==== BOTAO RESPOSTA CORRETA
        private void btn_resposta_correta_Click(object sender, EventArgs e)
        {
            resposta_errada.BackgroundImage = img_resposta_errada_certa_03; // Altera para a imagem com a resposta certa
            this.btn_resposta_correta.Visible = false;
            this.btn_voltar_dica.Visible = true;
        }

        private void btn_resposta_correta_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_resposta_correta.BackgroundImage = btn_resposta_correta_high; // atribuição da imagem na picturebox ( btn_resposta_correta )
        }

        private void btn_resposta_correta_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_resposta_correta.BackgroundImage = btn_resposta_correta_normal; // atribuição da imagem na picturebox ( btn_resposta_correta)
            
        }

        // ==== BOTAO VOLTAR PARA DICA
        private void btn_voltar_dica_Click(object sender, EventArgs e)
        {
            resposta_errada.BackgroundImage = img_resposta_errada_03; // Altera para a imagem com a dica
            this.btn_voltar_dica.Visible = false;
            this.btn_resposta_correta.Visible = true;
            
        }

        private void btn_voltar_dica_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_voltar_dica.BackgroundImage = btn_voltar_dica_high; // atribuição da imagem na picturebox ( btn_voltar_dica )
        }

        private void btn_voltar_dica_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_voltar_dica.BackgroundImage = btn_voltar_dica_normal; // atribuição da imagem na picturebox ( btn_voltar_dica )
        }
    }
}

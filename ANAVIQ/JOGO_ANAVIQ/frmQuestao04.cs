using System;
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
{
    public partial class frmQuestao04 : Form
    {

        // ==== VIDAS
        Image img_vidasFull;
        Image img_vidasCinco;
        Image img_vidasQuatro;
        Image img_vidasTres;

        // ==== BOTÃO VOLTAR
        Image img_btn_voltar_normal;   // botão normal voltar
        Image img_btn_voltar_high;     // quando o mouse passa por cima do botão

        // ==== BOTAO CORRETO ( Alternativa CORRETA )
        Image img_btn_correto04_normal; // botão normal
        Image img_btn_correto04_high; // quando o mouse passa por cima do botão

        // ==== BOTAO QUASE CORRETO ( Alternativa ERRADA ) 
        Image img_btn_quasecorreto04_normal; // botão normal
        Image img_btn_quasecorreto04_high; // quando o mouse passa por cima do botão

        // ==== BOTAO ERRADO  ( Alternativa ERRADA )
        Image img_btn_errado04_normal; // botão normal
        Image img_btn_errado04_high; // quando o mouse passa por cima do botão

        // ==== BOTAO ABSURDO  ( Alternativa ERRADA )
        Image img_btn_absurdo04_normal; // botão normal
        Image img_btn_absurdo04_high; // quando o mouse passa por cima do botão

        public frmQuestao04()
        {
            InitializeComponent();

            img_vidasFull = Properties.Resources.Vida_Full; // atribui a imagem da pasta "images" na variavel img_vidas 
            img_vidasCinco = Properties.Resources.Vida_Cinco; // atribui a imagem da pasta "images" na variavel img_vidas
            img_vidasQuatro = Properties.Resources.Vida_Quatro; // atribui a imagem da pasta "images" na variavel img_vidas
            img_vidasTres = Properties.Resources.Vida_Tres; // atribui a imagem da pasta "images" na variavel img_vidas

            img_btn_voltar_normal = Properties.Resources.btn_voltar_normal; // atribui a imagem da pasta "images" na variavel img_voltar_normal
            img_btn_voltar_high = Properties.Resources.btn_voltar_high; // atribui a imagem da pasta "images" na variavel img_voltar_high

            
            img_btn_correto04_normal = Properties.Resources.btn_correto04_normal; // Atribui a imagem da pasta "images" na variavel img_btn_correto04_normal
            img_btn_correto04_high = Properties.Resources.btn_correto04_high;   // atribui a imagem da pasta "images" na variavel img_btn_correto04_high

            img_btn_quasecorreto04_normal = Properties.Resources.btn_quasecorreto04_normal;  // Atribui a imagem da pasta "images" na variavel img_btn_quasecorreto04_normal
            img_btn_quasecorreto04_high = Properties.Resources.btn_quasecorreto04_high;  // atribui a imagem da pasta "images" na variavel img_btn_quasecorreto04_high

            img_btn_errado04_normal = Properties.Resources.btn_errado04_normal;  // Atribui a imagem da pasta "images" na variavel img_btn_errado04_normal
            img_btn_errado04_high = Properties.Resources.btn_errado04_high;  // atribui a imagem da pasta "images" na variavel img_btn_errado04_high

            img_btn_absurdo04_normal = Properties.Resources.btn_absurdo04_normal;// Atribui a imagem da pasta "images" na variavel img_btn_absurdo04_normal
            img_btn_absurdo04_high = Properties.Resources.btn_absurdo04_high;  // atribui a imagem da pasta "images" na variavel img_btn_absurdo04_high
        }


        int alternativas;
        private void frmQuestao04_Load(object sender, EventArgs e)
        {
            lblnome.Text = VariaveisGlobais.nome;

            if ( VariaveisGlobais.erros == 0 ) 
            {
                vidas.BackgroundImage = img_vidasFull;   // atribuição da imagem na picturebox ( vidas )
            }
            else if ( VariaveisGlobais.erros == 1 )
            {
                vidas.BackgroundImage = img_vidasCinco;// atribuição da imagem na picturebox ( vidas )
            }
            else if ( VariaveisGlobais.erros == 2 )
            {
                vidas.BackgroundImage = img_vidasQuatro; // atribuição da imagem na picturebox ( vidas )
            }
            else if ( VariaveisGlobais.erros == 3 )
            {
                vidas.BackgroundImage = img_vidasTres; // atribuição da imagem na picture box ( vidas )
            }

            btn_voltar.BackgroundImage = img_btn_voltar_normal;  // atribuição da imagem na picturebox ( btn_voltar )
            btn_correto.BackgroundImage = img_btn_correto04_normal;  // atribuição da imagem na picturebox ( btn_correto )
            btn_quasecorreto.BackgroundImage = img_btn_quasecorreto04_normal;  // atribuição da imagem na picturebox ( btn_quasecorreto )
            btn_errado.BackgroundImage = img_btn_errado04_normal; // atribuição da imagem na picturebox ( btn_errado )
            btn_absurdo.BackgroundImage = img_btn_absurdo04_normal; // atribuição da imagem na picturebox ( btn_absurdo )


            // ====== ALEATORIZAÇÃO DOS BOTÕES DE ALTERNATIVA 
            Random random = new Random();
            alternativas = random.Next(1,24);

            switch (alternativas)
            {
                case 1:
                    this.btn_correto.Location = new System.Drawing.Point(0, 3);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 102);
                    this.btn_errado.Location = new System.Drawing.Point(0, 201);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 300);

                    break;

               case 2:
                    this.btn_correto.Location = new System.Drawing.Point(0, 3);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 102);
                    this.btn_errado.Location = new System.Drawing.Point(0, 300);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 201);

                    break;

                case 3:
                    this.btn_correto.Location = new System.Drawing.Point(0, 3);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 201);
                    this.btn_errado.Location = new System.Drawing.Point(0, 102);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 300);

                    break;

                case 4:
                    this.btn_correto.Location = new System.Drawing.Point(0, 3);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 201);
                    this.btn_errado.Location = new System.Drawing.Point(0, 300);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 102);

                    break;

                case 5:
                    this.btn_correto.Location = new System.Drawing.Point(0, 3);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 300);
                    this.btn_errado.Location = new System.Drawing.Point(0, 102);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 201);

                    break;

                case 6:
                    this.btn_correto.Location = new System.Drawing.Point(0, 3);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 300);
                    this.btn_errado.Location = new System.Drawing.Point(0, 201);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 102);

                    break;

                case 7:
                    this.btn_correto.Location = new System.Drawing.Point(0, 102);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 3);
                    this.btn_errado.Location = new System.Drawing.Point(0, 201);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 300);

                    break;

                case 8:
                    this.btn_correto.Location = new System.Drawing.Point(0, 102);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 3);
                    this.btn_errado.Location = new System.Drawing.Point(0, 300);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 201);

                    break;

                case 9:
                    this.btn_correto.Location = new System.Drawing.Point(0, 201);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 3);
                    this.btn_errado.Location = new System.Drawing.Point(0, 102);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 300);

                    break;

                case 10:
                    this.btn_correto.Location = new System.Drawing.Point(0, 201);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 3);
                    this.btn_errado.Location = new System.Drawing.Point(0, 300);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 102);

                    break;

                case 11:
                    this.btn_correto.Location = new System.Drawing.Point(0, 300);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 3);
                    this.btn_errado.Location = new System.Drawing.Point(0, 102);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 201);

                    break;

                case 12:
                    this.btn_correto.Location = new System.Drawing.Point(0, 300);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 3);
                    this.btn_errado.Location = new System.Drawing.Point(0, 201);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 102);

                    break;

                case 13:
                    this.btn_correto.Location = new System.Drawing.Point(0, 102);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 201);
                    this.btn_errado.Location = new System.Drawing.Point(0, 3);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 300);

                    break;

                case 14:
                    this.btn_correto.Location = new System.Drawing.Point(0, 102);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 300);
                    this.btn_errado.Location = new System.Drawing.Point(0, 3);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 201);

                    break;

                case 15:
                    this.btn_correto.Location = new System.Drawing.Point(0, 201);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 102);
                    this.btn_errado.Location = new System.Drawing.Point(0, 3);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 300);

                    break;

                case 16:
                    this.btn_correto.Location = new System.Drawing.Point(0, 201);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 300);
                    this.btn_errado.Location = new System.Drawing.Point(0, 3);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 102);

                    break;

                case 17:
                    this.btn_correto.Location = new System.Drawing.Point(0, 300);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 102);
                    this.btn_errado.Location = new System.Drawing.Point(0, 3);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 201);

                    break;

                case 18:
                    this.btn_correto.Location = new System.Drawing.Point(0, 300);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 201);
                    this.btn_errado.Location = new System.Drawing.Point(0, 3);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 102);

                    break;

                case 19:
                    this.btn_correto.Location = new System.Drawing.Point(0, 102);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 201);
                    this.btn_errado.Location = new System.Drawing.Point(0, 300);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 3);

                    break;

                case 20:
                    this.btn_correto.Location = new System.Drawing.Point(0, 102);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 300);
                    this.btn_errado.Location = new System.Drawing.Point(0, 201);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 3);

                    break;

                case 21:
                    this.btn_correto.Location = new System.Drawing.Point(0, 201);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 102);
                    this.btn_errado.Location = new System.Drawing.Point(0, 300);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 3);

                    break;


                case 22:
                    this.btn_correto.Location = new System.Drawing.Point(0, 201);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 300);
                    this.btn_errado.Location = new System.Drawing.Point(0, 102);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 3);

                    break;


                case 23:
                    this.btn_correto.Location = new System.Drawing.Point(0, 300);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 102);
                    this.btn_errado.Location = new System.Drawing.Point(0, 201);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 3);

                    break;

                case 24:
                    this.btn_correto.Location = new System.Drawing.Point(0, 300);
                    this.btn_quasecorreto.Location = new System.Drawing.Point(0, 201);
                    this.btn_errado.Location = new System.Drawing.Point(0, 102);
                    this.btn_absurdo.Location = new System.Drawing.Point(0, 3);

                    break;
            }


        }

        // ===== BOTAO VOLTAR PRA TELA PRINCIPAL
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // === CAIXA DE DIALOGO BOTAO VOLTAR
            DialogResult Resposta = MessageBox.Show("Deseja voltar ao início?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (Resposta == DialogResult.Yes)
            {
                DialogResult Resposta1 = MessageBox.Show("Seu progresso será perdido!\nTem certeza?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (Resposta1 == DialogResult.Yes)
                {
                    VariaveisGlobais.acertos = 0;  // contador da variavel acertos é zerada
                    VariaveisGlobais.erros = 0; // contador da variavel erros é zerada
                    VariaveisGlobais.vidas = 6; // contador de vidas é reinicializada
                    this.Visible = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Boa sorte!", "ANAVIQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Boa sorte!", "ANAVIQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ====== BOTÃO VOLTAR
        private void btn_voltar_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_voltar.BackgroundImage = img_btn_voltar_high; // atribuição da imagem na picturebox ( btn_voltar )
        }
        private void btn_voltar_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_voltar.BackgroundImage = img_btn_voltar_normal; // atribuição da imagem na picturebox ( btn_voltar )
        }


        // ====== BOTAO CORRETO 04

        private void btn_correto_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Você está certo disso?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Resposta == DialogResult.Yes)
            {
                VariaveisGlobais.acertos++;  // soma 01 ponto nos acertos 
                frmQuestao04_RespotaCorreta RespostaCorreta = new frmQuestao04_RespotaCorreta();
                this.Visible = false;
                RespostaCorreta.ShowDialog();
                this.Close();

            }
            
        }
        private void btn_correto_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_correto.BackgroundImage = img_btn_correto04_high; // atribuição da imagem na picturebox ( btn_correto )
        }

        private void btn_correto_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_correto.BackgroundImage = img_btn_correto04_normal; // atribuição da imagem na picturebox ( btn_correto )
        }


        // ====== BOTAO QUASE CORRETO 04
        private void btn_quasecorreto_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Você está certo disso?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                VariaveisGlobais.erros++;  // soma 01 ponto nos erros
                frmQuestao04_RespostaErrada RespostaErrada = new frmQuestao04_RespostaErrada();
                this.Visible = false;
                RespostaErrada.ShowDialog();
                this.Close();
            }
        }

        private void btn_quasecorreto_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_quasecorreto.BackgroundImage = img_btn_quasecorreto04_high; // atribuição da imagem na picturebox ( btn_quasecorreto )
        }

        private void btn_quasecorreto_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_quasecorreto.BackgroundImage = img_btn_quasecorreto04_normal; // atribuição da imagem na picturebox ( btn_quasecorreto )
        }


        // ====== BOTAO ERRADO 04
        private void btn_errado_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Você está certo disso?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                VariaveisGlobais.erros++;  // soma 01 ponto nos erros
                frmQuestao04_RespostaErrada RespostaErrada = new frmQuestao04_RespostaErrada();
                this.Visible = false;
                RespostaErrada.ShowDialog();
                this.Close();
            }
        }

        private void btn_errado_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_errado.BackgroundImage = img_btn_errado04_high; // atribuição da imagem na picturebox ( btn_errado )
        }

        private void btn_errado_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_errado.BackgroundImage = img_btn_errado04_normal; // atribuição da imagem na picturebox ( btn_errado )
        }



        // ====== BOTAO ABSURDO 04
        private void btn_absurdo_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Você está certo disso?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                VariaveisGlobais.erros++;  // soma 01 ponto nos erros
                frmQuestao04_RespostaErrada RespostaErrada = new frmQuestao04_RespostaErrada();
                this.Visible = false;
                RespostaErrada.ShowDialog();
                this.Close();
            }
        }

        private void btn_absurdo_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_absurdo.BackgroundImage = img_btn_absurdo04_high; // atribuição da imagem na picturebox ( btn_absurdo )
        }

        private void btn_absurdo_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_absurdo.BackgroundImage = img_btn_absurdo04_normal; // atribuição da imagem na picturebox ( btn_absurdo )
        }

        // ====================================================================================================================

    }
}

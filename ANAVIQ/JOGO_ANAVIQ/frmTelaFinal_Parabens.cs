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
    public partial class frmTelaFinal_Parabens : Form
    {
        // ==== VIDAS
        Image img_vidasFull;
        Image img_vidasCinco;
        Image img_vidasQuatro;
        Image img_vidasTres;
        Image img_vidasDois;
        Image img_vidasUm;

        // ===== BOTÃO MENU PRINCIPAL
        Image btn_menu_normal; // botão normal menu
        Image btn_menu_high; // quando o mouse passa por cima do botão

        // ===== BOTÃO PREVENÇÕES
        Image btn_prevencao_normal; // botão normal prevenções
        Image btn_prevencao_high; // quando o mouse passa por cima do botão

        // ===== BOTÃO SAIR
        Image btn_sair_normal; // botão normal sair
        Image btn_sair_high; // quando o mouse passa por cima do botão

        // ===== MASCOTE
        Image mascote_parabens; // Mascote que aparece com pontuação < 12
        Image mascote_parabensfull; // Mascote que aparece com pontuação = 12

        public frmTelaFinal_Parabens()
        {        

            InitializeComponent();

            img_vidasFull = Properties.Resources.Vida_Full; // atribui a imagem da pasta "images" na variavel img_vidas 
            img_vidasCinco = Properties.Resources.Vida_Cinco; // atribui a imagem da pasta "images" na variavel img_vidas
            img_vidasQuatro = Properties.Resources.Vida_Quatro; // atribui a imagem da pasta "images" na variavel img_vidas
            img_vidasTres = Properties.Resources.Vida_Tres; // atribui a imagem da pasta "images" na variavel img_vidas
            img_vidasDois = Properties.Resources.Vida_Dois; // atribui a imagem da pasta "images" na variavel img_vidas
            img_vidasUm = Properties.Resources.Vida_Um; // atribui a imagem da pasta "images" na variavel img_vidas

            btn_menu_normal = Properties.Resources.btn_menu_normal; // atribui a imagem da pasta " images " na variavel btn_menu_normal
            btn_menu_high = Properties.Resources.btn_menu_high; // atribui a imagem da pasta " images " na variavel btn_menu_high

            btn_prevencao_normal = Properties.Resources.btn_prevencao_normal; // atribui a imagem da pasta " images " na variavel btn_prevencao_normal
            btn_prevencao_high = Properties.Resources.btn_prevencao_high; // atribui a imagem da pasta " images " na variavel btn_prevencao_high

            btn_sair_normal = Properties.Resources.btn_sair_final_normal; // atribui a imagem da pasta " images " na variavel btn_sair_normal
            btn_sair_high = Properties.Resources.btn_sair_final_high; // atribui a imagem da pasta " images " na variavel btn_sair_high
                      
            mascote_parabens = Properties.Resources.Mascote_Parabens; // atribui a imagem da pasta " images " na variavel mascote_parabens
            mascote_parabensfull = Properties.Resources.Mascote_ParabensFull; // atribui a imagem da pasta " images " na variavel mascote_parabensfull

        }

        private void frmTelaFinal_Parabens_Load(object sender, EventArgs e)
        {
            if (VariaveisGlobais.erros == 0)
            {
                vidas.BackgroundImage = img_vidasFull;   // atribuição da imagem na picturebox ( vidas )
            }
            else if (VariaveisGlobais.erros == 1)
            {
                vidas.BackgroundImage = img_vidasCinco;// atribuição da imagem na picturebox ( vidas )
            }
            else if (VariaveisGlobais.erros == 2)
            {
                vidas.BackgroundImage = img_vidasQuatro; // atribuição da imagem na picturebox ( vidas )
            }
            else if (VariaveisGlobais.erros == 3)
            {
                vidas.BackgroundImage = img_vidasTres; // atribuição da imagem na picture box ( vidas )
            }
            else if (VariaveisGlobais.erros == 4)
            {
                vidas.BackgroundImage = img_vidasDois; // atribuição da imagem na picture box ( vidas )
            }
            else if (VariaveisGlobais.erros == 5)
            {
                vidas.BackgroundImage = img_vidasUm; // atribuição da imagem na picture box ( vidas )
            }

             //===================================================================================================

            if (VariaveisGlobais.acertos == 12)
            {
                this.mascote.Location = new System.Drawing.Point(293, 164); // Mudando a localização da picture box
                this.mascote.Size = new System.Drawing.Size(405, 415);      // Mudando o tamanho da picture box
                mascote.BackgroundImage = mascote_parabensfull;             // atribuição da Imagem do Mascote na picture box ( mascote )

            }
            else
            {
                mascote.BackgroundImage = mascote_parabens;                 // atribuição da Imagem do Mascote na picture box ( mascote )
            
            
            }


            lbl_pontuacao.Text = "Pontuação: "+Convert.ToString(VariaveisGlobais.acertos+"/12");

            btn_menu.BackgroundImage = btn_menu_normal; // atribuição da imagem na picturebox ( btn_menu ) 
            btn_prevencao.BackgroundImage = btn_prevencao_normal; // atribuição da imagem na picturebox ( btn_prevencao )
            btn_sair.BackgroundImage = btn_sair_normal; // atribuição da imagem na picturebox ( btn_sair )

        }

        // ===== BOTÃO MENU

        private void btn_menu_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja voltar?\nEssa tela será fechada!", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Resposta == DialogResult.Yes)
            {
                VariaveisGlobais.acertos = 0;
                VariaveisGlobais.erros = 0;
                VariaveisGlobais.vidas = 6;
                this.Close();
            }
        }

        private void btn_menu_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_menu.BackgroundImage = btn_menu_high; // atribuição da imagem na picture box ( btn_menu )
        }

        private void btn_menu_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_menu.BackgroundImage = btn_menu_normal; // atribuição da imagem na picturebox ( btn_menu )
        }


        // ===== BOTÃO PREVENÇÃO
        private void btn_prevencao_Click(object sender, EventArgs e)
        {
            frmTelaDicas Dicas = new frmTelaDicas();
            Dicas.ShowDialog();
        }

        private void btn_prevencao_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_prevencao.BackgroundImage = btn_prevencao_high; // atribuição da imagem na picture box ( btn_prevencao )
        }

        private void btn_prevencao_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_prevencao.BackgroundImage = btn_prevencao_normal; // atribuição da imagem na picturebox ( btn_prevencao )
        }

        // ===== BOTÃO SAIR

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja sair?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Obrigado por ficar!", "ANAVIQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_sair.BackgroundImage = btn_sair_high; // atribuição da imagem na picture box ( btn_sair )
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_sair.BackgroundImage = btn_sair_normal; // atribuição da imagem na picturebox ( btn_sair )
        }

        
    }
}

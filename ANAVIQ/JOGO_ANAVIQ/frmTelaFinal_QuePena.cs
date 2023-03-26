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
    public partial class frmTelaFinal_QuePena : Form
    {       
        // ===== BOTÃO MENU PRINCIPAL
        Image btn_menu_normal; // botão normal menu
        Image btn_menu_high; // quando o mouse passa por cima do botão

        // ===== BOTÃO PREVENÇÕES
        Image btn_prevencao_normal; // botão normal prevenções
        Image btn_prevencao_high; // quando o mouse passa por cima do botão

        // ===== BOTÃO SAIR
        Image btn_sair_normal; // botão normal sair
        Image btn_sair_high; // quando o mouse passa por cima do botão

        public frmTelaFinal_QuePena()
        {        

            InitializeComponent();

            btn_menu_normal = Properties.Resources.btn_menu_normal; // atribui a imagem da pasta " images " na variavel btn_menu_normal
            btn_menu_high = Properties.Resources.btn_menu_high; // atribui a imagem da pasta " images " na variavel btn_menu_high

            btn_prevencao_normal = Properties.Resources.btn_prevencao_normal; // atribui a imagem da pasta " images " na variavel btn_prevencao_normal
            btn_prevencao_high = Properties.Resources.btn_prevencao_high; // atribui a imagem da pasta " images " na variavel btn_prevencao_high

            btn_sair_normal = Properties.Resources.btn_sair_final_normal; // atribui a imagem da pasta " images " na variavel btn_sair_normal
            btn_sair_high = Properties.Resources.btn_sair_final_high; // atribui a imagem da pasta " images " na variavel btn_sair_high

        }

        private void frmTelaFinal_QuePena_Load(object sender, EventArgs e)
        {
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

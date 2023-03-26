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
    public partial class frmQuestao02_RespotaCorreta : Form
    {

        // ==== BOTÃO proximo
        Image btn_proximo_normal;   // botão normal
        Image btn_proximo_high;     // quando o mouse passa por cima do botão

        public frmQuestao02_RespotaCorreta()
        {
            InitializeComponent();

            btn_proximo_normal = Properties.Resources.btn_proximo_normal; // atribui a imagem da pasta "images" na variavel btn_proximo_normal
            btn_proximo_high = Properties.Resources.btn_proximo_high; // atribui a imagem da pasta "images" na variavel btn_proximo_high

        }

        private void frmQuestao02_RespotaCorreta_Load(object sender, EventArgs e)
        {
            btn_proximo.BackgroundImage = btn_proximo_normal;  // atribuição da imagem na picturebox ( btn_proximo )
        }

        // ======= Botao Proximo

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            frmQuestao03 Questao03 = new frmQuestao03();
            this.Visible = false;
            Questao03.ShowDialog();
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

        
    }
}

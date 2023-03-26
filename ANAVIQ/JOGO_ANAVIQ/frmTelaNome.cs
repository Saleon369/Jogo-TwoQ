using TwoQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoQ
{
    public partial class frmTelaNome : Form
    {
        //==== BOTAO CONTINUAR
        Image img_continuar_normal; // botão jogar normal
        Image img_continuar_high; // quando passa o mouse por cima do botão
        //==== BOTAO CANCELAR
        Image img_cancelar_normal; // botao sobre normal
        Image img_cancelar_high; // quando passa o mouse por cima do botao


        public frmTelaNome()
        {
            InitializeComponent();
            
            // ========== Botao CONTINUAR
            img_continuar_normal = Properties.Resources.btn_continuar_normal;
            img_continuar_high = Properties.Resources.btn_continuar_high;
            // ========== Botao CANCELAR
            img_cancelar_normal = Properties.Resources.btn_cancelar_normal;
            img_cancelar_high = Properties.Resources.btn_cancelar_high;
        }

        private void frmTelaNome_Load(object sender, EventArgs e)
        {
            btn_continuar.BackgroundImage = img_continuar_normal; // atribuição da imagem na picturebox ( btn_continuar )
            btn_cancelar.BackgroundImage = img_cancelar_normal; // atribuição da imagem na picturebox ( btn_cancelar )
        }

        //==== BOTAO CONTINUAR
        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.Equals(""))
            {
                MessageBox.Show("Você precisa digitar um nome!", "ANAVIQ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmQuestao01 Questao01 = new frmQuestao01();
                this.Visible = false;
                this.Close();
                //Questao01.ValorNome = txtnome.Text;  // passa o valor para o método ValorNome
                VariaveisGlobais.nome = txtnome.Text;
                Questao01.ShowDialog();
            }
        }
        private void btn_continuar_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_continuar.BackgroundImage = img_continuar_high; //atribuição da imagem na PictureBox ( btn_continuar )
        }

        private void btn_continuar_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( altera a imagem para normal quando mouse sai da foto )
            btn_continuar.BackgroundImage = img_continuar_normal; // atribuição da imagem na PictureBox ( btn_continuar )
        }

        //==== BOTAO CANCELAR
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_cancelar.BackgroundImage = img_cancelar_high; //atribuição da imagem na PictureBox ( btn_cancelar )
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( altera a imagem para normal quando mouse sai da foto )
            btn_cancelar.BackgroundImage = img_cancelar_normal; // atribuição da imagem na PictureBox ( btn_cancelar )
        }

       

        
    }
}

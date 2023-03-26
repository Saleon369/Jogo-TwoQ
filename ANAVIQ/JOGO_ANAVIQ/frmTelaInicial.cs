using TwoQ;
using System.Drawing.Drawing2D;

namespace TwoQ
{
    public partial class frmTelaInicial : Form
    {
        //==== BOTAO JOGAR
        Image img_jogar_normal; // botão jogar normal
        Image img_jogar_high; // quando passa o mouse por cima do botão
        //==== BOTAO SOBRE
        Image img_sobre_normal; // botao sobre normal
        Image img_sobre_high; // quando passa o mouse por cima do botao
        //==== BOTAO REFERENCIA
        Image img_referencias_normal; // botao referencia normal
        Image img_referencias_high; // quando passa o mouse por cima do botao
        //==== BOTAO SAIR
        Image img_sair_normal; // botao referencia normal
        Image img_sair_high; // quando passa o mouse por cima do botao



        public frmTelaInicial()
        {
            InitializeComponent();

            // ========== Botao JOGAR
            img_jogar_normal = Properties.Resources.btn_jogar_normal;
            img_jogar_high = Properties.Resources.btn_jogar_high;
            // ========== Botao SOBRE
            img_sobre_normal = Properties.Resources.btn_sobre_normal;
            img_sobre_high = Properties.Resources.btn_sobre_high;
            // ========== Botao REFERENCIA
            img_referencias_normal = Properties.Resources.btn_referencias_normal;
            img_referencias_high = Properties.Resources.btn_referencias_high;
            // ========= Botao SAIR
            img_sair_normal = Properties.Resources.btn_sair_normal;
            img_sair_high = Properties.Resources.btn_sair_high;
        }
        
        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            btn_jogar.BackgroundImage = img_jogar_normal; // atribuição da imagem na picturebox ( btn_jogar )
            btn_sobre.BackgroundImage = img_sobre_normal; // atribuição da imagem na picturebox ( btn_sobre )
            btn_referencias.BackgroundImage = img_referencias_normal; // atribuição da imagem na picturebox ( btn_referencia )
            btn_sair.BackgroundImage = img_sair_normal; // atribuição da imagem na picturebox ( btn_sair )
        }



        //==== Botao JOGAR
        private void btn_jogar_Click(object sender, EventArgs e)
        {
            frmTelaNome TelaNome = new frmTelaNome();           
            TelaNome.ShowDialog();
            //frmTelaFinal_QuePena FinalQuePena = new frmTelaFinal_QuePena();
            //FinalQuePena.ShowDialog();
        }
        private void btn_jogar_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_jogar.BackgroundImage = img_jogar_high; //atribuição da imagem na PictureBox ( btn_jogar )
        }        
        private void btn_jogar_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( altera a imagem para normal quando mouse sai da foto )
            btn_jogar.BackgroundImage = img_jogar_normal; // atribuição da imagem na PictureBox ( btn_jogar )
        }



        //==== Botao SOBRE
        private void btn_sobre_Click(object sender, EventArgs e)
        {
            frmTelaSobre TelaSobre = new frmTelaSobre();
            this.Visible = false;
            TelaSobre.ShowDialog();
            this.Close();
        }
        private void btn_sobre_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_sobre.BackgroundImage = img_sobre_high; //atribuição da imagem na PictureBox ( btn_sobre )
        }
        private void btn_sobre_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( altera a imagem para normal quando mouse sai da foto )
            btn_sobre.BackgroundImage = img_sobre_normal; // atribuição da imagem na PictureBox ( btn_sobre )
        }



        //==== Botao REFERENCIAS
        private void btn_referencias_Click(object sender, EventArgs e)
        {
            frmReferencia TelaReferencias = new frmReferencia();
            this.Visible = false;
            TelaReferencias.ShowDialog();
            this.Close();
        }
        private void btn_referencias_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_referencias.BackgroundImage = img_referencias_high; //atribuição da imagem na PictureBox ( btn_referencias )
        }

        private void btn_referencias_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( altera a imagem para normal quando mouse sai da foto )
            btn_referencias.BackgroundImage = img_referencias_normal; // atribuição da imagem na PictureBox ( btn_referencias )
        }



        // ==== Botao SAIR
        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja sair?", "ANAVIQ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (Resposta == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Obrigado por ficar!", "ANAVIQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_sair.BackgroundImage = img_sair_high; //atribuição da imagem na PictureBox ( btn_sair )
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( altera a imagem para normal quando mouse sai da foto )
            btn_sair.BackgroundImage = img_sair_normal; // atribuição da imagem na PictureBox ( btn_sair )
        }

        
    }
}
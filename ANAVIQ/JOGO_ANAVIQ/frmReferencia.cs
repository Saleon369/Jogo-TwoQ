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
    public partial class frmReferencia : Form
    { 
        Image btn_voltar_normal;   // botão normal
        Image btn_voltar_high;     // quando o mouse passa por cima do botão

        Image btn_pg_posterior_normal; // botão normal
        Image btn_pg_posterior_high;   // quando o mouse passa por cima do botão        

        public frmReferencia()
        {
            InitializeComponent();

            btn_voltar_normal = Properties.Resources.btn_voltar_normal;
            btn_voltar_high = Properties.Resources.btn_voltar_high;

            btn_pg_posterior_normal = Properties.Resources.btn_pg_posterior_normal;
            btn_pg_posterior_high = Properties.Resources.btn_pg_posterior_high;

        }

        

        private void frmReferencia_Load(object sender, EventArgs e)
        {
           btn_voltar.BackgroundImage = btn_voltar_normal;  // atribuição da imagem na picturebox ( btn_voltar )
           btn_pg_posterior.BackgroundImage = btn_pg_posterior_normal;           
           
        }

        /// ========= Botão Voltar 
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frmTelaInicial TelaInicial = new frmTelaInicial();
            this.Visible = false;
            TelaInicial.ShowDialog();
            this.Close();
        }       

        private void btn_voltar_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_voltar.BackgroundImage = btn_voltar_high;   // atribuição da imagem na PictureBox ( btn_voltar )
        }

        private void btn_voltar_MouseLeave(object sender, EventArgs e)
        {   // altera a imagem para normal ( quando mouse sai da foto )
            btn_voltar.BackgroundImage = btn_voltar_normal;
        }



        // ==== Botão Pagina Posterior

        private void btn_pg_posterior_Click(object sender, EventArgs e)
        {
            frmReferencia2 Referencia02 = new frmReferencia2();
            this.Visible = false;
            Referencia02.ShowDialog();
            this.Close();

        }

        private void btn_pg_posterior_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_pg_posterior.BackgroundImage = btn_pg_posterior_high;   // atribuição da imagem na PictureBox ( btn_pg_posterior )
        }

        private void btn_pg_posterior_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_pg_posterior.BackgroundImage = btn_pg_posterior_normal;
        }          



        private void ll_ref01_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://portalbiocursos.com.br/ohs/data/docs/14/02_-_Abordagem_fisioterapYutica_e_os_cuidados_especYficos_da_pele_no_indivYduo_queimado.pdf");

        }

        private void ll_ref02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://bvsms.saude.gov.br/contra-queimaduras-prevencao-e-a-vacina-06-6-dia-nacional-de-luta-contra-queimaduras/");

        }

        private void ll_ref03_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.ccb.policiamilitar.sp.gov.br/portalcb/_educacao-publica/midias-edpub/folders/pdf/INCENDIOS.pdf");

        }

        private void ll_ref04_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://rbqueimaduras.com.br/details/35/pt-BR");

        }

        private void ll_ref05_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://periodicos.unievangelica.edu.br/index.php/refacer/article/view/3322/2333");

        }

        private void ll_ref06_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://franciscofelipelaitano.com.br/sol-apos-cirurgia-plastica-quando-e-permitido/");
        }

        private void ll_ref07_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://bvsms.saude.gov.br/bvs/publicacoes/guia_alimentar_populacao_brasileira_2008.pdf");
        }


       
    }
}

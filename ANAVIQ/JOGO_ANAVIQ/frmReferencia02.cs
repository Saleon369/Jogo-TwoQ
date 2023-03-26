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
    public partial class frmReferencia2 : Form
    { 
        Image btn_voltar_normal;   // botão normal
        Image btn_voltar_high;     // quando o mouse passa por cima do botão       

        Image btn_pg_anterior_normal;  // botão normal
        Image btn_pg_anterior_high;    // quando o mouse passa por cima do botão

        public frmReferencia2()
        {
            InitializeComponent();
            
            btn_voltar_normal = Properties.Resources.btn_voltar_normal;
            btn_voltar_high = Properties.Resources.btn_voltar_high;
            btn_pg_anterior_normal = Properties.Resources.btn_pg_anterior_normal;
            btn_pg_anterior_high = Properties.Resources.btn_pg_anterior_high;
        }

        

        private void frmReferencia_Load(object sender, EventArgs e)
        {
           btn_voltar.BackgroundImage = btn_voltar_normal;  // atribuição da imagem na picturebox ( btn_voltar )           
           btn_pg_anterior.BackgroundImage= btn_pg_anterior_normal;
           
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



        // ==== Botão Pagina Anterior
        private void btn_pg_anterior_Click(object sender, EventArgs e)
        {
            frmReferencia Referencia = new frmReferencia();
            this.Visible = false;
            Referencia.ShowDialog();
            this.Close();
            
        }

        private void btn_pg_anterior_MouseEnter(object sender, EventArgs e)
        {
            // altera a imagem para high ( altera a imagem para high quando mouse entra na foto )
            btn_pg_anterior.BackgroundImage = btn_pg_anterior_high;   // atribuição da imagem na PictureBox ( btn_pg_anterior )
        }

        private void btn_pg_anterior_MouseLeave(object sender, EventArgs e)
        {
            // altera a imagem para normal ( quando mouse sai da foto )
            btn_pg_anterior.BackgroundImage = btn_pg_anterior_normal;
        }

        



        private void ll_ref01_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.einstein.br/doencas-sintomas/queimaduras");

        }

        private void ll_ref02_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.hiperbarica.med.br/noticias/detalhes/tipos-de-queimaduras");

        }

        private void ll_ref03_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.fepecs.edu.br/wp-content/uploads/2021/11/Manual-de-Queimaduras-para-Estudantes-2.pdf");

        }

        private void ll_ref04_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.pensaracademico.facig.edu.br/index.php/repositoriotcc/article/view/1828/1441");

        }

        private void ll_ref05_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.sbqueimaduras.org.br/material/1331");

        }

        private void ll_ref06_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.tuasaude.com/alimentos-cicatrizantes/");
        }

        private void ll_ref07_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", " ");
        }


       
    }
}

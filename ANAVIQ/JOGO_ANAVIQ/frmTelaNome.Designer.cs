namespace TwoQ
{
    partial class frmTelaNome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaNome));
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.PictureBox();
            this.btn_continuar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Jost", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(11, 26);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(149, 24);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Digite seu nome: ";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Jost", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnome.Location = new System.Drawing.Point(152, 23);
            this.txtnome.MaxLength = 18;
            this.txtnome.Name = "txtnome";
            this.txtnome.PlaceholderText = "Máximo de 18 caracteres.";
            this.txtnome.Size = new System.Drawing.Size(273, 31);
            this.txtnome.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_continuar);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 73);
            this.panel1.TabIndex = 4;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(243, 20);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(158, 43);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            this.btn_cancelar.MouseEnter += new System.EventHandler(this.btn_cancelar_MouseEnter);
            this.btn_cancelar.MouseLeave += new System.EventHandler(this.btn_cancelar_MouseLeave);
            // 
            // btn_continuar
            // 
            this.btn_continuar.Location = new System.Drawing.Point(12, 20);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(158, 43);
            this.btn_continuar.TabIndex = 0;
            this.btn_continuar.TabStop = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            this.btn_continuar.MouseEnter += new System.EventHandler(this.btn_continuar_MouseEnter);
            this.btn_continuar.MouseLeave += new System.EventHandler(this.btn_continuar_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "teste teste";
            this.textBox1.Size = new System.Drawing.Size(10, 26);
            this.textBox1.TabIndex = 0;
            // 
            // frmTelaNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(450, 171);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTelaNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TwoQ";
            this.Load += new System.EventHandler(this.frmTelaNome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continuar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnome;
        public TextBox txtnome;
        private Panel panel1;
        private PictureBox btn_continuar;
        private PictureBox btn_cancelar;
        private ToolTip toolTip1;
        private TextBox textBox1;
    }
}
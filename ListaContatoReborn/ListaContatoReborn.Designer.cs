namespace ListaContatoReborn
{
    partial class ListaContatoReborn
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.dtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblAniversario = new System.Windows.Forms.Label();
            this.ptbLista2 = new System.Windows.Forms.PictureBox();
            this.ptbLista1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLista2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(447, 42);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(476, 352);
            this.dgvContatos.TabIndex = 2;
            this.dgvContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellContentClick);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(107, 39);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(334, 20);
            this.txbNome.TabIndex = 3;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(107, 94);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(334, 20);
            this.txbTelefone.TabIndex = 4;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(107, 68);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(334, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // dtpAniversario
            // 
            this.dtpAniversario.Location = new System.Drawing.Point(128, 121);
            this.dtpAniversario.Name = "dtpAniversario";
            this.dtpAniversario.Size = new System.Drawing.Size(312, 20);
            this.dtpAniversario.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 144);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(425, 78);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(15, 228);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(425, 78);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(15, 312);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(425, 78);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 101);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblAniversario
            // 
            this.lblAniversario.AutoSize = true;
            this.lblAniversario.Location = new System.Drawing.Point(12, 127);
            this.lblAniversario.Name = "lblAniversario";
            this.lblAniversario.Size = new System.Drawing.Size(110, 13);
            this.lblAniversario.TabIndex = 13;
            this.lblAniversario.Text = " Data de Nascimento:";
            // 
            // ptbLista2
            // 
            this.ptbLista2.Image = global::ListaContatoReborn.Properties.Resources.listacontato_form;
            this.ptbLista2.Location = new System.Drawing.Point(447, 400);
            this.ptbLista2.Name = "ptbLista2";
            this.ptbLista2.Size = new System.Drawing.Size(476, 176);
            this.ptbLista2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLista2.TabIndex = 15;
            this.ptbLista2.TabStop = false;
            // 
            // ptbLista1
            // 
            this.ptbLista1.Image = global::ListaContatoReborn.Properties.Resources.lista_contatos;
            this.ptbLista1.Location = new System.Drawing.Point(15, 400);
            this.ptbLista1.Name = "ptbLista1";
            this.ptbLista1.Size = new System.Drawing.Size(425, 176);
            this.ptbLista1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLista1.TabIndex = 14;
            this.ptbLista1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListaContatoReborn.Properties.Resources.istockphoto_1131230925_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(929, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 20);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Insira os Dados:";
            // 
            // ListaContatoReborn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 588);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ptbLista2);
            this.Controls.Add(this.ptbLista1);
            this.Controls.Add(this.lblAniversario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtpAniversario);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaContatoReborn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLista2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.DateTimePicker dtpAniversario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblAniversario;
        private System.Windows.Forms.PictureBox ptbLista1;
        private System.Windows.Forms.PictureBox ptbLista2;
        private System.Windows.Forms.Label lblTitulo;
    }
}


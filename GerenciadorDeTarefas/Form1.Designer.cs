namespace GerenciadorDeTarefas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.grpAdicionar = new System.Windows.Forms.GroupBox();
            this.lblNomeTarefa = new System.Windows.Forms.Label();
            this.lblNomeSetor = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblDataLimite = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.txbNomeTarefa = new System.Windows.Forms.TextBox();
            this.txbNomeResponsavel = new System.Windows.Forms.TextBox();
            this.grpTarefas = new System.Windows.Forms.GroupBox();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.pibApagar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.grpAdicionar.SuspendLayout();
            this.grpTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibApagar)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = ((System.Drawing.Image)(resources.GetObject("pibLogo.Image")));
            this.pibLogo.Location = new System.Drawing.Point(237, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(130, 114);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(373, 47);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(404, 39);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Gerenciador de Tarefas";
            // 
            // grpAdicionar
            // 
            this.grpAdicionar.Controls.Add(this.txbNomeResponsavel);
            this.grpAdicionar.Controls.Add(this.txbNomeTarefa);
            this.grpAdicionar.Controls.Add(this.dtpLimite);
            this.grpAdicionar.Controls.Add(this.btnAdicionar);
            this.grpAdicionar.Controls.Add(this.lblDataLimite);
            this.grpAdicionar.Controls.Add(this.cmbSetor);
            this.grpAdicionar.Controls.Add(this.lblSetor);
            this.grpAdicionar.Controls.Add(this.lblNomeSetor);
            this.grpAdicionar.Controls.Add(this.lblNomeTarefa);
            this.grpAdicionar.Location = new System.Drawing.Point(12, 146);
            this.grpAdicionar.Name = "grpAdicionar";
            this.grpAdicionar.Size = new System.Drawing.Size(322, 212);
            this.grpAdicionar.TabIndex = 4;
            this.grpAdicionar.TabStop = false;
            this.grpAdicionar.Text = "Adicionar";
            // 
            // lblNomeTarefa
            // 
            this.lblNomeTarefa.AutoSize = true;
            this.lblNomeTarefa.Location = new System.Drawing.Point(48, 34);
            this.lblNomeTarefa.Name = "lblNomeTarefa";
            this.lblNomeTarefa.Size = new System.Drawing.Size(83, 13);
            this.lblNomeTarefa.TabIndex = 4;
            this.lblNomeTarefa.Text = "Nome da tarefa:";
            // 
            // lblNomeSetor
            // 
            this.lblNomeSetor.AutoSize = true;
            this.lblNomeSetor.Location = new System.Drawing.Point(29, 68);
            this.lblNomeSetor.Name = "lblNomeSetor";
            this.lblNomeSetor.Size = new System.Drawing.Size(113, 13);
            this.lblNomeSetor.TabIndex = 6;
            this.lblNomeSetor.Text = "Nome do responsável:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(141, 98);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(121, 21);
            this.cmbSetor.TabIndex = 9;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(96, 104);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(35, 13);
            this.lblSetor.TabIndex = 8;
            this.lblSetor.Text = "Setor:";
            // 
            // lblDataLimite
            // 
            this.lblDataLimite.AutoSize = true;
            this.lblDataLimite.Location = new System.Drawing.Point(73, 130);
            this.lblDataLimite.Name = "lblDataLimite";
            this.lblDataLimite.Size = new System.Drawing.Size(63, 13);
            this.lblDataLimite.TabIndex = 10;
            this.lblDataLimite.Text = "Data Limite:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(23, 165);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(262, 33);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dtpLimite
            // 
            this.dtpLimite.Location = new System.Drawing.Point(140, 125);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(122, 20);
            this.dtpLimite.TabIndex = 13;
            // 
            // txbNomeTarefa
            // 
            this.txbNomeTarefa.Location = new System.Drawing.Point(141, 31);
            this.txbNomeTarefa.Name = "txbNomeTarefa";
            this.txbNomeTarefa.Size = new System.Drawing.Size(121, 20);
            this.txbNomeTarefa.TabIndex = 14;
            // 
            // txbNomeResponsavel
            // 
            this.txbNomeResponsavel.Location = new System.Drawing.Point(141, 65);
            this.txbNomeResponsavel.Name = "txbNomeResponsavel";
            this.txbNomeResponsavel.Size = new System.Drawing.Size(121, 20);
            this.txbNomeResponsavel.TabIndex = 15;
            // 
            // grpTarefas
            // 
            this.grpTarefas.Controls.Add(this.pibApagar);
            this.grpTarefas.Controls.Add(this.dgvTarefas);
            this.grpTarefas.Location = new System.Drawing.Point(380, 146);
            this.grpTarefas.Name = "grpTarefas";
            this.grpTarefas.Size = new System.Drawing.Size(497, 264);
            this.grpTarefas.TabIndex = 5;
            this.grpTarefas.TabStop = false;
            this.grpTarefas.Text = "Tarefas";
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AllowUserToResizeColumns = false;
            this.dgvTarefas.AllowUserToResizeRows = false;
            this.dgvTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(22, 19);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.Size = new System.Drawing.Size(469, 179);
            this.dgvTarefas.TabIndex = 0;
            this.dgvTarefas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellDoubleClick);
            // 
            // pibApagar
            // 
            this.pibApagar.Image = ((System.Drawing.Image)(resources.GetObject("pibApagar.Image")));
            this.pibApagar.Location = new System.Drawing.Point(439, 204);
            this.pibApagar.Name = "pibApagar";
            this.pibApagar.Size = new System.Drawing.Size(52, 47);
            this.pibApagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibApagar.TabIndex = 6;
            this.pibApagar.TabStop = false;
            this.pibApagar.Click += new System.EventHandler(this.pibApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 422);
            this.Controls.Add(this.grpTarefas);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pibLogo);
            this.Controls.Add(this.grpAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerenciador De Tarefas ";
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.grpAdicionar.ResumeLayout(false);
            this.grpAdicionar.PerformLayout();
            this.grpTarefas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibApagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.GroupBox grpAdicionar;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblNomeSetor;
        private System.Windows.Forms.Label lblNomeTarefa;
        private System.Windows.Forms.Label lblDataLimite;
        private System.Windows.Forms.TextBox txbNomeResponsavel;
        private System.Windows.Forms.TextBox txbNomeTarefa;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grpTarefas;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.PictureBox pibApagar;
    }
}


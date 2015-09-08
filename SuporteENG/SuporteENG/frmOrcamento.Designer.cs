namespace SuporteENG
{
    partial class frmOrcamento
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
            this.dtgKit = new System.Windows.Forms.DataGridView();
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdKit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grbKit = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSubsistema = new System.Windows.Forms.ComboBox();
            this.cmbCombinacao = new System.Windows.Forms.ComboBox();
            this.cmbKit = new System.Windows.Forms.ComboBox();
            this.txtIdOrcamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditaProduto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbKit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgKit
            // 
            this.dtgKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKit.Location = new System.Drawing.Point(321, 114);
            this.dtgKit.Name = "dtgKit";
            this.dtgKit.Size = new System.Drawing.Size(273, 149);
            this.dtgKit.TabIndex = 45;
            this.dtgKit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKit_CellContentClick);
            // 
            // dtgVenda
            // 
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Location = new System.Drawing.Point(12, 417);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.Size = new System.Drawing.Size(582, 113);
            this.dtgVenda.TabIndex = 44;
            this.dtgVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVenda_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtIdKit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir Kit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quantidade:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(90, 58);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(85, 20);
            this.txtQtd.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(279, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(292, 20);
            this.txtNome.TabIndex = 40;
            // 
            // txtIdKit
            // 
            this.txtIdKit.Enabled = false;
            this.txtIdKit.Location = new System.Drawing.Point(90, 28);
            this.txtIdKit.Name = "txtIdKit";
            this.txtIdKit.Size = new System.Drawing.Size(85, 20);
            this.txtIdKit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID Kit:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(9, 84);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(562, 23);
            this.btnIncluir.TabIndex = 37;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome Kit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Incluir no Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.cmbCampos);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa Kit";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(140, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(325, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // cmbCampos
            // 
            this.cmbCampos.FormattingEnabled = true;
            this.cmbCampos.ItemHeight = 13;
            this.cmbCampos.Items.AddRange(new object[] {
            "Id Kit",
            "Nome Kit"});
            this.cmbCampos.Location = new System.Drawing.Point(9, 18);
            this.cmbCampos.Name = "cmbCampos";
            this.cmbCampos.Size = new System.Drawing.Size(125, 21);
            this.cmbCampos.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(471, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(214, 536);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(89, 37);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar Orçamento";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(499, 545);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 49;
            this.txtTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Total Geral: R$";
            // 
            // grbKit
            // 
            this.grbKit.Controls.Add(this.btnExportar);
            this.grbKit.Controls.Add(this.label7);
            this.grbKit.Controls.Add(this.label4);
            this.grbKit.Controls.Add(this.label3);
            this.grbKit.Controls.Add(this.cmbSubsistema);
            this.grbKit.Controls.Add(this.cmbCombinacao);
            this.grbKit.Controls.Add(this.cmbKit);
            this.grbKit.Location = new System.Drawing.Point(12, 114);
            this.grbKit.Name = "grbKit";
            this.grbKit.Size = new System.Drawing.Size(303, 149);
            this.grbKit.TabIndex = 3;
            this.grbKit.TabStop = false;
            this.grbKit.Text = "Grupo Kit";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(90, 109);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(128, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar Kit";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Combinação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subsistema:";
            // 
            // cmbSubsistema
            // 
            this.cmbSubsistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubsistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubsistema.FormattingEnabled = true;
            this.cmbSubsistema.ItemHeight = 13;
            this.cmbSubsistema.Location = new System.Drawing.Point(90, 19);
            this.cmbSubsistema.Name = "cmbSubsistema";
            this.cmbSubsistema.Size = new System.Drawing.Size(207, 21);
            this.cmbSubsistema.TabIndex = 1;
            this.cmbSubsistema.SelectionChangeCommitted += new System.EventHandler(this.cmbSubsistema_SelectionChangeCommitted);
            // 
            // cmbCombinacao
            // 
            this.cmbCombinacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCombinacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCombinacao.FormattingEnabled = true;
            this.cmbCombinacao.ItemHeight = 13;
            this.cmbCombinacao.Location = new System.Drawing.Point(90, 46);
            this.cmbCombinacao.Name = "cmbCombinacao";
            this.cmbCombinacao.Size = new System.Drawing.Size(207, 21);
            this.cmbCombinacao.TabIndex = 2;
            this.cmbCombinacao.SelectionChangeCommitted += new System.EventHandler(this.cmbCombinacao_SelectionChangeCommitted);
            // 
            // cmbKit
            // 
            this.cmbKit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKit.FormattingEnabled = true;
            this.cmbKit.ItemHeight = 13;
            this.cmbKit.Location = new System.Drawing.Point(90, 73);
            this.cmbKit.Name = "cmbKit";
            this.cmbKit.Size = new System.Drawing.Size(207, 21);
            this.cmbKit.TabIndex = 3;
            // 
            // txtIdOrcamento
            // 
            this.txtIdOrcamento.Enabled = false;
            this.txtIdOrcamento.Location = new System.Drawing.Point(104, 545);
            this.txtIdOrcamento.Name = "txtIdOrcamento";
            this.txtIdOrcamento.Size = new System.Drawing.Size(80, 20);
            this.txtIdOrcamento.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Id Orçamento:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(93, 23);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(137, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "Cliente:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(309, 536);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 37);
            this.btnNovo.TabIndex = 54;
            this.btnNovo.Text = "Novo Orçamento";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnExcluirProduto);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtQtdProd);
            this.groupBox3.Controls.Add(this.txtNomeProd);
            this.groupBox3.Controls.Add(this.txtIdProd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnEditaProduto);
            this.groupBox3.Location = new System.Drawing.Point(600, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 113);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerencia Alteração";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(123, 80);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(83, 23);
            this.btnExcluirProduto.TabIndex = 56;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Quantidade:";
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.Location = new System.Drawing.Point(210, 28);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(85, 20);
            this.txtQtdProd.TabIndex = 1;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Enabled = false;
            this.txtNomeProd.Location = new System.Drawing.Point(90, 54);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(205, 20);
            this.txtNomeProd.TabIndex = 40;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(90, 28);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(43, 20);
            this.txtIdProd.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "ID Produto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nome Produto:";
            // 
            // btnEditaProduto
            // 
            this.btnEditaProduto.Location = new System.Drawing.Point(34, 80);
            this.btnEditaProduto.Name = "btnEditaProduto";
            this.btnEditaProduto.Size = new System.Drawing.Size(83, 23);
            this.btnEditaProduto.TabIndex = 37;
            this.btnEditaProduto.Text = "Editar";
            this.btnEditaProduto.UseVisualStyleBackColor = true;
            this.btnEditaProduto.Click += new System.EventHandler(this.btnEditaProduto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(212, 80);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 23);
            this.btnLimpar.TabIndex = 57;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdOrcamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbKit);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dtgVenda);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgKit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orcamento";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbKit.ResumeLayout(false);
            this.grbKit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgKit;
        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdKit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbCampos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbKit;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSubsistema;
        private System.Windows.Forms.ComboBox cmbCombinacao;
        private System.Windows.Forms.ComboBox cmbKit;
        private System.Windows.Forms.TextBox txtIdOrcamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQtdProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditaProduto;
        private System.Windows.Forms.Button btnLimpar;

    }
}
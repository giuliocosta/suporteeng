namespace SuporteENG
{
    partial class frmItensKit
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
            this.grbGeren = new System.Windows.Forms.GroupBox();
            this.txtIdItens = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKit = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.cmbKit = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgItensKit = new System.Windows.Forms.DataGridView();
            this.grbGeren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensKit)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGeren
            // 
            this.grbGeren.Controls.Add(this.txtIdItens);
            this.grbGeren.Controls.Add(this.label4);
            this.grbGeren.Controls.Add(this.label2);
            this.grbGeren.Controls.Add(this.txtKit);
            this.grbGeren.Controls.Add(this.txtQtd);
            this.grbGeren.Controls.Add(this.btnExcluir);
            this.grbGeren.Controls.Add(this.btnLimpaCampos);
            this.grbGeren.Controls.Add(this.cmbKit);
            this.grbGeren.Controls.Add(this.btnEditar);
            this.grbGeren.Controls.Add(this.txtProd);
            this.grbGeren.Controls.Add(this.cmbProduto);
            this.grbGeren.Controls.Add(this.btnInserir);
            this.grbGeren.Controls.Add(this.label3);
            this.grbGeren.Controls.Add(this.label1);
            this.grbGeren.Location = new System.Drawing.Point(67, 336);
            this.grbGeren.Name = "grbGeren";
            this.grbGeren.Size = new System.Drawing.Size(391, 178);
            this.grbGeren.TabIndex = 25;
            this.grbGeren.TabStop = false;
            this.grbGeren.Text = "Dados";
            // 
            // txtIdItens
            // 
            this.txtIdItens.Enabled = false;
            this.txtIdItens.Location = new System.Drawing.Point(84, 19);
            this.txtIdItens.Name = "txtIdItens";
            this.txtIdItens.Size = new System.Drawing.Size(47, 20);
            this.txtIdItens.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id Itens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantidade:";
            // 
            // txtKit
            // 
            this.txtKit.Enabled = false;
            this.txtKit.Location = new System.Drawing.Point(296, 45);
            this.txtKit.Name = "txtKit";
            this.txtKit.Size = new System.Drawing.Size(47, 20);
            this.txtKit.TabIndex = 5;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(84, 98);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(47, 20);
            this.txtQtd.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(243, 127);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 39);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.Location = new System.Drawing.Point(194, 98);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(149, 20);
            this.btnLimpaCampos.TabIndex = 8;
            this.btnLimpaCampos.Text = "Limpar Campos";
            this.btnLimpaCampos.UseVisualStyleBackColor = true;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // cmbKit
            // 
            this.cmbKit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKit.FormattingEnabled = true;
            this.cmbKit.ItemHeight = 13;
            this.cmbKit.Location = new System.Drawing.Point(84, 45);
            this.cmbKit.Name = "cmbKit";
            this.cmbKit.Size = new System.Drawing.Size(209, 21);
            this.cmbKit.TabIndex = 20;
            this.cmbKit.SelectedIndexChanged += new System.EventHandler(this.cmbKit_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(134, 127);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 39);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtProd
            // 
            this.txtProd.Enabled = false;
            this.txtProd.Location = new System.Drawing.Point(296, 71);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(47, 20);
            this.txtProd.TabIndex = 19;
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(84, 71);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(209, 21);
            this.cmbProduto.TabIndex = 18;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(23, 127);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 39);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.cmbCampos);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 49);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(137, 20);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(261, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // cmbCampos
            // 
            this.cmbCampos.FormattingEnabled = true;
            this.cmbCampos.ItemHeight = 13;
            this.cmbCampos.Items.AddRange(new object[] {
            "Id Itens",
            "Id Kit",
            "Nome Kit",
            "Id Produto",
            "Nome Produto"});
            this.cmbCampos.Location = new System.Drawing.Point(6, 19);
            this.cmbCampos.Name = "cmbCampos";
            this.cmbCampos.Size = new System.Drawing.Size(125, 21);
            this.cmbCampos.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(404, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtgItensKit
            // 
            this.dtgItensKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensKit.Location = new System.Drawing.Point(12, 67);
            this.dtgItensKit.Name = "dtgItensKit";
            this.dtgItensKit.Size = new System.Drawing.Size(510, 263);
            this.dtgItensKit.TabIndex = 23;
            this.dtgItensKit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItensKit_CellContentClick);
            // 
            // frmItensKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 526);
            this.Controls.Add(this.grbGeren);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgItensKit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmItensKit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens Kit";
            this.Load += new System.EventHandler(this.frmItensKit_Load);
            this.grbGeren.ResumeLayout(false);
            this.grbGeren.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensKit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGeren;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbCampos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgItensKit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtKit;
        private System.Windows.Forms.ComboBox cmbKit;
        private System.Windows.Forms.TextBox txtIdItens;
        private System.Windows.Forms.Label label4;
    }
}
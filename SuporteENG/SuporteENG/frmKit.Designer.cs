namespace SuporteENG
{
    partial class frmKit
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
            this.txtCC = new System.Windows.Forms.TextBox();
            this.cmbCombinacao = new System.Windows.Forms.ComboBox();
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgKit = new System.Windows.Forms.DataGridView();
            this.grbGeren.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKit)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGeren
            // 
            this.grbGeren.Controls.Add(this.txtCC);
            this.grbGeren.Controls.Add(this.cmbCombinacao);
            this.grbGeren.Controls.Add(this.btnLimpaCampos);
            this.grbGeren.Controls.Add(this.txtId);
            this.grbGeren.Controls.Add(this.txtDescricao);
            this.grbGeren.Controls.Add(this.label5);
            this.grbGeren.Controls.Add(this.btnExcluir);
            this.grbGeren.Controls.Add(this.btnEditar);
            this.grbGeren.Controls.Add(this.label3);
            this.grbGeren.Controls.Add(this.btnInserir);
            this.grbGeren.Controls.Add(this.label1);
            this.grbGeren.Location = new System.Drawing.Point(14, 249);
            this.grbGeren.Name = "grbGeren";
            this.grbGeren.Size = new System.Drawing.Size(510, 138);
            this.grbGeren.TabIndex = 22;
            this.grbGeren.TabStop = false;
            this.grbGeren.Text = "Dados";
            // 
            // txtCC
            // 
            this.txtCC.Enabled = false;
            this.txtCC.Location = new System.Drawing.Point(322, 19);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(47, 20);
            this.txtCC.TabIndex = 19;
            // 
            // cmbCombinacao
            // 
            this.cmbCombinacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCombinacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCombinacao.FormattingEnabled = true;
            this.cmbCombinacao.Location = new System.Drawing.Point(375, 19);
            this.cmbCombinacao.Name = "cmbCombinacao";
            this.cmbCombinacao.Size = new System.Drawing.Size(115, 21);
            this.cmbCombinacao.TabIndex = 18;
            this.cmbCombinacao.SelectedIndexChanged += new System.EventHandler(this.cmbCombinacao_SelectedIndexChanged);
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.Location = new System.Drawing.Point(375, 53);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(115, 20);
            this.btnLimpaCampos.TabIndex = 8;
            this.btnLimpaCampos.Text = "Limpar Campos";
            this.btnLimpaCampos.UseVisualStyleBackColor = true;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(66, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(66, 53);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(260, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(349, 89);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(155, 39);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(174, 89);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(161, 39);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(6, 89);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(155, 39);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combinação:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.cmbCampos);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 49);
            this.groupBox1.TabIndex = 21;
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
            "Id",
            "Descrição",
            "Combinação"});
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
            // dtgKit
            // 
            this.dtgKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKit.Location = new System.Drawing.Point(14, 67);
            this.dtgKit.Name = "dtgKit";
            this.dtgKit.Size = new System.Drawing.Size(510, 179);
            this.dtgKit.TabIndex = 20;
            this.dtgKit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKit_CellContentClick);
            // 
            // frmKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 396);
            this.Controls.Add(this.grbGeren);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgKit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kit";
            this.Load += new System.EventHandler(this.frmKit_Load);
            this.grbGeren.ResumeLayout(false);
            this.grbGeren.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGeren;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbCampos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgKit;
        private System.Windows.Forms.ComboBox cmbCombinacao;
        private System.Windows.Forms.TextBox txtCC;
    }
}
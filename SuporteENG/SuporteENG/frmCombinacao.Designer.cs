namespace SuporteENG
{
    partial class frmCombinacao
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
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgCombinacao = new System.Windows.Forms.DataGridView();
            this.txtSubsistema = new System.Windows.Forms.TextBox();
            this.cmbSubsistema = new System.Windows.Forms.ComboBox();
            this.labellero = new System.Windows.Forms.Label();
            this.grbGeren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCombinacao)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGeren
            // 
            this.grbGeren.Controls.Add(this.txtSubsistema);
            this.grbGeren.Controls.Add(this.cmbSubsistema);
            this.grbGeren.Controls.Add(this.labellero);
            this.grbGeren.Controls.Add(this.btnLimpaCampos);
            this.grbGeren.Controls.Add(this.txtId);
            this.grbGeren.Controls.Add(this.btnExcluir);
            this.grbGeren.Controls.Add(this.btnEditar);
            this.grbGeren.Controls.Add(this.label3);
            this.grbGeren.Controls.Add(this.txtDescricao);
            this.grbGeren.Controls.Add(this.btnInserir);
            this.grbGeren.Controls.Add(this.label5);
            this.grbGeren.Location = new System.Drawing.Point(293, 12);
            this.grbGeren.Name = "grbGeren";
            this.grbGeren.Size = new System.Drawing.Size(308, 238);
            this.grbGeren.TabIndex = 22;
            this.grbGeren.TabStop = false;
            this.grbGeren.Text = "Dados";
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.Location = new System.Drawing.Point(155, 19);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(97, 20);
            this.btnLimpaCampos.TabIndex = 8;
            this.btnLimpaCampos.Text = "Limpar Campos";
            this.btnLimpaCampos.UseVisualStyleBackColor = true;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(70, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(81, 191);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(155, 39);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(81, 146);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 39);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(70, 45);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(182, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(81, 101);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(155, 39);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição:";
            // 
            // dtgCombinacao
            // 
            this.dtgCombinacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCombinacao.Location = new System.Drawing.Point(4, 12);
            this.dtgCombinacao.Name = "dtgCombinacao";
            this.dtgCombinacao.Size = new System.Drawing.Size(283, 238);
            this.dtgCombinacao.TabIndex = 20;
            this.dtgCombinacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCombinacao_CellContentClick);
            // 
            // txtSubsistema
            // 
            this.txtSubsistema.Enabled = false;
            this.txtSubsistema.Location = new System.Drawing.Point(258, 71);
            this.txtSubsistema.Name = "txtSubsistema";
            this.txtSubsistema.Size = new System.Drawing.Size(40, 20);
            this.txtSubsistema.TabIndex = 21;
            // 
            // cmbSubsistema
            // 
            this.cmbSubsistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubsistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubsistema.FormattingEnabled = true;
            this.cmbSubsistema.ItemHeight = 13;
            this.cmbSubsistema.Location = new System.Drawing.Point(71, 71);
            this.cmbSubsistema.Name = "cmbSubsistema";
            this.cmbSubsistema.Size = new System.Drawing.Size(181, 21);
            this.cmbSubsistema.TabIndex = 23;
            this.cmbSubsistema.SelectedIndexChanged += new System.EventHandler(this.cmbSubsistema_SelectedIndexChanged);
            // 
            // labellero
            // 
            this.labellero.AutoSize = true;
            this.labellero.Location = new System.Drawing.Point(0, 79);
            this.labellero.Name = "labellero";
            this.labellero.Size = new System.Drawing.Size(64, 13);
            this.labellero.TabIndex = 22;
            this.labellero.Text = "Subsistema:";
            // 
            // frmCombinacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 255);
            this.Controls.Add(this.grbGeren);
            this.Controls.Add(this.dtgCombinacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCombinacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combinação";
            this.Load += new System.EventHandler(this.frmCombinacao_Load);
            this.grbGeren.ResumeLayout(false);
            this.grbGeren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCombinacao)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgCombinacao;
        private System.Windows.Forms.TextBox txtSubsistema;
        private System.Windows.Forms.ComboBox cmbSubsistema;
        private System.Windows.Forms.Label labellero;
    }
}
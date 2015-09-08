namespace SuporteENG
{
    partial class frmSubsistema
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgSubsistema = new System.Windows.Forms.DataGridView();
            this.grbGeren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubsistema)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGeren
            // 
            this.grbGeren.Controls.Add(this.btnLimpaCampos);
            this.grbGeren.Controls.Add(this.txtId);
            this.grbGeren.Controls.Add(this.btnExcluir);
            this.grbGeren.Controls.Add(this.btnEditar);
            this.grbGeren.Controls.Add(this.label3);
            this.grbGeren.Controls.Add(this.txtNome);
            this.grbGeren.Controls.Add(this.btnInserir);
            this.grbGeren.Controls.Add(this.label5);
            this.grbGeren.Location = new System.Drawing.Point(262, 12);
            this.grbGeren.Name = "grbGeren";
            this.grbGeren.Size = new System.Drawing.Size(273, 210);
            this.grbGeren.TabIndex = 24;
            this.grbGeren.TabStop = false;
            this.grbGeren.Text = "Dados";
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.Location = new System.Drawing.Point(157, 19);
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
            this.txtId.Location = new System.Drawing.Point(72, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(72, 165);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(155, 39);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(72, 120);
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
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(72, 75);
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
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome:";
            // 
            // dtgSubsistema
            // 
            this.dtgSubsistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSubsistema.Location = new System.Drawing.Point(12, 12);
            this.dtgSubsistema.Name = "dtgSubsistema";
            this.dtgSubsistema.Size = new System.Drawing.Size(244, 210);
            this.dtgSubsistema.TabIndex = 23;
            this.dtgSubsistema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSubsistema_CellContentClick);
            // 
            // frmSubsistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 233);
            this.Controls.Add(this.grbGeren);
            this.Controls.Add(this.dtgSubsistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSubsistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subsistema";
            this.Load += new System.EventHandler(this.frmSubsistema_Load);
            this.grbGeren.ResumeLayout(false);
            this.grbGeren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubsistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGeren;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgSubsistema;

    }
}
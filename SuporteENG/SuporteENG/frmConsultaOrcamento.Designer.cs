namespace SuporteENG
{
    partial class frmConsultaOrcamento
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.datePesquisa = new System.Windows.Forms.DateTimePicker();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtgOrcamento = new System.Windows.Forms.DataGridView();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.txtVTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtIdOrcamento = new System.Windows.Forms.TextBox();
            this.btnPesID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgItensOr = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrcamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensOr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCampos);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.datePesquisa);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 149);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa Orçamento";
            // 
            // cmbCampos
            // 
            this.cmbCampos.FormattingEnabled = true;
            this.cmbCampos.ItemHeight = 13;
            this.cmbCampos.Items.AddRange(new object[] {
            "Nome Cliente",
            "Data"});
            this.cmbCampos.Location = new System.Drawing.Point(9, 29);
            this.cmbCampos.Name = "cmbCampos";
            this.cmbCampos.Size = new System.Drawing.Size(209, 21);
            this.cmbCampos.TabIndex = 1;
            this.cmbCampos.SelectedIndexChanged += new System.EventHandler(this.cmbCampos_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(9, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(209, 29);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // datePesquisa
            // 
            this.datePesquisa.Location = new System.Drawing.Point(9, 56);
            this.datePesquisa.Name = "datePesquisa";
            this.datePesquisa.Size = new System.Drawing.Size(209, 20);
            this.datePesquisa.TabIndex = 4;
            this.datePesquisa.Value = new System.DateTime(2015, 4, 27, 0, 0, 0, 0);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(9, 56);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(209, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // dtgOrcamento
            // 
            this.dtgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrcamento.Location = new System.Drawing.Point(242, 12);
            this.dtgOrcamento.Name = "dtgOrcamento";
            this.dtgOrcamento.Size = new System.Drawing.Size(352, 149);
            this.dtgOrcamento.TabIndex = 57;
            this.dtgOrcamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOrcamento_CellContentClick);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(220, 215);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(89, 34);
            this.btnExportarExcel.TabIndex = 65;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // txtVTotal
            // 
            this.txtVTotal.Enabled = false;
            this.txtVTotal.Location = new System.Drawing.Point(382, 223);
            this.txtVTotal.Name = "txtVTotal";
            this.txtVTotal.Size = new System.Drawing.Size(94, 20);
            this.txtVTotal.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Valor Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtVTotal);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdOrcamento);
            this.groupBox1.Controls.Add(this.btnExportarExcel);
            this.groupBox1.Controls.Add(this.btnPesID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtgItensOr);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 255);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamento";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(354, 49);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(64, 20);
            this.txtData.TabIndex = 77;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(105, 49);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(204, 20);
            this.txtCliente.TabIndex = 76;
            // 
            // txtIdOrcamento
            // 
            this.txtIdOrcamento.Location = new System.Drawing.Point(105, 22);
            this.txtIdOrcamento.Name = "txtIdOrcamento";
            this.txtIdOrcamento.Size = new System.Drawing.Size(70, 20);
            this.txtIdOrcamento.TabIndex = 75;
            // 
            // btnPesID
            // 
            this.btnPesID.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPesID.Location = new System.Drawing.Point(177, 20);
            this.btnPesID.Name = "btnPesID";
            this.btnPesID.Size = new System.Drawing.Size(18, 23);
            this.btnPesID.TabIndex = 70;
            this.btnPesID.UseVisualStyleBackColor = true;
            this.btnPesID.Click += new System.EventHandler(this.btnPesID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Id Orçamento:";
            // 
            // dtgItensOr
            // 
            this.dtgItensOr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensOr.Location = new System.Drawing.Point(21, 75);
            this.dtgItensOr.Name = "dtgItensOr";
            this.dtgItensOr.Size = new System.Drawing.Size(539, 134);
            this.dtgItensOr.TabIndex = 71;
            // 
            // frmConsultaOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Orçamento";
            this.Load += new System.EventHandler(this.frmConsultaOrcamento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrcamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensOr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbCampos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgOrcamento;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.DateTimePicker datePesquisa;
        private System.Windows.Forms.TextBox txtVTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtIdOrcamento;
        private System.Windows.Forms.Button btnPesID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgItensOr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
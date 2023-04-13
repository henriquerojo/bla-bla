namespace TintSysDesk
{
    partial class FrmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.txtUnid = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.clnSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.label4);
            this.grbDados.Controls.Add(this.cmbUsuario);
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.cmbCliente);
            this.grbDados.Controls.Add(this.btnInserir);
            this.grbDados.Enabled = false;
            this.grbDados.Location = new System.Drawing.Point(31, 118);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(630, 80);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Atendente";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(316, 35);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(60, 35);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(173, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(517, 33);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDO Nº";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(534, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(127, 31);
            this.txtId.TabIndex = 2;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.txtUnid);
            this.grbProduto.Controls.Add(this.txtQuantidade);
            this.grbProduto.Controls.Add(this.label6);
            this.grbProduto.Controls.Add(this.label7);
            this.grbProduto.Controls.Add(this.label10);
            this.grbProduto.Controls.Add(this.label8);
            this.grbProduto.Controls.Add(this.label9);
            this.grbProduto.Controls.Add(this.label5);
            this.grbProduto.Controls.Add(this.txtDesconto);
            this.grbProduto.Controls.Add(this.txtPreco);
            this.grbProduto.Controls.Add(this.txtDescricao);
            this.grbProduto.Controls.Add(this.txtIdProd);
            this.grbProduto.Controls.Add(this.btnAdicionar);
            this.grbProduto.Enabled = false;
            this.grbProduto.Location = new System.Drawing.Point(31, 214);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(630, 75);
            this.grbProduto.TabIndex = 0;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Produtos";
            // 
            // txtUnid
            // 
            this.txtUnid.Location = new System.Drawing.Point(306, 35);
            this.txtUnid.Name = "txtUnid";
            this.txtUnid.ReadOnly = true;
            this.txtUnid.Size = new System.Drawing.Size(38, 20);
            this.txtUnid.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(424, 35);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(49, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Und";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Desconto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Preço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Qtd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Código";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(479, 35);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(64, 20);
            this.txtDesconto.TabIndex = 2;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(352, 35);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(64, 20);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(105, 35);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(193, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(18, 35);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(79, 20);
            this.txtIdProd.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(549, 32);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSeq,
            this.clnCodigo,
            this.clnDescricao,
            this.clnUnidade,
            this.clnPreco,
            this.clnQtd,
            this.clnDesconto,
            this.clnTotal});
            this.dgvItens.Location = new System.Drawing.Point(31, 308);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(630, 168);
            this.dgvItens.TabIndex = 3;
            // 
            // clnSeq
            // 
            this.clnSeq.Frozen = true;
            this.clnSeq.HeaderText = "#";
            this.clnSeq.Name = "clnSeq";
            this.clnSeq.ReadOnly = true;
            this.clnSeq.Width = 20;
            // 
            // clnCodigo
            // 
            this.clnCodigo.Frozen = true;
            this.clnCodigo.HeaderText = "Cód";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 70;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 190;
            // 
            // clnUnidade
            // 
            this.clnUnidade.Frozen = true;
            this.clnUnidade.HeaderText = "Un";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnPreco
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clnPreco.DefaultCellStyle = dataGridViewCellStyle1;
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "Preço R$";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            this.clnPreco.Width = 80;
            // 
            // clnQtd
            // 
            this.clnQtd.Frozen = true;
            this.clnQtd.HeaderText = "Qtd";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.Width = 60;
            // 
            // clnDesconto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clnDesconto.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "Desconto";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            this.clnDesconto.Width = 60;
            // 
            // clnTotal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.clnTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnTotal.Frozen = true;
            this.clnTotal.HeaderText = "Total R$";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL R$";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(488, 482);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(173, 31);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(586, 89);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "+Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(695, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(21, 24);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "_";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 615);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.grbDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtUnid;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
    }
}

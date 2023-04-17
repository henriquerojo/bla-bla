namespace TintSysDesk
{
    partial class frmCliente
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
            this.tbcClientes = new System.Windows.Forms.TabControl();
            this.tpgDados = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpgEnderecos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tpgTelefones = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cln_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_datacad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbcClientes.SuspendLayout();
            this.tpgDados.SuspendLayout();
            this.tpgEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcClientes
            // 
            this.tbcClientes.Controls.Add(this.tpgDados);
            this.tbcClientes.Controls.Add(this.tpgEnderecos);
            this.tbcClientes.Controls.Add(this.tpgTelefones);
            this.tbcClientes.Location = new System.Drawing.Point(209, 41);
            this.tbcClientes.Name = "tbcClientes";
            this.tbcClientes.SelectedIndex = 0;
            this.tbcClientes.Size = new System.Drawing.Size(707, 222);
            this.tbcClientes.TabIndex = 0;
            // 
            // tpgDados
            // 
            this.tpgDados.Controls.Add(this.button3);
            this.tpgDados.Controls.Add(this.mktCpf);
            this.tpgDados.Controls.Add(this.button2);
            this.tpgDados.Controls.Add(this.btnInserir);
            this.tpgDados.Controls.Add(this.label4);
            this.tpgDados.Controls.Add(this.label3);
            this.tpgDados.Controls.Add(this.label2);
            this.tpgDados.Controls.Add(this.checkBox1);
            this.tpgDados.Controls.Add(this.txtEmail);
            this.tpgDados.Controls.Add(this.txtNome);
            this.tpgDados.Controls.Add(this.txtID);
            this.tpgDados.Controls.Add(this.label1);
            this.tpgDados.Location = new System.Drawing.Point(4, 22);
            this.tpgDados.Name = "tpgDados";
            this.tpgDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDados.Size = new System.Drawing.Size(699, 196);
            this.tpgDados.TabIndex = 0;
            this.tpgDados.Text = "Dados Pessoais";
            this.tpgDados.UseVisualStyleBackColor = true;
            this.tpgDados.Click += new System.EventHandler(this.tpgDados_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(58, 97);
            this.mktCpf.Mask = "000.000.000-00";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(100, 20);
            this.mktCpf.TabIndex = 24;
            this.mktCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mktCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(146, 167);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(242, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(58, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(32, 20);
            this.txtID.TabIndex = 15;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tpgEnderecos
            // 
            this.tpgEnderecos.Controls.Add(this.button1);
            this.tpgEnderecos.Location = new System.Drawing.Point(4, 22);
            this.tpgEnderecos.Name = "tpgEnderecos";
            this.tpgEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEnderecos.Size = new System.Drawing.Size(391, 196);
            this.tpgEnderecos.TabIndex = 1;
            this.tpgEnderecos.Text = "Endereços";
            this.tpgEnderecos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpgTelefones
            // 
            this.tpgTelefones.Location = new System.Drawing.Point(4, 22);
            this.tpgTelefones.Name = "tpgTelefones";
            this.tpgTelefones.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTelefones.Size = new System.Drawing.Size(391, 196);
            this.tpgTelefones.TabIndex = 2;
            this.tpgTelefones.Text = "Telefones";
            this.tpgTelefones.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_ID,
            this.cln_nome,
            this.cln_cpf,
            this.cln_email,
            this.cln_datacad,
            this.cln_ativo});
            this.dataGridView1.Location = new System.Drawing.Point(258, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(602, 226);
            this.dataGridView1.TabIndex = 1;
            // 
            // cln_ID
            // 
            this.cln_ID.Frozen = true;
            this.cln_ID.HeaderText = "ID";
            this.cln_ID.Name = "cln_ID";
            this.cln_ID.ReadOnly = true;
            // 
            // cln_nome
            // 
            this.cln_nome.Frozen = true;
            this.cln_nome.HeaderText = "NOME";
            this.cln_nome.Name = "cln_nome";
            this.cln_nome.ReadOnly = true;
            // 
            // cln_cpf
            // 
            this.cln_cpf.Frozen = true;
            this.cln_cpf.HeaderText = "CPF";
            this.cln_cpf.Name = "cln_cpf";
            this.cln_cpf.ReadOnly = true;
            // 
            // cln_email
            // 
            this.cln_email.Frozen = true;
            this.cln_email.HeaderText = "EMAIL";
            this.cln_email.Name = "cln_email";
            this.cln_email.ReadOnly = true;
            // 
            // cln_datacad
            // 
            this.cln_datacad.Frozen = true;
            this.cln_datacad.HeaderText = "DATACAD";
            this.cln_datacad.Name = "cln_datacad";
            this.cln_datacad.ReadOnly = true;
            // 
            // cln_ativo
            // 
            this.cln_ativo.Frozen = true;
            this.cln_ativo.HeaderText = "ATIVO";
            this.cln_ativo.Name = "cln_ativo";
            this.cln_ativo.ReadOnly = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbcClientes);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tbcClientes.ResumeLayout(false);
            this.tpgDados.ResumeLayout(false);
            this.tpgDados.PerformLayout();
            this.tpgEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcClientes;
        private System.Windows.Forms.TabPage tpgDados;
        private System.Windows.Forms.TabPage tpgEnderecos;
        private System.Windows.Forms.TabPage tpgTelefones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_datacad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cln_ativo;
    }
}
namespace TintSysDesk
{
    partial class FrmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserirNivel = new System.Windows.Forms.Button();
            this.btnConsultarNivel = new System.Windows.Forms.Button();
            this.btnEditarNivel = new System.Windows.Forms.Button();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvNiveis = new System.Windows.Forms.DataGridView();
            this.clnIDNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSiglaNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeleteNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(175, 219);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(255, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 20);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(255, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(255, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(255, 119);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(82, 20);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(439, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nível";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 270);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSigla);
            this.groupBox1.Controls.Add(this.txtNomeNivel);
            this.groupBox1.Controls.Add(this.txtIdNivel);
            this.groupBox1.Controls.Add(this.btnEditarNivel);
            this.groupBox1.Controls.Add(this.btnConsultarNivel);
            this.groupBox1.Controls.Add(this.btnInserirNivel);
            this.groupBox1.Location = new System.Drawing.Point(542, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 215);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Níveis";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInserirNivel
            // 
            this.btnInserirNivel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserirNivel.FlatAppearance.BorderSize = 0;
            this.btnInserirNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnInserirNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInserirNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNivel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInserirNivel.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserirNivel.Location = new System.Drawing.Point(22, 166);
            this.btnInserirNivel.Name = "btnInserirNivel";
            this.btnInserirNivel.Size = new System.Drawing.Size(93, 43);
            this.btnInserirNivel.TabIndex = 0;
            this.btnInserirNivel.Text = "Inserir";
            this.btnInserirNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserirNivel.UseVisualStyleBackColor = true;
            this.btnInserirNivel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultarNivel
            // 
            this.btnConsultarNivel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarNivel.FlatAppearance.BorderSize = 0;
            this.btnConsultarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnConsultarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNivel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnConsultarNivel.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultarNivel.Location = new System.Drawing.Point(165, 166);
            this.btnConsultarNivel.Name = "btnConsultarNivel";
            this.btnConsultarNivel.Size = new System.Drawing.Size(93, 43);
            this.btnConsultarNivel.TabIndex = 1;
            this.btnConsultarNivel.Text = "Consultar";
            this.btnConsultarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarNivel.UseVisualStyleBackColor = true;
            this.btnConsultarNivel.Click += new System.EventHandler(this.btnConsultarNivel_Click);
            // 
            // btnEditarNivel
            // 
            this.btnEditarNivel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarNivel.FlatAppearance.BorderSize = 0;
            this.btnEditarNivel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnEditarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNivel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditarNivel.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditarNivel.Location = new System.Drawing.Point(303, 166);
            this.btnEditarNivel.Name = "btnEditarNivel";
            this.btnEditarNivel.Size = new System.Drawing.Size(90, 43);
            this.btnEditarNivel.TabIndex = 2;
            this.btnEditarNivel.Text = "Editar";
            this.btnEditarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarNivel.UseVisualStyleBackColor = true;
            this.btnEditarNivel.Click += new System.EventHandler(this.btnEditarNivel_Click);
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(67, 49);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(63, 20);
            this.txtIdNivel.TabIndex = 3;
            this.txtIdNivel.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(67, 76);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(173, 20);
            this.txtNomeNivel.TabIndex = 4;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(67, 102);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(63, 20);
            this.txtSigla.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sigla";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgvNiveis
            // 
            this.dgvNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIDNivel,
            this.clnNomeNivel,
            this.clnSiglaNivel,
            this.clnDeleteNivel});
            this.dgvNiveis.Location = new System.Drawing.Point(542, 261);
            this.dgvNiveis.Name = "dgvNiveis";
            this.dgvNiveis.RowHeadersVisible = false;
            this.dgvNiveis.Size = new System.Drawing.Size(362, 150);
            this.dgvNiveis.TabIndex = 16;
            this.dgvNiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // clnIDNivel
            // 
            this.clnIDNivel.HeaderText = "ID";
            this.clnIDNivel.Name = "clnIDNivel";
            this.clnIDNivel.ReadOnly = true;
            this.clnIDNivel.Width = 80;
            // 
            // clnNomeNivel
            // 
            this.clnNomeNivel.HeaderText = "Nome";
            this.clnNomeNivel.Name = "clnNomeNivel";
            // 
            // clnSiglaNivel
            // 
            this.clnSiglaNivel.HeaderText = "Sigla";
            this.clnSiglaNivel.Name = "clnSiglaNivel";
            // 
            // clnDeleteNivel
            // 
            this.clnDeleteNivel.HeaderText = "Ação";
            this.clnDeleteNivel.Name = "clnDeleteNivel";
            this.clnDeleteNivel.ReadOnly = true;
            this.clnDeleteNivel.Width = 79;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 558);
            this.Controls.Add(this.dgvNiveis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "Administração de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.Button btnEditarNivel;
        private System.Windows.Forms.Button btnConsultarNivel;
        private System.Windows.Forms.Button btnInserirNivel;
        private System.Windows.Forms.DataGridView dgvNiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIDNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSiglaNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDeleteNivel;
    }
}
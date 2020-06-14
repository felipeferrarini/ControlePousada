namespace controlePousada
{
    partial class Frm_clienteCriar
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
            this.rb_cpf = new System.Windows.Forms.RadioButton();
            this.rb_cnpj = new System.Windows.Forms.RadioButton();
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.btn_salvarReserva = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.np_desconto = new System.Windows.Forms.NumericUpDown();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lp_estado = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_social = new System.Windows.Forms.Label();
            this.txt_social = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.gb_pessoal = new System.Windows.Forms.GroupBox();
            this.gb_endereco = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).BeginInit();
            this.gb_tipo.SuspendLayout();
            this.gb_pessoal.SuspendLayout();
            this.gb_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_cpf
            // 
            this.rb_cpf.AutoSize = true;
            this.rb_cpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cpf.Location = new System.Drawing.Point(15, 29);
            this.rb_cpf.Name = "rb_cpf";
            this.rb_cpf.Size = new System.Drawing.Size(52, 20);
            this.rb_cpf.TabIndex = 69;
            this.rb_cpf.TabStop = true;
            this.rb_cpf.Text = "CPF";
            this.rb_cpf.UseVisualStyleBackColor = true;
            this.rb_cpf.CheckedChanged += new System.EventHandler(this.rb_cpf_CheckedChanged);
            // 
            // rb_cnpj
            // 
            this.rb_cnpj.AutoSize = true;
            this.rb_cnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cnpj.Location = new System.Drawing.Point(132, 29);
            this.rb_cnpj.Name = "rb_cnpj";
            this.rb_cnpj.Size = new System.Drawing.Size(60, 20);
            this.rb_cnpj.TabIndex = 70;
            this.rb_cnpj.TabStop = true;
            this.rb_cnpj.Text = "CNPJ";
            this.rb_cnpj.UseVisualStyleBackColor = true;
            this.rb_cnpj.CheckedChanged += new System.EventHandler(this.rb_cnpj_CheckedChanged);
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_cancelarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarReserva.FlatAppearance.BorderSize = 0;
            this.btn_cancelarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarReserva.ForeColor = System.Drawing.Color.White;
            this.btn_cancelarReserva.Location = new System.Drawing.Point(666, 500);
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelarReserva.TabIndex = 100;
            this.btn_cancelarReserva.Text = "Cancelar";
            this.btn_cancelarReserva.UseVisualStyleBackColor = false;
            this.btn_cancelarReserva.Click += new System.EventHandler(this.btn_cancelarReserva_Click);
            // 
            // btn_salvarReserva
            // 
            this.btn_salvarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_salvarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarReserva.FlatAppearance.BorderSize = 0;
            this.btn_salvarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_salvarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarReserva.ForeColor = System.Drawing.Color.White;
            this.btn_salvarReserva.Location = new System.Drawing.Point(503, 500);
            this.btn_salvarReserva.Name = "btn_salvarReserva";
            this.btn_salvarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_salvarReserva.TabIndex = 99;
            this.btn_salvarReserva.Text = "Salvar";
            this.btn_salvarReserva.UseVisualStyleBackColor = false;
            this.btn_salvarReserva.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(16, 48);
            this.txt_cliente.Mask = "000,000,000-00";
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(140, 25);
            this.txt_cliente.TabIndex = 87;
            this.txt_cliente.Leave += new System.EventHandler(this.txt_cliente_Leave);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(164, 83);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(52, 16);
            this.lb_email.TabIndex = 78;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(167, 104);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(274, 25);
            this.txt_email.TabIndex = 77;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.Location = new System.Drawing.Point(13, 80);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(57, 16);
            this.lb_cidade.TabIndex = 76;
            this.lb_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(17, 100);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(353, 25);
            this.txt_cidade.TabIndex = 75;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(13, 83);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(67, 16);
            this.lb_telefone.TabIndex = 74;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cliente.Location = new System.Drawing.Point(13, 28);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(76, 16);
            this.lb_cliente.TabIndex = 71;
            this.lb_cliente.Text = "CPF/CNPJ:";
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.BackColor = System.Drawing.Color.Transparent;
            this.lb_desconto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desconto.ForeColor = System.Drawing.Color.White;
            this.lb_desconto.Location = new System.Drawing.Point(53, 437);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(234, 16);
            this.lb_desconto.TabIndex = 88;
            this.lb_desconto.Text = "Taxa de Desconto nas Reservas (%):";
            // 
            // np_desconto
            // 
            this.np_desconto.Enabled = false;
            this.np_desconto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_desconto.Location = new System.Drawing.Point(56, 457);
            this.np_desconto.Name = "np_desconto";
            this.np_desconto.Size = new System.Drawing.Size(180, 25);
            this.np_desconto.TabIndex = 89;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(15, 30);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(86, 16);
            this.lb_endereco.TabIndex = 103;
            this.lb_endereco.Text = "Logradouro:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_logradouro.Location = new System.Drawing.Point(16, 50);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(354, 25);
            this.txt_logradouro.TabIndex = 102;
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.Location = new System.Drawing.Point(374, 30);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(51, 16);
            this.lb_bairro.TabIndex = 105;
            this.lb_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(376, 50);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(345, 25);
            this.txt_bairro.TabIndex = 104;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(374, 80);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(54, 16);
            this.lb_estado.TabIndex = 107;
            this.lb_estado.Text = "Estado:";
            // 
            // lp_estado
            // 
            this.lp_estado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_estado.FormattingEnabled = true;
            this.lp_estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.lp_estado.Location = new System.Drawing.Point(376, 100);
            this.lp_estado.Name = "lp_estado";
            this.lp_estado.Size = new System.Drawing.Size(345, 25);
            this.lp_estado.TabIndex = 108;
            this.lp_estado.Text = "Selecione";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(166, 48);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(275, 25);
            this.txt_nome.TabIndex = 72;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(164, 28);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(118, 16);
            this.lb_nome.TabIndex = 73;
            this.lb_nome.Text = "Nome do Cliente:";
            // 
            // lb_social
            // 
            this.lb_social.AutoSize = true;
            this.lb_social.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_social.Location = new System.Drawing.Point(444, 28);
            this.lb_social.Name = "lb_social";
            this.lb_social.Size = new System.Drawing.Size(96, 16);
            this.lb_social.TabIndex = 110;
            this.lb_social.Text = "Razão Social:";
            // 
            // txt_social
            // 
            this.txt_social.Enabled = false;
            this.txt_social.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_social.Location = new System.Drawing.Point(447, 48);
            this.txt_social.Name = "txt_social";
            this.txt_social.Size = new System.Drawing.Size(274, 25);
            this.txt_social.TabIndex = 109;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(16, 103);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(140, 25);
            this.txt_telefone.TabIndex = 111;
            // 
            // gb_tipo
            // 
            this.gb_tipo.BackColor = System.Drawing.Color.Transparent;
            this.gb_tipo.Controls.Add(this.rb_cnpj);
            this.gb_tipo.Controls.Add(this.rb_cpf);
            this.gb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_tipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_tipo.ForeColor = System.Drawing.Color.White;
            this.gb_tipo.Location = new System.Drawing.Point(39, 34);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(759, 65);
            this.gb_tipo.TabIndex = 112;
            this.gb_tipo.TabStop = false;
            this.gb_tipo.Text = "Tipo de Cliente";
            // 
            // gb_pessoal
            // 
            this.gb_pessoal.BackColor = System.Drawing.Color.Transparent;
            this.gb_pessoal.Controls.Add(this.lb_cliente);
            this.gb_pessoal.Controls.Add(this.txt_nome);
            this.gb_pessoal.Controls.Add(this.txt_telefone);
            this.gb_pessoal.Controls.Add(this.lb_nome);
            this.gb_pessoal.Controls.Add(this.lb_social);
            this.gb_pessoal.Controls.Add(this.lb_telefone);
            this.gb_pessoal.Controls.Add(this.txt_social);
            this.gb_pessoal.Controls.Add(this.txt_email);
            this.gb_pessoal.Controls.Add(this.lb_email);
            this.gb_pessoal.Controls.Add(this.txt_cliente);
            this.gb_pessoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_pessoal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_pessoal.ForeColor = System.Drawing.Color.White;
            this.gb_pessoal.Location = new System.Drawing.Point(39, 107);
            this.gb_pessoal.Name = "gb_pessoal";
            this.gb_pessoal.Size = new System.Drawing.Size(760, 159);
            this.gb_pessoal.TabIndex = 113;
            this.gb_pessoal.TabStop = false;
            this.gb_pessoal.Text = "Dados Pessoais";
            // 
            // gb_endereco
            // 
            this.gb_endereco.BackColor = System.Drawing.Color.Transparent;
            this.gb_endereco.Controls.Add(this.txt_logradouro);
            this.gb_endereco.Controls.Add(this.txt_cidade);
            this.gb_endereco.Controls.Add(this.lb_cidade);
            this.gb_endereco.Controls.Add(this.lp_estado);
            this.gb_endereco.Controls.Add(this.lb_endereco);
            this.gb_endereco.Controls.Add(this.lb_estado);
            this.gb_endereco.Controls.Add(this.txt_bairro);
            this.gb_endereco.Controls.Add(this.lb_bairro);
            this.gb_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_endereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_endereco.ForeColor = System.Drawing.Color.White;
            this.gb_endereco.Location = new System.Drawing.Point(39, 275);
            this.gb_endereco.Name = "gb_endereco";
            this.gb_endereco.Size = new System.Drawing.Size(760, 152);
            this.gb_endereco.TabIndex = 114;
            this.gb_endereco.TabStop = false;
            this.gb_endereco.Text = "Endereço";
            // 
            // Frm_clienteCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ControlePousada.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.gb_endereco);
            this.Controls.Add(this.gb_pessoal);
            this.Controls.Add(this.gb_tipo);
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.btn_salvarReserva);
            this.Controls.Add(this.np_desconto);
            this.Controls.Add(this.lb_desconto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_clienteCriar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_cadastroCliente";
            this.Load += new System.EventHandler(this.Frm_clienteCriar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).EndInit();
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            this.gb_pessoal.ResumeLayout(false);
            this.gb_pessoal.PerformLayout();
            this.gb_endereco.ResumeLayout(false);
            this.gb_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_cpf;
        private System.Windows.Forms.RadioButton rb_cnpj;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.MaskedTextBox txt_cliente;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_cancelarReserva;
        private System.Windows.Forms.Button btn_salvarReserva;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.NumericUpDown np_desconto;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.ComboBox lp_estado;
        private System.Windows.Forms.Label lb_social;
        private System.Windows.Forms.TextBox txt_social;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.GroupBox gb_tipo;
        private System.Windows.Forms.GroupBox gb_pessoal;
        private System.Windows.Forms.GroupBox gb_endereco;
    }
}
namespace WindowsFormsApp1
{
    partial class Frm_cadastroCliente
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
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.btn_salvarReserva = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.rb_cpf = new System.Windows.Forms.RadioButton();
            this.rb_cnpj = new System.Windows.Forms.RadioButton();
            this.lb_tipo = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarReserva.Location = new System.Drawing.Point(572, 470);
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelarReserva.TabIndex = 70;
            this.btn_cancelarReserva.Text = "Cancelar";
            this.btn_cancelarReserva.UseVisualStyleBackColor = true;
            this.btn_cancelarReserva.Click += new System.EventHandler(this.btn_cancelarReserva_Click);
            // 
            // btn_salvarReserva
            // 
            this.btn_salvarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarReserva.Location = new System.Drawing.Point(409, 470);
            this.btn_salvarReserva.Name = "btn_salvarReserva";
            this.btn_salvarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_salvarReserva.TabIndex = 69;
            this.btn_salvarReserva.Text = "Salvar";
            this.btn_salvarReserva.UseVisualStyleBackColor = true;
            this.btn_salvarReserva.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(47, 149);
            this.txt_cliente.Mask = "000.000.000-00";
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(140, 20);
            this.txt_cliente.TabIndex = 87;
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            this.txt_cliente.Leave += new System.EventHandler(this.txt_cliente_Leave);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(194, 189);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(38, 13);
            this.lb_email.TabIndex = 78;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(196, 205);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(197, 20);
            this.txt_email.TabIndex = 77;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(193, 242);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(43, 13);
            this.lb_cidade.TabIndex = 76;
            this.lb_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(196, 258);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(197, 20);
            this.txt_cidade.TabIndex = 75;
            this.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(44, 188);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(52, 13);
            this.lb_telefone.TabIndex = 74;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(45, 133);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(62, 13);
            this.lb_cliente.TabIndex = 71;
            this.lb_cliente.Text = "CPF/CNPJ:";
            // 
            // rb_cpf
            // 
            this.rb_cpf.AutoSize = true;
            this.rb_cpf.Location = new System.Drawing.Point(47, 80);
            this.rb_cpf.Name = "rb_cpf";
            this.rb_cpf.Size = new System.Drawing.Size(45, 17);
            this.rb_cpf.TabIndex = 99;
            this.rb_cpf.TabStop = true;
            this.rb_cpf.Text = "CPF";
            this.rb_cpf.UseVisualStyleBackColor = true;
            this.rb_cpf.CheckedChanged += new System.EventHandler(this.rb_cpf_CheckedChanged);
            // 
            // rb_cnpj
            // 
            this.rb_cnpj.AutoSize = true;
            this.rb_cnpj.Location = new System.Drawing.Point(174, 80);
            this.rb_cnpj.Name = "rb_cnpj";
            this.rb_cnpj.Size = new System.Drawing.Size(52, 17);
            this.rb_cnpj.TabIndex = 100;
            this.rb_cnpj.TabStop = true;
            this.rb_cnpj.Text = "CNPJ";
            this.rb_cnpj.UseVisualStyleBackColor = true;
            this.rb_cnpj.CheckedChanged += new System.EventHandler(this.rb_cnpj_CheckedChanged);
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Location = new System.Drawing.Point(44, 54);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(137, 13);
            this.lb_tipo.TabIndex = 101;
            this.lb_tipo.Text = "Selecione o Tipo de Cliente";
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Location = new System.Drawing.Point(46, 344);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(183, 13);
            this.lb_desconto.TabIndex = 88;
            this.lb_desconto.Text = "Taxa de Desconto nas Reservas (%):";
            // 
            // np_desconto
            // 
            this.np_desconto.Location = new System.Drawing.Point(47, 362);
            this.np_desconto.Name = "np_desconto";
            this.np_desconto.ReadOnly = true;
            this.np_desconto.Size = new System.Drawing.Size(180, 20);
            this.np_desconto.TabIndex = 89;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Location = new System.Drawing.Point(397, 189);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(64, 13);
            this.lb_endereco.TabIndex = 103;
            this.lb_endereco.Text = "Logradouro:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(399, 205);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(282, 20);
            this.txt_logradouro.TabIndex = 102;
            this.txt_logradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Location = new System.Drawing.Point(45, 243);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(37, 13);
            this.lb_bairro.TabIndex = 105;
            this.lb_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(47, 259);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(139, 20);
            this.txt_bairro.TabIndex = 104;
            this.txt_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(396, 241);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(43, 13);
            this.lb_estado.TabIndex = 107;
            this.lb_estado.Text = "Estado:";
            // 
            // lp_estado
            // 
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
            this.lp_estado.Location = new System.Drawing.Point(399, 257);
            this.lp_estado.Name = "lp_estado";
            this.lp_estado.Size = new System.Drawing.Size(108, 21);
            this.lp_estado.TabIndex = 108;
            this.lp_estado.Text = "Selecione";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(197, 149);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 20);
            this.txt_nome.TabIndex = 72;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(195, 133);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(88, 13);
            this.lb_nome.TabIndex = 73;
            this.lb_nome.Text = "Nome do Cliente:";
            // 
            // lb_social
            // 
            this.lb_social.AutoSize = true;
            this.lb_social.Location = new System.Drawing.Point(434, 133);
            this.lb_social.Name = "lb_social";
            this.lb_social.Size = new System.Drawing.Size(73, 13);
            this.lb_social.TabIndex = 110;
            this.lb_social.Text = "Razão Social:";
            // 
            // txt_social
            // 
            this.txt_social.Location = new System.Drawing.Point(436, 149);
            this.txt_social.Name = "txt_social";
            this.txt_social.Size = new System.Drawing.Size(245, 20);
            this.txt_social.TabIndex = 109;
            this.txt_social.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(47, 204);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(139, 20);
            this.txt_telefone.TabIndex = 111;
            // 
            // Frm_cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lb_social);
            this.Controls.Add(this.txt_social);
            this.Controls.Add(this.lp_estado);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.lb_bairro);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lb_endereco);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.lb_tipo);
            this.Controls.Add(this.rb_cnpj);
            this.Controls.Add(this.rb_cpf);
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.btn_salvarReserva);
            this.Controls.Add(this.np_desconto);
            this.Controls.Add(this.lb_desconto);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_cidade);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lb_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_cadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_cadastroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelarReserva;
        private System.Windows.Forms.Button btn_salvarReserva;
        private System.Windows.Forms.MaskedTextBox txt_cliente;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.RadioButton rb_cpf;
        private System.Windows.Forms.RadioButton rb_cnpj;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.NumericUpDown np_desconto;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.ComboBox lp_estado;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_social;
        private System.Windows.Forms.TextBox txt_social;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
    }
}
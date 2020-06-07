namespace WindowsFormsApp1
{
    partial class Frm_main
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
            this.btn_novaReserva = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_novaReserva = new System.Windows.Forms.GroupBox();
            this.txt_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lp_feriado = new System.Windows.Forms.ComboBox();
            this.cb_feriado = new System.Windows.Forms.CheckBox();
            this.np_qtdPessoas = new System.Windows.Forms.NumericUpDown();
            this.lb_qtdPessoas = new System.Windows.Forms.Label();
            this.lb_saida = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_entrada = new System.Windows.Forms.Label();
            this.dtp_entrada = new System.Windows.Forms.DateTimePicker();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_newCliente = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.np_desconto = new System.Windows.Forms.NumericUpDown();
            this.lb_valorBase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.btn_consultCliente = new System.Windows.Forms.Button();
            this.gb_novaReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novaReserva
            // 
            this.btn_novaReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novaReserva.Location = new System.Drawing.Point(12, 46);
            this.btn_novaReserva.Name = "btn_novaReserva";
            this.btn_novaReserva.Size = new System.Drawing.Size(158, 52);
            this.btn_novaReserva.TabIndex = 0;
            this.btn_novaReserva.Text = "Nova Reserva";
            this.btn_novaReserva.UseVisualStyleBackColor = true;
            this.btn_novaReserva.Click += new System.EventHandler(this.btn_novaReserva_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(623, 507);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(132, 38);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(786, 507);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            // 
            // gb_novaReserva
            // 
            this.gb_novaReserva.Controls.Add(this.btn_consultCliente);
            this.gb_novaReserva.Controls.Add(this.txt_telefone);
            this.gb_novaReserva.Controls.Add(this.lb_valor);
            this.gb_novaReserva.Controls.Add(this.textBox2);
            this.gb_novaReserva.Controls.Add(this.textBox1);
            this.gb_novaReserva.Controls.Add(this.lb_valorBase);
            this.gb_novaReserva.Controls.Add(this.np_desconto);
            this.gb_novaReserva.Controls.Add(this.lb_desconto);
            this.gb_novaReserva.Controls.Add(this.txt_cliente);
            this.gb_novaReserva.Controls.Add(this.lp_feriado);
            this.gb_novaReserva.Controls.Add(this.cb_feriado);
            this.gb_novaReserva.Controls.Add(this.np_qtdPessoas);
            this.gb_novaReserva.Controls.Add(this.lb_qtdPessoas);
            this.gb_novaReserva.Controls.Add(this.lb_saida);
            this.gb_novaReserva.Controls.Add(this.dateTimePicker1);
            this.gb_novaReserva.Controls.Add(this.lb_entrada);
            this.gb_novaReserva.Controls.Add(this.dtp_entrada);
            this.gb_novaReserva.Controls.Add(this.lb_email);
            this.gb_novaReserva.Controls.Add(this.txt_email);
            this.gb_novaReserva.Controls.Add(this.lb_cidade);
            this.gb_novaReserva.Controls.Add(this.txt_cidade);
            this.gb_novaReserva.Controls.Add(this.lb_telefone);
            this.gb_novaReserva.Controls.Add(this.lb_nome);
            this.gb_novaReserva.Controls.Add(this.txt_nome);
            this.gb_novaReserva.Controls.Add(this.lb_cliente);
            this.gb_novaReserva.Controls.Add(this.lb_numero);
            this.gb_novaReserva.Controls.Add(this.txt_numero);
            this.gb_novaReserva.Location = new System.Drawing.Point(225, 46);
            this.gb_novaReserva.Name = "gb_novaReserva";
            this.gb_novaReserva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_novaReserva.Size = new System.Drawing.Size(693, 455);
            this.gb_novaReserva.TabIndex = 3;
            this.gb_novaReserva.TabStop = false;
            this.gb_novaReserva.Visible = false;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(9, 114);
            this.txt_cliente.Mask = "000.000.000-00";
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(136, 20);
            this.txt_cliente.TabIndex = 21;
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // lp_feriado
            // 
            this.lp_feriado.Enabled = false;
            this.lp_feriado.FormattingEnabled = true;
            this.lp_feriado.Items.AddRange(new object[] {
            "Carnaval",
            "Páscoa",
            "Corpus Christ",
            "Natal",
            "Reveion"});
            this.lp_feriado.Location = new System.Drawing.Point(182, 225);
            this.lp_feriado.Name = "lp_feriado";
            this.lp_feriado.Size = new System.Drawing.Size(168, 21);
            this.lp_feriado.TabIndex = 20;
            this.lp_feriado.Text = "Selecione";
            // 
            // cb_feriado
            // 
            this.cb_feriado.AutoSize = true;
            this.cb_feriado.Location = new System.Drawing.Point(183, 208);
            this.cb_feriado.Name = "cb_feriado";
            this.cb_feriado.Size = new System.Drawing.Size(67, 17);
            this.cb_feriado.TabIndex = 19;
            this.cb_feriado.Text = "Feriado?";
            this.cb_feriado.UseVisualStyleBackColor = true;
            this.cb_feriado.CheckedChanged += new System.EventHandler(this.cb_feriado_CheckedChanged);
            // 
            // np_qtdPessoas
            // 
            this.np_qtdPessoas.Location = new System.Drawing.Point(10, 226);
            this.np_qtdPessoas.Name = "np_qtdPessoas";
            this.np_qtdPessoas.Size = new System.Drawing.Size(166, 20);
            this.np_qtdPessoas.TabIndex = 17;
            // 
            // lb_qtdPessoas
            // 
            this.lb_qtdPessoas.AutoSize = true;
            this.lb_qtdPessoas.Location = new System.Drawing.Point(7, 209);
            this.lb_qtdPessoas.Name = "lb_qtdPessoas";
            this.lb_qtdPessoas.Size = new System.Drawing.Size(123, 13);
            this.lb_qtdPessoas.TabIndex = 16;
            this.lb_qtdPessoas.Text = "Quantidade de Pessoas:";
            // 
            // lb_saida
            // 
            this.lb_saida.AutoSize = true;
            this.lb_saida.Location = new System.Drawing.Point(500, 154);
            this.lb_saida.Name = "lb_saida";
            this.lb_saida.Size = new System.Drawing.Size(77, 13);
            this.lb_saida.TabIndex = 15;
            this.lb_saida.Text = "Data de Saída";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(503, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lb_entrada
            // 
            this.lb_entrada.AutoSize = true;
            this.lb_entrada.Location = new System.Drawing.Point(353, 154);
            this.lb_entrada.Name = "lb_entrada";
            this.lb_entrada.Size = new System.Drawing.Size(85, 13);
            this.lb_entrada.TabIndex = 13;
            this.lb_entrada.Text = "Data de Entrada";
            // 
            // dtp_entrada
            // 
            this.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrada.Location = new System.Drawing.Point(356, 170);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.Size = new System.Drawing.Size(141, 20);
            this.dtp_entrada.TabIndex = 12;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(181, 154);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(38, 13);
            this.lb_email.TabIndex = 11;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(183, 170);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(167, 20);
            this.txt_email.TabIndex = 10;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(7, 154);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(43, 13);
            this.lb_cidade.TabIndex = 9;
            this.lb_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(9, 170);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(167, 20);
            this.txt_cidade.TabIndex = 8;
            this.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(500, 98);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(52, 13);
            this.lb_telefone.TabIndex = 7;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(180, 98);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(88, 13);
            this.lb_nome.TabIndex = 5;
            this.lb_nome.Text = "Nome do Cliente:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(182, 114);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(315, 20);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(7, 98);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(62, 13);
            this.lb_cliente.TabIndex = 3;
            this.lb_cliente.Text = "CPF/CNPJ:";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(6, 16);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(105, 13);
            this.lb_numero.TabIndex = 1;
            this.lb_numero.Text = "Número da Reserva:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(9, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 0;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_reserva
            // 
            this.btn_reserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva.Location = new System.Drawing.Point(12, 104);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(158, 50);
            this.btn_reserva.TabIndex = 6;
            this.btn_reserva.Text = "Consultar/Editar Reserva";
            this.btn_reserva.UseVisualStyleBackColor = true;
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financeiro.Location = new System.Drawing.Point(12, 160);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(158, 50);
            this.btn_financeiro.TabIndex = 7;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_config
            // 
            this.btn_config.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.Location = new System.Drawing.Point(12, 399);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(158, 38);
            this.btn_config.TabIndex = 8;
            this.btn_config.Text = "Configurações";
            this.btn_config.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(12, 507);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(78, 38);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_newCliente
            // 
            this.btn_newCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCliente.Location = new System.Drawing.Point(12, 216);
            this.btn_newCliente.Name = "btn_newCliente";
            this.btn_newCliente.Size = new System.Drawing.Size(158, 50);
            this.btn_newCliente.TabIndex = 10;
            this.btn_newCliente.Text = "Cadastrar Cliente";
            this.btn_newCliente.UseVisualStyleBackColor = true;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(12, 272);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(158, 50);
            this.btn_cliente.TabIndex = 11;
            this.btn_cliente.Text = "Consultar/Editar Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Location = new System.Drawing.Point(500, 210);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(73, 13);
            this.lb_desconto.TabIndex = 24;
            this.lb_desconto.Text = "Desconto (%):";
            // 
            // np_desconto
            // 
            this.np_desconto.Location = new System.Drawing.Point(503, 225);
            this.np_desconto.Name = "np_desconto";
            this.np_desconto.Size = new System.Drawing.Size(140, 20);
            this.np_desconto.TabIndex = 25;
            // 
            // lb_valorBase
            // 
            this.lb_valorBase.AutoSize = true;
            this.lb_valorBase.Location = new System.Drawing.Point(353, 211);
            this.lb_valorBase.Name = "lb_valorBase";
            this.lb_valorBase.Size = new System.Drawing.Size(84, 13);
            this.lb_valorBase.TabIndex = 26;
            this.lb_valorBase.Text = "Valor Base (R$):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "650,00";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 364);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(7, 367);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(84, 13);
            this.lb_valor.TabIndex = 29;
            this.lb_valor.Text = "Valor Total (R$):";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(503, 115);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.ReadOnly = true;
            this.txt_telefone.Size = new System.Drawing.Size(140, 20);
            this.txt_telefone.TabIndex = 30;
            // 
            // btn_consultCliente
            // 
            this.btn_consultCliente.Location = new System.Drawing.Point(151, 113);
            this.btn_consultCliente.Name = "btn_consultCliente";
            this.btn_consultCliente.Size = new System.Drawing.Size(25, 23);
            this.btn_consultCliente.TabIndex = 31;
            this.btn_consultCliente.Text = "->";
            this.btn_consultCliente.UseVisualStyleBackColor = true;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_newCliente);
            this.Controls.Add(this.btn_financeiro);
            this.Controls.Add(this.btn_reserva);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gb_novaReserva);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novaReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Pousada";
            this.gb_novaReserva.ResumeLayout(false);
            this.gb_novaReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_novaReserva;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gb_novaReserva;
        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_newCliente;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DateTimePicker dtp_entrada;
        private System.Windows.Forms.Label lb_saida;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_entrada;
        private System.Windows.Forms.NumericUpDown np_qtdPessoas;
        private System.Windows.Forms.Label lb_qtdPessoas;
        private System.Windows.Forms.ComboBox lp_feriado;
        private System.Windows.Forms.CheckBox cb_feriado;
        private System.Windows.Forms.MaskedTextBox txt_cliente;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_valorBase;
        private System.Windows.Forms.NumericUpDown np_desconto;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Button btn_consultCliente;
    }
}
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
            this.btn_reserva = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_newCliente = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.dtp_entrada = new System.Windows.Forms.DateTimePicker();
            this.lb_entrada = new System.Windows.Forms.Label();
            this.dtp_saida = new System.Windows.Forms.DateTimePicker();
            this.lb_saida = new System.Windows.Forms.Label();
            this.lb_qtdPessoas = new System.Windows.Forms.Label();
            this.np_qtdPessoas = new System.Windows.Forms.NumericUpDown();
            this.cb_feriado = new System.Windows.Forms.CheckBox();
            this.lp_feriado = new System.Windows.Forms.ComboBox();
            this.txt_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.np_desconto = new System.Windows.Forms.NumericUpDown();
            this.lb_valorBase = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_salvarReserva = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.lb_valor = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.btn_consultCliente = new System.Windows.Forms.Button();
            this.cb_pagamento = new System.Windows.Forms.CheckBox();
            this.dtp_dataPag = new System.Windows.Forms.DateTimePicker();
            this.lb_DataPag = new System.Windows.Forms.Label();
            this.gb_novaReserva = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).BeginInit();
            this.gb_novaReserva.SuspendLayout();
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
            this.btn_newCliente.Click += new System.EventHandler(this.btn_newCliente_Click);
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
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(9, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 0;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(7, 98);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(62, 13);
            this.lb_cliente.TabIndex = 3;
            this.lb_cliente.Text = "CPF/CNPJ:";
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
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(180, 98);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(88, 13);
            this.lb_nome.TabIndex = 5;
            this.lb_nome.Text = "Nome do Cliente:";
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
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(9, 170);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(167, 20);
            this.txt_cidade.TabIndex = 8;
            this.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(183, 170);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(167, 20);
            this.txt_email.TabIndex = 10;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // dtp_entrada
            // 
            this.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrada.Location = new System.Drawing.Point(356, 170);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.Size = new System.Drawing.Size(141, 20);
            this.dtp_entrada.TabIndex = 12;
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
            // dtp_saida
            // 
            this.dtp_saida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_saida.Location = new System.Drawing.Point(503, 170);
            this.dtp_saida.Name = "dtp_saida";
            this.dtp_saida.Size = new System.Drawing.Size(140, 20);
            this.dtp_saida.TabIndex = 14;
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
            // lb_qtdPessoas
            // 
            this.lb_qtdPessoas.AutoSize = true;
            this.lb_qtdPessoas.Location = new System.Drawing.Point(7, 209);
            this.lb_qtdPessoas.Name = "lb_qtdPessoas";
            this.lb_qtdPessoas.Size = new System.Drawing.Size(123, 13);
            this.lb_qtdPessoas.TabIndex = 16;
            this.lb_qtdPessoas.Text = "Quantidade de Pessoas:";
            // 
            // np_qtdPessoas
            // 
            this.np_qtdPessoas.Location = new System.Drawing.Point(10, 226);
            this.np_qtdPessoas.Name = "np_qtdPessoas";
            this.np_qtdPessoas.Size = new System.Drawing.Size(166, 20);
            this.np_qtdPessoas.TabIndex = 17;
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
            this.textBox1.Text = "700,00";
            // 
            // btn_salvarReserva
            // 
            this.btn_salvarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarReserva.Location = new System.Drawing.Point(392, 455);
            this.btn_salvarReserva.Name = "btn_salvarReserva";
            this.btn_salvarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_salvarReserva.TabIndex = 1;
            this.btn_salvarReserva.Text = "Salvar";
            this.btn_salvarReserva.UseVisualStyleBackColor = true;
            this.btn_salvarReserva.Click += new System.EventHandler(this.btn_salvarReserva_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(97, 364);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 28;
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarReserva.Location = new System.Drawing.Point(555, 455);
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelarReserva.TabIndex = 2;
            this.btn_cancelarReserva.Text = "Cancelar";
            this.btn_cancelarReserva.UseVisualStyleBackColor = true;
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
            // cb_pagamento
            // 
            this.cb_pagamento.AutoSize = true;
            this.cb_pagamento.Location = new System.Drawing.Point(410, 348);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(84, 17);
            this.cb_pagamento.TabIndex = 32;
            this.cb_pagamento.Text = "Valor Pago?";
            this.cb_pagamento.UseVisualStyleBackColor = true;
            this.cb_pagamento.CheckedChanged += new System.EventHandler(this.cb_pagamento_CheckedChanged);
            // 
            // dtp_dataPag
            // 
            this.dtp_dataPag.Enabled = false;
            this.dtp_dataPag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPag.Location = new System.Drawing.Point(503, 364);
            this.dtp_dataPag.Name = "dtp_dataPag";
            this.dtp_dataPag.Size = new System.Drawing.Size(140, 20);
            this.dtp_dataPag.TabIndex = 33;
            // 
            // lb_DataPag
            // 
            this.lb_DataPag.AutoSize = true;
            this.lb_DataPag.Location = new System.Drawing.Point(500, 348);
            this.lb_DataPag.Name = "lb_DataPag";
            this.lb_DataPag.Size = new System.Drawing.Size(102, 13);
            this.lb_DataPag.TabIndex = 34;
            this.lb_DataPag.Text = "Data do Pagamento";
            // 
            // gb_novaReserva
            // 
            this.gb_novaReserva.Controls.Add(this.lb_DataPag);
            this.gb_novaReserva.Controls.Add(this.dtp_dataPag);
            this.gb_novaReserva.Controls.Add(this.cb_pagamento);
            this.gb_novaReserva.Controls.Add(this.btn_consultCliente);
            this.gb_novaReserva.Controls.Add(this.txt_telefone);
            this.gb_novaReserva.Controls.Add(this.lb_valor);
            this.gb_novaReserva.Controls.Add(this.btn_cancelarReserva);
            this.gb_novaReserva.Controls.Add(this.txt_valor);
            this.gb_novaReserva.Controls.Add(this.btn_salvarReserva);
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
            this.gb_novaReserva.Controls.Add(this.dtp_saida);
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
            this.gb_novaReserva.Size = new System.Drawing.Size(693, 499);
            this.gb_novaReserva.TabIndex = 3;
            this.gb_novaReserva.TabStop = false;
            this.gb_novaReserva.Visible = false;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.gb_novaReserva);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_newCliente);
            this.Controls.Add(this.btn_financeiro);
            this.Controls.Add(this.btn_reserva);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_novaReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Pousada";
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).EndInit();
            this.gb_novaReserva.ResumeLayout(false);
            this.gb_novaReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_novaReserva;
        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_newCliente;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.DateTimePicker dtp_entrada;
        private System.Windows.Forms.Label lb_entrada;
        private System.Windows.Forms.DateTimePicker dtp_saida;
        private System.Windows.Forms.Label lb_saida;
        private System.Windows.Forms.Label lb_qtdPessoas;
        private System.Windows.Forms.NumericUpDown np_qtdPessoas;
        private System.Windows.Forms.CheckBox cb_feriado;
        private System.Windows.Forms.ComboBox lp_feriado;
        private System.Windows.Forms.MaskedTextBox txt_cliente;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.NumericUpDown np_desconto;
        private System.Windows.Forms.Label lb_valorBase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_salvarReserva;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_cancelarReserva;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Button btn_consultCliente;
        private System.Windows.Forms.CheckBox cb_pagamento;
        private System.Windows.Forms.DateTimePicker dtp_dataPag;
        private System.Windows.Forms.Label lb_DataPag;
        private System.Windows.Forms.GroupBox gb_novaReserva;
    }
}
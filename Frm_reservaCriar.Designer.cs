namespace controlePousada
{
    partial class Frm_reservaCriar
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
            this.lb_DataPag = new System.Windows.Forms.Label();
            this.dtp_dataPag = new System.Windows.Forms.DateTimePicker();
            this.cb_pagamento = new System.Windows.Forms.CheckBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvarReserva = new System.Windows.Forms.Button();
            this.lb_valorBase = new System.Windows.Forms.Label();
            this.np_desconto = new System.Windows.Forms.NumericUpDown();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lp_feriado = new System.Windows.Forms.ComboBox();
            this.cb_feriado = new System.Windows.Forms.CheckBox();
            this.np_qtdPessoas = new System.Windows.Forms.NumericUpDown();
            this.lb_qtdPessoas = new System.Windows.Forms.Label();
            this.lb_saida = new System.Windows.Forms.Label();
            this.dtp_saida = new System.Windows.Forms.DateTimePicker();
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
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.gb_gerais = new System.Windows.Forms.GroupBox();
            this.btn_consultCliente = new System.Windows.Forms.Button();
            this.gb_financeiro = new System.Windows.Forms.GroupBox();
            this.txt_valor = new System.Windows.Forms.NumericUpDown();
            this.txt_valorBase = new System.Windows.Forms.NumericUpDown();
            this.lb_numero = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.RichTextBox();
            this.gb_obs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).BeginInit();
            this.gb_gerais.SuspendLayout();
            this.gb_financeiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorBase)).BeginInit();
            this.gb_obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_DataPag
            // 
            this.lb_DataPag.AutoSize = true;
            this.lb_DataPag.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lb_DataPag.Location = new System.Drawing.Point(15, 118);
            this.lb_DataPag.Name = "lb_DataPag";
            this.lb_DataPag.Size = new System.Drawing.Size(123, 16);
            this.lb_DataPag.TabIndex = 66;
            this.lb_DataPag.Text = "Data do Pagamento";
            // 
            // dtp_dataPag
            // 
            this.dtp_dataPag.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_dataPag.Enabled = false;
            this.dtp_dataPag.Font = new System.Drawing.Font("Arial", 11.25F);
            this.dtp_dataPag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPag.Location = new System.Drawing.Point(140, 111);
            this.dtp_dataPag.Name = "dtp_dataPag";
            this.dtp_dataPag.Size = new System.Drawing.Size(163, 25);
            this.dtp_dataPag.TabIndex = 65;
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.AutoSize = true;
            this.cb_pagamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pagamento.Location = new System.Drawing.Point(16, 88);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(105, 20);
            this.cb_pagamento.TabIndex = 64;
            this.cb_pagamento.Text = "Valor Pago?";
            this.cb_pagamento.UseVisualStyleBackColor = true;
            this.cb_pagamento.CheckedChanged += new System.EventHandler(this.cb_pagamento_CheckedChanged);
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.White;
            this.txt_telefone.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_telefone.Location = new System.Drawing.Point(16, 98);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.ReadOnly = true;
            this.txt_telefone.Size = new System.Drawing.Size(168, 25);
            this.txt_telefone.TabIndex = 62;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.Location = new System.Drawing.Point(513, 118);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(108, 16);
            this.lb_valor.TabIndex = 61;
            this.lb_valor.Text = "Valor Total (R$):";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(666, 500);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelar.TabIndex = 38;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelarReserva_Click);
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
            this.btn_salvarReserva.TabIndex = 37;
            this.btn_salvarReserva.Text = "Salvar";
            this.btn_salvarReserva.UseVisualStyleBackColor = false;
            this.btn_salvarReserva.Click += new System.EventHandler(this.btn_salvarReserva_Click);
            // 
            // lb_valorBase
            // 
            this.lb_valorBase.AutoSize = true;
            this.lb_valorBase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valorBase.Location = new System.Drawing.Point(249, 28);
            this.lb_valorBase.Name = "lb_valorBase";
            this.lb_valorBase.Size = new System.Drawing.Size(108, 16);
            this.lb_valorBase.TabIndex = 58;
            this.lb_valorBase.Text = "Valor Base (R$):";
            // 
            // np_desconto
            // 
            this.np_desconto.BackColor = System.Drawing.Color.White;
            this.np_desconto.Font = new System.Drawing.Font("Arial", 11.25F);
            this.np_desconto.Location = new System.Drawing.Point(579, 49);
            this.np_desconto.Name = "np_desconto";
            this.np_desconto.Size = new System.Drawing.Size(140, 25);
            this.np_desconto.TabIndex = 57;
            this.np_desconto.ValueChanged += new System.EventHandler(this.np_desconto_ValueChanged);
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desconto.Location = new System.Drawing.Point(576, 30);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(92, 16);
            this.lb_desconto.TabIndex = 56;
            this.lb_desconto.Text = "Desconto (%):";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.White;
            this.txt_cliente.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_cliente.Location = new System.Drawing.Point(18, 47);
            this.txt_cliente.Mask = "000,000,000-00";
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(136, 25);
            this.txt_cliente.TabIndex = 55;
            this.txt_cliente.Click += new System.EventHandler(this.txt_cliente_Click);
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // lp_feriado
            // 
            this.lp_feriado.BackColor = System.Drawing.Color.White;
            this.lp_feriado.Enabled = false;
            this.lp_feriado.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lp_feriado.FormattingEnabled = true;
            this.lp_feriado.Location = new System.Drawing.Point(16, 48);
            this.lp_feriado.Name = "lp_feriado";
            this.lp_feriado.Size = new System.Drawing.Size(230, 25);
            this.lp_feriado.TabIndex = 54;
            this.lp_feriado.Text = "Selecione";
            this.lp_feriado.SelectedIndexChanged += new System.EventHandler(this.lp_feriado_SelectedIndexChanged);
            // 
            // cb_feriado
            // 
            this.cb_feriado.AutoSize = true;
            this.cb_feriado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_feriado.Location = new System.Drawing.Point(16, 26);
            this.cb_feriado.Name = "cb_feriado";
            this.cb_feriado.Size = new System.Drawing.Size(84, 20);
            this.cb_feriado.TabIndex = 53;
            this.cb_feriado.Text = "Feriado?";
            this.cb_feriado.UseVisualStyleBackColor = true;
            this.cb_feriado.CheckedChanged += new System.EventHandler(this.cb_feriado_CheckedChanged);
            // 
            // np_qtdPessoas
            // 
            this.np_qtdPessoas.BackColor = System.Drawing.Color.White;
            this.np_qtdPessoas.Font = new System.Drawing.Font("Arial", 11.25F);
            this.np_qtdPessoas.Location = new System.Drawing.Point(413, 48);
            this.np_qtdPessoas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.np_qtdPessoas.Name = "np_qtdPessoas";
            this.np_qtdPessoas.Size = new System.Drawing.Size(160, 25);
            this.np_qtdPessoas.TabIndex = 52;
            this.np_qtdPessoas.ValueChanged += new System.EventHandler(this.np_qtdPessoas_ValueChanged);
            // 
            // lb_qtdPessoas
            // 
            this.lb_qtdPessoas.AutoSize = true;
            this.lb_qtdPessoas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdPessoas.Location = new System.Drawing.Point(412, 29);
            this.lb_qtdPessoas.Name = "lb_qtdPessoas";
            this.lb_qtdPessoas.Size = new System.Drawing.Size(161, 16);
            this.lb_qtdPessoas.TabIndex = 51;
            this.lb_qtdPessoas.Text = "Quantidade de Pessoas:";
            // 
            // lb_saida
            // 
            this.lb_saida.AutoSize = true;
            this.lb_saida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saida.Location = new System.Drawing.Point(187, 132);
            this.lb_saida.Name = "lb_saida";
            this.lb_saida.Size = new System.Drawing.Size(98, 16);
            this.lb_saida.TabIndex = 50;
            this.lb_saida.Text = "Data de Saída";
            // 
            // dtp_saida
            // 
            this.dtp_saida.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_saida.Font = new System.Drawing.Font("Arial", 11.25F);
            this.dtp_saida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_saida.Location = new System.Drawing.Point(190, 151);
            this.dtp_saida.Name = "dtp_saida";
            this.dtp_saida.Size = new System.Drawing.Size(163, 25);
            this.dtp_saida.TabIndex = 49;
            // 
            // lb_entrada
            // 
            this.lb_entrada.AutoSize = true;
            this.lb_entrada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_entrada.Location = new System.Drawing.Point(13, 132);
            this.lb_entrada.Name = "lb_entrada";
            this.lb_entrada.Size = new System.Drawing.Size(110, 16);
            this.lb_entrada.TabIndex = 48;
            this.lb_entrada.Text = "Data de Entrada";
            // 
            // dtp_entrada
            // 
            this.dtp_entrada.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_entrada.Font = new System.Drawing.Font("Arial", 11.25F);
            this.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrada.Location = new System.Drawing.Point(16, 151);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.Size = new System.Drawing.Size(168, 25);
            this.dtp_entrada.TabIndex = 47;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_email.Location = new System.Drawing.Point(458, 79);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(52, 16);
            this.lb_email.TabIndex = 46;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_email.Location = new System.Drawing.Point(460, 98);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(259, 25);
            this.txt_email.TabIndex = 45;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.Location = new System.Drawing.Point(189, 79);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(57, 16);
            this.lb_cidade.TabIndex = 44;
            this.lb_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.Color.White;
            this.txt_cidade.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_cidade.Location = new System.Drawing.Point(191, 98);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(263, 25);
            this.txt_cidade.TabIndex = 43;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(13, 79);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(67, 16);
            this.lb_telefone.TabIndex = 42;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(190, 27);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(118, 16);
            this.lb_nome.TabIndex = 41;
            this.lb_nome.Text = "Nome do Cliente:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_nome.Location = new System.Drawing.Point(191, 47);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(528, 25);
            this.txt_nome.TabIndex = 40;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cliente.Location = new System.Drawing.Point(15, 28);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(76, 16);
            this.lb_cliente.TabIndex = 39;
            this.lb_cliente.Text = "CPF/CNPJ:";
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.Color.White;
            this.txt_numero.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_numero.Location = new System.Drawing.Point(179, 20);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(84, 25);
            this.txt_numero.TabIndex = 35;
            // 
            // gb_gerais
            // 
            this.gb_gerais.BackColor = System.Drawing.Color.Transparent;
            this.gb_gerais.Controls.Add(this.txt_cliente);
            this.gb_gerais.Controls.Add(this.lb_cliente);
            this.gb_gerais.Controls.Add(this.txt_nome);
            this.gb_gerais.Controls.Add(this.lb_nome);
            this.gb_gerais.Controls.Add(this.lb_telefone);
            this.gb_gerais.Controls.Add(this.btn_consultCliente);
            this.gb_gerais.Controls.Add(this.txt_cidade);
            this.gb_gerais.Controls.Add(this.txt_telefone);
            this.gb_gerais.Controls.Add(this.lb_cidade);
            this.gb_gerais.Controls.Add(this.txt_email);
            this.gb_gerais.Controls.Add(this.lb_email);
            this.gb_gerais.Controls.Add(this.dtp_entrada);
            this.gb_gerais.Controls.Add(this.lb_entrada);
            this.gb_gerais.Controls.Add(this.dtp_saida);
            this.gb_gerais.Controls.Add(this.lb_saida);
            this.gb_gerais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_gerais.ForeColor = System.Drawing.Color.White;
            this.gb_gerais.Location = new System.Drawing.Point(39, 58);
            this.gb_gerais.Name = "gb_gerais";
            this.gb_gerais.Size = new System.Drawing.Size(759, 206);
            this.gb_gerais.TabIndex = 68;
            this.gb_gerais.TabStop = false;
            this.gb_gerais.Text = "Dados Gerais";
            // 
            // btn_consultCliente
            // 
            this.btn_consultCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_consultCliente.BackgroundImage = global::ControlePousada.Properties.Resources.pesquisa;
            this.btn_consultCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultCliente.FlatAppearance.BorderSize = 0;
            this.btn_consultCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_consultCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultCliente.Font = new System.Drawing.Font("Arial", 8F);
            this.btn_consultCliente.Location = new System.Drawing.Point(160, 46);
            this.btn_consultCliente.Name = "btn_consultCliente";
            this.btn_consultCliente.Size = new System.Drawing.Size(25, 26);
            this.btn_consultCliente.TabIndex = 63;
            this.btn_consultCliente.UseVisualStyleBackColor = false;
            this.btn_consultCliente.Click += new System.EventHandler(this.btn_consultCliente_Click);
            // 
            // gb_financeiro
            // 
            this.gb_financeiro.BackColor = System.Drawing.Color.Transparent;
            this.gb_financeiro.Controls.Add(this.txt_valor);
            this.gb_financeiro.Controls.Add(this.txt_valorBase);
            this.gb_financeiro.Controls.Add(this.np_desconto);
            this.gb_financeiro.Controls.Add(this.lb_valorBase);
            this.gb_financeiro.Controls.Add(this.lb_DataPag);
            this.gb_financeiro.Controls.Add(this.lb_desconto);
            this.gb_financeiro.Controls.Add(this.dtp_dataPag);
            this.gb_financeiro.Controls.Add(this.lb_valor);
            this.gb_financeiro.Controls.Add(this.cb_pagamento);
            this.gb_financeiro.Controls.Add(this.lp_feriado);
            this.gb_financeiro.Controls.Add(this.cb_feriado);
            this.gb_financeiro.Controls.Add(this.np_qtdPessoas);
            this.gb_financeiro.Controls.Add(this.lb_qtdPessoas);
            this.gb_financeiro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_financeiro.ForeColor = System.Drawing.Color.White;
            this.gb_financeiro.Location = new System.Drawing.Point(39, 273);
            this.gb_financeiro.Name = "gb_financeiro";
            this.gb_financeiro.Size = new System.Drawing.Size(759, 155);
            this.gb_financeiro.TabIndex = 69;
            this.gb_financeiro.TabStop = false;
            this.gb_financeiro.Text = "Dados Financeiros";
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.White;
            this.txt_valor.DecimalPlaces = 2;
            this.txt_valor.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_valor.Location = new System.Drawing.Point(619, 111);
            this.txt_valor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 25);
            this.txt_valor.TabIndex = 71;
            this.txt_valor.ThousandsSeparator = true;
            this.txt_valor.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // txt_valorBase
            // 
            this.txt_valorBase.BackColor = System.Drawing.Color.White;
            this.txt_valorBase.DecimalPlaces = 2;
            this.txt_valorBase.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_valorBase.Location = new System.Drawing.Point(252, 48);
            this.txt_valorBase.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_valorBase.Name = "txt_valorBase";
            this.txt_valorBase.Size = new System.Drawing.Size(155, 25);
            this.txt_valorBase.TabIndex = 70;
            this.txt_valorBase.ThousandsSeparator = true;
            this.txt_valorBase.Value = new decimal(new int[] {
            70000,
            0,
            0,
            131072});
            this.txt_valorBase.ValueChanged += new System.EventHandler(this.txt_valorBase_ValueChanged);
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.BackColor = System.Drawing.Color.Transparent;
            this.lb_numero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_numero.ForeColor = System.Drawing.Color.White;
            this.lb_numero.Location = new System.Drawing.Point(36, 24);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(137, 16);
            this.lb_numero.TabIndex = 70;
            this.lb_numero.Text = "Número da Reserva:";
            // 
            // txt_obs
            // 
            this.txt_obs.BackColor = System.Drawing.Color.White;
            this.txt_obs.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txt_obs.Location = new System.Drawing.Point(6, 18);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(442, 77);
            this.txt_obs.TabIndex = 71;
            this.txt_obs.Text = "";
            // 
            // gb_obs
            // 
            this.gb_obs.BackColor = System.Drawing.Color.Transparent;
            this.gb_obs.Controls.Add(this.txt_obs);
            this.gb_obs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_obs.ForeColor = System.Drawing.Color.White;
            this.gb_obs.Location = new System.Drawing.Point(39, 436);
            this.gb_obs.Name = "gb_obs";
            this.gb_obs.Size = new System.Drawing.Size(454, 102);
            this.gb_obs.TabIndex = 69;
            this.gb_obs.TabStop = false;
            this.gb_obs.Text = "Obervações";
            // 
            // Frm_reservaCriar
            // 
            this.AcceptButton = this.btn_salvarReserva;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ControlePousada.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.gb_obs);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.gb_financeiro);
            this.Controls.Add(this.gb_gerais);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvarReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_reservaCriar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle de Pousada";
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).EndInit();
            this.gb_gerais.ResumeLayout(false);
            this.gb_gerais.PerformLayout();
            this.gb_financeiro.ResumeLayout(false);
            this.gb_financeiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorBase)).EndInit();
            this.gb_obs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DataPag;
        private System.Windows.Forms.DateTimePicker dtp_dataPag;
        private System.Windows.Forms.CheckBox cb_pagamento;
        private System.Windows.Forms.Button btn_consultCliente;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvarReserva;
        private System.Windows.Forms.Label lb_valorBase;
        private System.Windows.Forms.NumericUpDown np_desconto;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.MaskedTextBox txt_cliente;
        private System.Windows.Forms.ComboBox lp_feriado;
        private System.Windows.Forms.CheckBox cb_feriado;
        private System.Windows.Forms.NumericUpDown np_qtdPessoas;
        private System.Windows.Forms.Label lb_qtdPessoas;
        private System.Windows.Forms.Label lb_saida;
        private System.Windows.Forms.DateTimePicker dtp_saida;
        private System.Windows.Forms.Label lb_entrada;
        private System.Windows.Forms.DateTimePicker dtp_entrada;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.GroupBox gb_gerais;
        private System.Windows.Forms.GroupBox gb_financeiro;
        private System.Windows.Forms.NumericUpDown txt_valorBase;
        private System.Windows.Forms.NumericUpDown txt_valor;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.RichTextBox txt_obs;
        private System.Windows.Forms.GroupBox gb_obs;
    }
}
﻿namespace WindowsFormsApp1
{
    partial class Frm_novaReserva
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
            this.btn_consultCliente = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_salvarReserva = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.lb_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DataPag
            // 
            this.lb_DataPag.AutoSize = true;
            this.lb_DataPag.Location = new System.Drawing.Point(538, 385);
            this.lb_DataPag.Name = "lb_DataPag";
            this.lb_DataPag.Size = new System.Drawing.Size(102, 13);
            this.lb_DataPag.TabIndex = 66;
            this.lb_DataPag.Text = "Data do Pagamento";
            // 
            // dtp_dataPag
            // 
            this.dtp_dataPag.Enabled = false;
            this.dtp_dataPag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPag.Location = new System.Drawing.Point(541, 401);
            this.dtp_dataPag.Name = "dtp_dataPag";
            this.dtp_dataPag.Size = new System.Drawing.Size(140, 20);
            this.dtp_dataPag.TabIndex = 65;
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.AutoSize = true;
            this.cb_pagamento.Location = new System.Drawing.Point(448, 385);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(84, 17);
            this.cb_pagamento.TabIndex = 64;
            this.cb_pagamento.Text = "Valor Pago?";
            this.cb_pagamento.UseVisualStyleBackColor = true;
            this.cb_pagamento.CheckedChanged += new System.EventHandler(this.cb_pagamento_CheckedChanged);
            // 
            // btn_consultCliente
            // 
            this.btn_consultCliente.Location = new System.Drawing.Point(189, 150);
            this.btn_consultCliente.Name = "btn_consultCliente";
            this.btn_consultCliente.Size = new System.Drawing.Size(25, 23);
            this.btn_consultCliente.TabIndex = 63;
            this.btn_consultCliente.Text = "->";
            this.btn_consultCliente.UseVisualStyleBackColor = true;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(541, 152);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.ReadOnly = true;
            this.txt_telefone.Size = new System.Drawing.Size(140, 20);
            this.txt_telefone.TabIndex = 62;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(45, 404);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(84, 13);
            this.lb_valor.TabIndex = 61;
            this.lb_valor.Text = "Valor Total (R$):";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(572, 472);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelar.TabIndex = 38;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelarReserva_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(135, 401);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 60;
            // 
            // btn_salvarReserva
            // 
            this.btn_salvarReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarReserva.Location = new System.Drawing.Point(409, 472);
            this.btn_salvarReserva.Name = "btn_salvarReserva";
            this.btn_salvarReserva.Size = new System.Drawing.Size(132, 38);
            this.btn_salvarReserva.TabIndex = 37;
            this.btn_salvarReserva.Text = "Salvar";
            this.btn_salvarReserva.UseVisualStyleBackColor = true;
            this.btn_salvarReserva.Click += new System.EventHandler(this.btn_salvarReserva_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 59;
            this.textBox1.Text = "700,00";
            // 
            // lb_valorBase
            // 
            this.lb_valorBase.AutoSize = true;
            this.lb_valorBase.Location = new System.Drawing.Point(391, 248);
            this.lb_valorBase.Name = "lb_valorBase";
            this.lb_valorBase.Size = new System.Drawing.Size(84, 13);
            this.lb_valorBase.TabIndex = 58;
            this.lb_valorBase.Text = "Valor Base (R$):";
            // 
            // np_desconto
            // 
            this.np_desconto.Location = new System.Drawing.Point(541, 262);
            this.np_desconto.Name = "np_desconto";
            this.np_desconto.Size = new System.Drawing.Size(140, 20);
            this.np_desconto.TabIndex = 57;
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Location = new System.Drawing.Point(538, 247);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(73, 13);
            this.lb_desconto.TabIndex = 56;
            this.lb_desconto.Text = "Desconto (%):";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(47, 151);
            this.txt_cliente.Mask = "000.000.000-00";
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(136, 20);
            this.txt_cliente.TabIndex = 55;
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
            this.lp_feriado.Location = new System.Drawing.Point(220, 262);
            this.lp_feriado.Name = "lp_feriado";
            this.lp_feriado.Size = new System.Drawing.Size(168, 21);
            this.lp_feriado.TabIndex = 54;
            this.lp_feriado.Text = "Selecione";
            // 
            // cb_feriado
            // 
            this.cb_feriado.AutoSize = true;
            this.cb_feriado.Location = new System.Drawing.Point(221, 245);
            this.cb_feriado.Name = "cb_feriado";
            this.cb_feriado.Size = new System.Drawing.Size(67, 17);
            this.cb_feriado.TabIndex = 53;
            this.cb_feriado.Text = "Feriado?";
            this.cb_feriado.UseVisualStyleBackColor = true;
            this.cb_feriado.CheckedChanged += new System.EventHandler(this.cb_feriado_CheckedChanged);
            // 
            // np_qtdPessoas
            // 
            this.np_qtdPessoas.Location = new System.Drawing.Point(48, 263);
            this.np_qtdPessoas.Name = "np_qtdPessoas";
            this.np_qtdPessoas.Size = new System.Drawing.Size(166, 20);
            this.np_qtdPessoas.TabIndex = 52;
            // 
            // lb_qtdPessoas
            // 
            this.lb_qtdPessoas.AutoSize = true;
            this.lb_qtdPessoas.Location = new System.Drawing.Point(45, 246);
            this.lb_qtdPessoas.Name = "lb_qtdPessoas";
            this.lb_qtdPessoas.Size = new System.Drawing.Size(123, 13);
            this.lb_qtdPessoas.TabIndex = 51;
            this.lb_qtdPessoas.Text = "Quantidade de Pessoas:";
            // 
            // lb_saida
            // 
            this.lb_saida.AutoSize = true;
            this.lb_saida.Location = new System.Drawing.Point(538, 191);
            this.lb_saida.Name = "lb_saida";
            this.lb_saida.Size = new System.Drawing.Size(77, 13);
            this.lb_saida.TabIndex = 50;
            this.lb_saida.Text = "Data de Saída";
            // 
            // dtp_saida
            // 
            this.dtp_saida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_saida.Location = new System.Drawing.Point(541, 207);
            this.dtp_saida.Name = "dtp_saida";
            this.dtp_saida.Size = new System.Drawing.Size(140, 20);
            this.dtp_saida.TabIndex = 49;
            // 
            // lb_entrada
            // 
            this.lb_entrada.AutoSize = true;
            this.lb_entrada.Location = new System.Drawing.Point(391, 191);
            this.lb_entrada.Name = "lb_entrada";
            this.lb_entrada.Size = new System.Drawing.Size(85, 13);
            this.lb_entrada.TabIndex = 48;
            this.lb_entrada.Text = "Data de Entrada";
            // 
            // dtp_entrada
            // 
            this.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrada.Location = new System.Drawing.Point(394, 207);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.Size = new System.Drawing.Size(141, 20);
            this.dtp_entrada.TabIndex = 47;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(219, 191);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(38, 13);
            this.lb_email.TabIndex = 46;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(221, 207);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(167, 20);
            this.txt_email.TabIndex = 45;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(45, 191);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(43, 13);
            this.lb_cidade.TabIndex = 44;
            this.lb_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(47, 207);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(167, 20);
            this.txt_cidade.TabIndex = 43;
            this.txt_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(538, 135);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(52, 13);
            this.lb_telefone.TabIndex = 42;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(218, 135);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(88, 13);
            this.lb_nome.TabIndex = 41;
            this.lb_nome.Text = "Nome do Cliente:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(220, 151);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(315, 20);
            this.txt_nome.TabIndex = 40;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(45, 135);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(62, 13);
            this.lb_cliente.TabIndex = 39;
            this.lb_cliente.Text = "CPF/CNPJ:";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(44, 53);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(105, 13);
            this.lb_numero.TabIndex = 36;
            this.lb_numero.Text = "Número da Reserva:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(47, 69);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 35;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_novaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.lb_DataPag);
            this.Controls.Add(this.dtp_dataPag);
            this.Controls.Add(this.cb_pagamento);
            this.Controls.Add(this.btn_consultCliente);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_salvarReserva);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_valorBase);
            this.Controls.Add(this.np_desconto);
            this.Controls.Add(this.lb_desconto);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.lp_feriado);
            this.Controls.Add(this.cb_feriado);
            this.Controls.Add(this.np_qtdPessoas);
            this.Controls.Add(this.lb_qtdPessoas);
            this.Controls.Add(this.lb_saida);
            this.Controls.Add(this.dtp_saida);
            this.Controls.Add(this.lb_entrada);
            this.Controls.Add(this.dtp_entrada);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_cidade);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.txt_numero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_novaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle de Pousada";
            ((System.ComponentModel.ISupportInitialize)(this.np_desconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_qtdPessoas)).EndInit();
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
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_salvarReserva;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox txt_numero;
    }
}
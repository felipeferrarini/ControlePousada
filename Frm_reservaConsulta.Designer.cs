namespace controlePousada
{
    partial class Frm_reservaConsulta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.gb_filtros = new System.Windows.Forms.GroupBox();
            this.cb_pagamento = new System.Windows.Forms.CheckBox();
            this.cb_saida = new System.Windows.Forms.CheckBox();
            this.cb_entrada = new System.Windows.Forms.CheckBox();
            this.dtp_pagamento = new System.Windows.Forms.DateTimePicker();
            this.dtp_saida = new System.Windows.Forms.DateTimePicker();
            this.dtp_entrada = new System.Windows.Forms.DateTimePicker();
            this.lb_feriado = new System.Windows.Forms.Label();
            this.lp_feriado = new System.Windows.Forms.ComboBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lb_mes = new System.Windows.Forms.Label();
            this.lp_mes = new System.Windows.Forms.ComboBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(816, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisa.FlatAppearance.BorderSize = 0;
            this.btn_pesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisa.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisa.Location = new System.Drawing.Point(686, 40);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(142, 54);
            this.btn_pesquisa.TabIndex = 1;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = false;
            this.btn_pesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_filtros
            // 
            this.gb_filtros.Controls.Add(this.label1);
            this.gb_filtros.Controls.Add(this.cb_pagamento);
            this.gb_filtros.Controls.Add(this.cb_saida);
            this.gb_filtros.Controls.Add(this.cb_entrada);
            this.gb_filtros.Controls.Add(this.dtp_pagamento);
            this.gb_filtros.Controls.Add(this.dtp_saida);
            this.gb_filtros.Controls.Add(this.dtp_entrada);
            this.gb_filtros.Controls.Add(this.lb_feriado);
            this.gb_filtros.Controls.Add(this.lp_feriado);
            this.gb_filtros.Controls.Add(this.lb_numero);
            this.gb_filtros.Controls.Add(this.txt_numero);
            this.gb_filtros.Controls.Add(this.lb_mes);
            this.gb_filtros.Controls.Add(this.lp_mes);
            this.gb_filtros.Controls.Add(this.lb_cidade);
            this.gb_filtros.Controls.Add(this.txt_cidade);
            this.gb_filtros.Controls.Add(this.lb_nome);
            this.gb_filtros.Controls.Add(this.txt_nome);
            this.gb_filtros.Location = new System.Drawing.Point(12, 12);
            this.gb_filtros.Name = "gb_filtros";
            this.gb_filtros.Size = new System.Drawing.Size(668, 149);
            this.gb_filtros.TabIndex = 3;
            this.gb_filtros.TabStop = false;
            this.gb_filtros.Text = "Filtros";
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.AutoSize = true;
            this.cb_pagamento.Location = new System.Drawing.Point(494, 76);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(121, 17);
            this.cb_pagamento.TabIndex = 19;
            this.cb_pagamento.Text = "Data de Pagamento";
            this.cb_pagamento.UseVisualStyleBackColor = true;
            this.cb_pagamento.CheckedChanged += new System.EventHandler(this.cb_pagamento_CheckedChanged);
            // 
            // cb_saida
            // 
            this.cb_saida.AutoSize = true;
            this.cb_saida.Location = new System.Drawing.Point(337, 76);
            this.cb_saida.Name = "cb_saida";
            this.cb_saida.Size = new System.Drawing.Size(96, 17);
            this.cb_saida.TabIndex = 18;
            this.cb_saida.Text = "Data da Saída";
            this.cb_saida.UseVisualStyleBackColor = true;
            this.cb_saida.CheckedChanged += new System.EventHandler(this.cb_saida_CheckedChanged);
            // 
            // cb_entrada
            // 
            this.cb_entrada.AutoSize = true;
            this.cb_entrada.Location = new System.Drawing.Point(178, 76);
            this.cb_entrada.Name = "cb_entrada";
            this.cb_entrada.Size = new System.Drawing.Size(104, 17);
            this.cb_entrada.TabIndex = 17;
            this.cb_entrada.Text = "Data da Entrada";
            this.cb_entrada.UseVisualStyleBackColor = true;
            this.cb_entrada.CheckedChanged += new System.EventHandler(this.cb_entrada_CheckedChanged);
            // 
            // dtp_pagamento
            // 
            this.dtp_pagamento.Checked = false;
            this.dtp_pagamento.Enabled = false;
            this.dtp_pagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_pagamento.Location = new System.Drawing.Point(494, 93);
            this.dtp_pagamento.Name = "dtp_pagamento";
            this.dtp_pagamento.Size = new System.Drawing.Size(152, 20);
            this.dtp_pagamento.TabIndex = 15;
            this.dtp_pagamento.ValueChanged += new System.EventHandler(this.dtp_pagamento_ValueChanged);
            // 
            // dtp_saida
            // 
            this.dtp_saida.Checked = false;
            this.dtp_saida.Enabled = false;
            this.dtp_saida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_saida.Location = new System.Drawing.Point(337, 93);
            this.dtp_saida.Name = "dtp_saida";
            this.dtp_saida.Size = new System.Drawing.Size(151, 20);
            this.dtp_saida.TabIndex = 13;
            this.dtp_saida.ValueChanged += new System.EventHandler(this.dtp_saida_ValueChanged);
            // 
            // dtp_entrada
            // 
            this.dtp_entrada.Checked = false;
            this.dtp_entrada.Enabled = false;
            this.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrada.Location = new System.Drawing.Point(178, 93);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.Size = new System.Drawing.Size(152, 20);
            this.dtp_entrada.TabIndex = 11;
            this.dtp_entrada.ValueChanged += new System.EventHandler(this.dtp_entrada_ValueChanged);
            // 
            // lb_feriado
            // 
            this.lb_feriado.AutoSize = true;
            this.lb_feriado.Location = new System.Drawing.Point(17, 77);
            this.lb_feriado.Name = "lb_feriado";
            this.lb_feriado.Size = new System.Drawing.Size(42, 13);
            this.lb_feriado.TabIndex = 10;
            this.lb_feriado.Text = "Feriado";
            // 
            // lp_feriado
            // 
            this.lp_feriado.FormattingEnabled = true;
            this.lp_feriado.Location = new System.Drawing.Point(20, 93);
            this.lp_feriado.Name = "lp_feriado";
            this.lp_feriado.Size = new System.Drawing.Size(152, 21);
            this.lp_feriado.TabIndex = 9;
            this.lp_feriado.Text = "Selecione";
            this.lp_feriado.SelectedIndexChanged += new System.EventHandler(this.lp_feriado_SelectedIndexChanged);
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(17, 28);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(102, 13);
            this.lb_numero.TabIndex = 8;
            this.lb_numero.Text = "Número da Reserva";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(20, 44);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(152, 20);
            this.txt_numero.TabIndex = 7;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // lb_mes
            // 
            this.lb_mes.AutoSize = true;
            this.lb_mes.Location = new System.Drawing.Point(491, 27);
            this.lb_mes.Name = "lb_mes";
            this.lb_mes.Size = new System.Drawing.Size(27, 13);
            this.lb_mes.TabIndex = 6;
            this.lb_mes.Text = "Mês";
            // 
            // lp_mes
            // 
            this.lp_mes.FormattingEnabled = true;
            this.lp_mes.Items.AddRange(new object[] {
            "Selecione",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.lp_mes.Location = new System.Drawing.Point(494, 42);
            this.lp_mes.Name = "lp_mes";
            this.lp_mes.Size = new System.Drawing.Size(152, 21);
            this.lp_mes.TabIndex = 4;
            this.lp_mes.Text = "Selecione";
            this.lp_mes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(333, 27);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(40, 13);
            this.lb_cidade.TabIndex = 3;
            this.lb_cidade.Text = "Cidade";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(336, 43);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(152, 20);
            this.txt_cidade.TabIndex = 2;
            this.txt_cidade.TextChanged += new System.EventHandler(this.txt_cidade_TextChanged);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(175, 27);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(85, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome do Cliente";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(178, 43);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(152, 20);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // btn_limpa
            // 
            this.btn_limpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_limpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpa.FlatAppearance.BorderSize = 0;
            this.btn_limpa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_limpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpa.ForeColor = System.Drawing.Color.White;
            this.btn_limpa.Location = new System.Drawing.Point(686, 100);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(142, 24);
            this.btn_limpa.TabIndex = 5;
            this.btn_limpa.Text = "Limpar Filtros";
            this.btn_limpa.UseVisualStyleBackColor = false;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "* Duplo Clique sobre o número da reserva para editar";
            // 
            // Frm_reservaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.gb_filtros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_limpa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_reservaConsulta";
            this.Text = "Frm_reservaConsulta";
            this.Load += new System.EventHandler(this.Frm_reservaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_filtros.ResumeLayout(false);
            this.gb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.GroupBox gb_filtros;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lb_mes;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.ComboBox lp_mes;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ComboBox lp_feriado;
        private System.Windows.Forms.Label lb_feriado;
        private System.Windows.Forms.DateTimePicker dtp_pagamento;
        private System.Windows.Forms.DateTimePicker dtp_saida;
        private System.Windows.Forms.DateTimePicker dtp_entrada;
        private System.Windows.Forms.CheckBox cb_saida;
        private System.Windows.Forms.CheckBox cb_entrada;
        private System.Windows.Forms.CheckBox cb_pagamento;
        private System.Windows.Forms.Label label1;
    }
}
namespace ControlePousada
{
    partial class Frm_config
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.gb_cadastrarFeriado = new System.Windows.Forms.GroupBox();
            this.gb_editarFeriado = new System.Windows.Forms.GroupBox();
            this.lp_editaFeriado = new System.Windows.Forms.ComboBox();
            this.np_editaFeriado = new System.Windows.Forms.NumericUpDown();
            this.txt_novoFeriado = new System.Windows.Forms.TextBox();
            this.np_novoFeriado = new System.Windows.Forms.NumericUpDown();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_cadastrarFeriado.SuspendLayout();
            this.gb_editarFeriado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_editaFeriado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_novoFeriado)).BeginInit();
            this.SuspendLayout();
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
            this.btn_cancelar.Location = new System.Drawing.Point(629, 500);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 38);
            this.btn_cancelar.TabIndex = 40;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(422, 55);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(132, 26);
            this.btn_salvar.TabIndex = 39;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // gb_cadastrarFeriado
            // 
            this.gb_cadastrarFeriado.BackColor = System.Drawing.Color.Transparent;
            this.gb_cadastrarFeriado.Controls.Add(this.label2);
            this.gb_cadastrarFeriado.Controls.Add(this.label1);
            this.gb_cadastrarFeriado.Controls.Add(this.btn_cadastrar);
            this.gb_cadastrarFeriado.Controls.Add(this.np_novoFeriado);
            this.gb_cadastrarFeriado.Controls.Add(this.txt_novoFeriado);
            this.gb_cadastrarFeriado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_cadastrarFeriado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cadastrarFeriado.ForeColor = System.Drawing.Color.White;
            this.gb_cadastrarFeriado.Location = new System.Drawing.Point(68, 68);
            this.gb_cadastrarFeriado.Name = "gb_cadastrarFeriado";
            this.gb_cadastrarFeriado.Size = new System.Drawing.Size(693, 118);
            this.gb_cadastrarFeriado.TabIndex = 113;
            this.gb_cadastrarFeriado.TabStop = false;
            this.gb_cadastrarFeriado.Text = "Cadastrar Feriado";
            // 
            // gb_editarFeriado
            // 
            this.gb_editarFeriado.BackColor = System.Drawing.Color.Transparent;
            this.gb_editarFeriado.Controls.Add(this.label4);
            this.gb_editarFeriado.Controls.Add(this.label3);
            this.gb_editarFeriado.Controls.Add(this.np_editaFeriado);
            this.gb_editarFeriado.Controls.Add(this.lp_editaFeriado);
            this.gb_editarFeriado.Controls.Add(this.btn_salvar);
            this.gb_editarFeriado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_editarFeriado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_editarFeriado.ForeColor = System.Drawing.Color.White;
            this.gb_editarFeriado.Location = new System.Drawing.Point(68, 243);
            this.gb_editarFeriado.Name = "gb_editarFeriado";
            this.gb_editarFeriado.Size = new System.Drawing.Size(693, 118);
            this.gb_editarFeriado.TabIndex = 114;
            this.gb_editarFeriado.TabStop = false;
            this.gb_editarFeriado.Text = "Editar Feriado";
            // 
            // lp_editaFeriado
            // 
            this.lp_editaFeriado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lp_editaFeriado.FormattingEnabled = true;
            this.lp_editaFeriado.Location = new System.Drawing.Point(28, 55);
            this.lp_editaFeriado.Name = "lp_editaFeriado";
            this.lp_editaFeriado.Size = new System.Drawing.Size(169, 26);
            this.lp_editaFeriado.TabIndex = 0;
            this.lp_editaFeriado.SelectedIndexChanged += new System.EventHandler(this.lp_editaFeriado_SelectedIndexChanged);
            // 
            // np_editaFeriado
            // 
            this.np_editaFeriado.DecimalPlaces = 2;
            this.np_editaFeriado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.np_editaFeriado.Location = new System.Drawing.Point(227, 55);
            this.np_editaFeriado.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.np_editaFeriado.Name = "np_editaFeriado";
            this.np_editaFeriado.Size = new System.Drawing.Size(169, 24);
            this.np_editaFeriado.TabIndex = 1;
            this.np_editaFeriado.ThousandsSeparator = true;
            // 
            // txt_novoFeriado
            // 
            this.txt_novoFeriado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_novoFeriado.Location = new System.Drawing.Point(28, 46);
            this.txt_novoFeriado.Name = "txt_novoFeriado";
            this.txt_novoFeriado.Size = new System.Drawing.Size(169, 24);
            this.txt_novoFeriado.TabIndex = 0;
            // 
            // np_novoFeriado
            // 
            this.np_novoFeriado.DecimalPlaces = 2;
            this.np_novoFeriado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_novoFeriado.Location = new System.Drawing.Point(227, 46);
            this.np_novoFeriado.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.np_novoFeriado.Name = "np_novoFeriado";
            this.np_novoFeriado.Size = new System.Drawing.Size(169, 24);
            this.np_novoFeriado.TabIndex = 1;
            this.np_novoFeriado.ThousandsSeparator = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(422, 46);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(132, 24);
            this.btn_cadastrar.TabIndex = 115;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 116;
            this.label1.Text = "Digite o novo Feriado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "Insira o valor base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 118;
            this.label3.Text = "Escolha o Feriado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Insira o novo valor base:";
            // 
            // Frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ControlePousada.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.gb_editarFeriado);
            this.Controls.Add(this.gb_cadastrarFeriado);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_config";
            this.Text = "Frm_config";
            this.Load += new System.EventHandler(this.Frm_config_Load);
            this.gb_cadastrarFeriado.ResumeLayout(false);
            this.gb_cadastrarFeriado.PerformLayout();
            this.gb_editarFeriado.ResumeLayout(false);
            this.gb_editarFeriado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_editaFeriado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np_novoFeriado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.GroupBox gb_cadastrarFeriado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.NumericUpDown np_novoFeriado;
        private System.Windows.Forms.TextBox txt_novoFeriado;
        private System.Windows.Forms.GroupBox gb_editarFeriado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown np_editaFeriado;
        private System.Windows.Forms.ComboBox lp_editaFeriado;
    }
}
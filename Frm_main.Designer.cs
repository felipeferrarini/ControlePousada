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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.gb_novaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_novaReserva
            // 
            this.btn_novaReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novaReserva.Location = new System.Drawing.Point(12, 46);
            this.btn_novaReserva.Name = "btn_novaReserva";
            this.btn_novaReserva.Size = new System.Drawing.Size(158, 38);
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
            this.gb_novaReserva.Controls.Add(this.lb_numero);
            this.gb_novaReserva.Controls.Add(this.txt_numero);
            this.gb_novaReserva.Location = new System.Drawing.Point(225, 46);
            this.gb_novaReserva.Name = "gb_novaReserva";
            this.gb_novaReserva.Size = new System.Drawing.Size(693, 455);
            this.gb_novaReserva.TabIndex = 3;
            this.gb_novaReserva.TabStop = false;
            this.gb_novaReserva.Visible = false;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(12, 134);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(158, 38);
            this.btn_consulta.TabIndex = 5;
            this.btn_consulta.Text = "Consultar Reservas";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(12, 90);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(158, 38);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar Reserva";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financeiro.Location = new System.Drawing.Point(12, 178);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(158, 38);
            this.btn_financeiro.TabIndex = 7;
            this.btn_financeiro.Text = "Consultar Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_config
            // 
            this.btn_config.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.Location = new System.Drawing.Point(12, 222);
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
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(9, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 0;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(6, 16);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(102, 13);
            this.lb_numero.TabIndex = 1;
            this.lb_numero.Text = "Número da Reserva";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_financeiro);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gb_novaReserva);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novaReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Pousada 1.0";
            this.gb_novaReserva.ResumeLayout(false);
            this.gb_novaReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_novaReserva;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gb_novaReserva;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox txt_numero;
    }
}
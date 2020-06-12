namespace controlePousada
{
    partial class MDIMain
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_novaReserva = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_newCliente = new System.Windows.Forms.Button();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lb_title);
            this.panelTop.Controls.Add(this.btn_minimizar);
            this.panelTop.Controls.Add(this.btn_close);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 40);
            this.panelTop.TabIndex = 19;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb_title.Location = new System.Drawing.Point(42, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(215, 25);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Controle de Pousada";
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btn_inicio);
            this.panelMenu.Controls.Add(this.btn_menu);
            this.panelMenu.Controls.Add(this.btn_config);
            this.panelMenu.Controls.Add(this.btn_novaReserva);
            this.panelMenu.Controls.Add(this.btn_financeiro);
            this.panelMenu.Controls.Add(this.btn_cliente);
            this.panelMenu.Controls.Add(this.btn_newCliente);
            this.panelMenu.Controls.Add(this.btn_reserva);
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(50, 560);
            this.panelMenu.TabIndex = 20;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Image = global::ControlePousada.Properties.Resources.home;
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(0, 51);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(242, 50);
            this.btn_inicio.TabIndex = 21;
            this.btn_inicio.Text = "  Página Inicial";
            this.btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            this.btn_inicio.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // btn_menu
            // 
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Image = global::ControlePousada.Properties.Resources.menu_close2;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(50, 42);
            this.btn_menu.TabIndex = 19;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.FlatAppearance.BorderSize = 0;
            this.btn_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.Image = global::ControlePousada.Properties.Resources.config;
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_config.Location = new System.Drawing.Point(0, 455);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(242, 50);
            this.btn_config.TabIndex = 15;
            this.btn_config.Text = "  Configurações";
            this.btn_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_config.UseVisualStyleBackColor = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            this.btn_config.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // btn_novaReserva
            // 
            this.btn_novaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_novaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novaReserva.FlatAppearance.BorderSize = 0;
            this.btn_novaReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_novaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_novaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novaReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_novaReserva.ForeColor = System.Drawing.Color.White;
            this.btn_novaReserva.Image = global::ControlePousada.Properties.Resources.baseline_create_new_folder_white_36dp;
            this.btn_novaReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novaReserva.Location = new System.Drawing.Point(0, 107);
            this.btn_novaReserva.Name = "btn_novaReserva";
            this.btn_novaReserva.Size = new System.Drawing.Size(242, 50);
            this.btn_novaReserva.TabIndex = 12;
            this.btn_novaReserva.Text = "  Nova Reserva";
            this.btn_novaReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novaReserva.UseVisualStyleBackColor = false;
            this.btn_novaReserva.Click += new System.EventHandler(this.btn_novaReserva_Click);
            this.btn_novaReserva.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financeiro.FlatAppearance.BorderSize = 0;
            this.btn_financeiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_financeiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_financeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financeiro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financeiro.ForeColor = System.Drawing.Color.White;
            this.btn_financeiro.Image = global::ControlePousada.Properties.Resources.financeiro;
            this.btn_financeiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financeiro.Location = new System.Drawing.Point(0, 221);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(242, 50);
            this.btn_financeiro.TabIndex = 14;
            this.btn_financeiro.Text = "  Financeiro";
            this.btn_financeiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_financeiro.UseVisualStyleBackColor = false;
            this.btn_financeiro.Click += new System.EventHandler(this.btn_financeiro_Click);
            this.btn_financeiro.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = global::ControlePousada.Properties.Resources.consultaCLinete;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(0, 333);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(242, 50);
            this.btn_cliente.TabIndex = 18;
            this.btn_cliente.Text = "  Consultar/Editar Cliente";
            this.btn_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            this.btn_cliente.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // btn_newCliente
            // 
            this.btn_newCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_newCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newCliente.FlatAppearance.BorderSize = 0;
            this.btn_newCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_newCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_newCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newCliente.ForeColor = System.Drawing.Color.White;
            this.btn_newCliente.Image = global::ControlePousada.Properties.Resources.cadastroCliente;
            this.btn_newCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newCliente.Location = new System.Drawing.Point(0, 277);
            this.btn_newCliente.Name = "btn_newCliente";
            this.btn_newCliente.Size = new System.Drawing.Size(242, 50);
            this.btn_newCliente.TabIndex = 17;
            this.btn_newCliente.Text = "  Cadastrar Cliente";
            this.btn_newCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newCliente.UseVisualStyleBackColor = false;
            this.btn_newCliente.Click += new System.EventHandler(this.btn_newCliente_Click);
            this.btn_newCliente.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // btn_reserva
            // 
            this.btn_reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_reserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reserva.FlatAppearance.BorderSize = 0;
            this.btn_reserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_reserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_reserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva.ForeColor = System.Drawing.Color.White;
            this.btn_reserva.Image = global::ControlePousada.Properties.Resources.editar_reserva;
            this.btn_reserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reserva.Location = new System.Drawing.Point(0, 165);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(242, 50);
            this.btn_reserva.TabIndex = 13;
            this.btn_reserva.Text = "  Consultar/Editar Reserva";
            this.btn_reserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reserva.UseVisualStyleBackColor = false;
            this.btn_reserva.Click += new System.EventHandler(this.btn_reserva_Click);
            this.btn_reserva.MouseHover += new System.EventHandler(this.btn_newCliente_MouseHover);
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.Transparent;
            this.panelForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForms.Location = new System.Drawing.Point(48, 40);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(852, 560);
            this.panelForms.TabIndex = 21;
            this.panelForms.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelForms_ControlRemoved);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackgroundImage = global::ControlePousada.Properties.Resources.min;
            this.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Location = new System.Drawing.Point(829, 4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundImage = global::ControlePousada.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(865, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MDIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIMain";
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_newCliente;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_novaReserva;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label label1;
    }
}
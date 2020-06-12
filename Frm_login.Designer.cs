namespace controlePousada
{
    partial class Frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.Mtxt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_login = new System.Windows.Forms.Label();
            this.Mtxt_user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ControlePousada.Properties.Resources.baseline_person_black_48dp;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::ControlePousada.Properties.Resources.baseline_person_black_48dp;
            this.pictureBox3.Location = new System.Drawing.Point(105, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 23);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ControlePousada.Properties.Resources.baseline_lock_black_48dp;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(105, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 23);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(141, 216);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(202, 36);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Mtxt_password
            // 
            this.Mtxt_password.Depth = 0;
            this.Mtxt_password.Hint = "Senha";
            this.Mtxt_password.Location = new System.Drawing.Point(141, 162);
            this.Mtxt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mtxt_password.Name = "Mtxt_password";
            this.Mtxt_password.PasswordChar = '\0';
            this.Mtxt_password.SelectedText = "";
            this.Mtxt_password.SelectionLength = 0;
            this.Mtxt_password.SelectionStart = 0;
            this.Mtxt_password.Size = new System.Drawing.Size(202, 23);
            this.Mtxt_password.TabIndex = 8;
            this.Mtxt_password.UseSystemPasswordChar = true;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.White;
            this.lb_login.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lb_login.Location = new System.Drawing.Point(55, 34);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(357, 46);
            this.lb_login.TabIndex = 8;
            this.lb_login.Text = "Controle Pousada";
            // 
            // Mtxt_user
            // 
            this.Mtxt_user.Depth = 0;
            this.Mtxt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtxt_user.Hint = "Usuário";
            this.Mtxt_user.Location = new System.Drawing.Point(141, 113);
            this.Mtxt_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mtxt_user.Name = "Mtxt_user";
            this.Mtxt_user.PasswordChar = '\0';
            this.Mtxt_user.SelectedText = "";
            this.Mtxt_user.SelectionLength = 0;
            this.Mtxt_user.SelectionStart = 0;
            this.Mtxt_user.Size = new System.Drawing.Size(202, 23);
            this.Mtxt_user.TabIndex = 3;
            this.Mtxt_user.UseSystemPasswordChar = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundImage = global::ControlePousada.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(457, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackgroundImage = global::ControlePousada.Properties.Resources.min;
            this.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Location = new System.Drawing.Point(421, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_minimizar.TabIndex = 10;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.lb_login);
            this.panel1.Controls.Add(this.Mtxt_password);
            this.panel1.Controls.Add(this.Mtxt_user);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 301);
            this.panel1.TabIndex = 11;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 361);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField Mtxt_user;
        private MaterialSkin.Controls.MaterialSingleLineTextField Mtxt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Panel panel1;
    }
}


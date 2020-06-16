namespace ControlePousada
{
    partial class Frm_financeiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_medioMensal2 = new System.Windows.Forms.Label();
            this.np_ano = new System.Windows.Forms.NumericUpDown();
            this.lb_ano = new System.Windows.Forms.Label();
            this.lb_medioMensal = new System.Windows.Forms.Label();
            this.cb_real = new System.Windows.Forms.CheckBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_total2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_ano)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lb_medioMensal2);
            this.panel1.Location = new System.Drawing.Point(271, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // lb_medioMensal2
            // 
            this.lb_medioMensal2.AutoSize = true;
            this.lb_medioMensal2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lb_medioMensal2.ForeColor = System.Drawing.Color.Black;
            this.lb_medioMensal2.Location = new System.Drawing.Point(37, 38);
            this.lb_medioMensal2.Name = "lb_medioMensal2";
            this.lb_medioMensal2.Size = new System.Drawing.Size(100, 26);
            this.lb_medioMensal2.TabIndex = 0;
            this.lb_medioMensal2.Text = "R$ 00,00";
            // 
            // np_ano
            // 
            this.np_ano.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_ano.Location = new System.Drawing.Point(116, 78);
            this.np_ano.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.np_ano.Name = "np_ano";
            this.np_ano.Size = new System.Drawing.Size(91, 22);
            this.np_ano.TabIndex = 8;
            this.np_ano.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.np_ano.ValueChanged += new System.EventHandler(this.np_ano_ValueChanged);
            // 
            // lb_ano
            // 
            this.lb_ano.AutoSize = true;
            this.lb_ano.BackColor = System.Drawing.Color.Transparent;
            this.lb_ano.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ano.ForeColor = System.Drawing.Color.White;
            this.lb_ano.Location = new System.Drawing.Point(113, 59);
            this.lb_ano.Name = "lb_ano";
            this.lb_ano.Size = new System.Drawing.Size(68, 16);
            this.lb_ano.TabIndex = 9;
            this.lb_ano.Text = "Ano Base";
            // 
            // lb_medioMensal
            // 
            this.lb_medioMensal.AutoSize = true;
            this.lb_medioMensal.BackColor = System.Drawing.Color.Transparent;
            this.lb_medioMensal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_medioMensal.ForeColor = System.Drawing.Color.White;
            this.lb_medioMensal.Location = new System.Drawing.Point(271, 59);
            this.lb_medioMensal.Name = "lb_medioMensal";
            this.lb_medioMensal.Size = new System.Drawing.Size(137, 16);
            this.lb_medioMensal.TabIndex = 10;
            this.lb_medioMensal.Text = "Valor Médio Mensal:";
            // 
            // cb_real
            // 
            this.cb_real.AutoSize = true;
            this.cb_real.BackColor = System.Drawing.Color.Transparent;
            this.cb_real.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_real.ForeColor = System.Drawing.Color.White;
            this.cb_real.Location = new System.Drawing.Point(116, 122);
            this.cb_real.Name = "cb_real";
            this.cb_real.Size = new System.Drawing.Size(124, 20);
            this.cb_real.TabIndex = 12;
            this.cb_real.Text = "Valor Recebido";
            this.cb_real.UseVisualStyleBackColor = false;
            this.cb_real.CheckedChanged += new System.EventHandler(this.cb_real_CheckedChanged_1);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_total.ForeColor = System.Drawing.Color.White;
            this.lb_total.Location = new System.Drawing.Point(495, 59);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(156, 16);
            this.lb_total.TabIndex = 14;
            this.lb_total.Text = "Valor Total Acumulado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lb_total2);
            this.panel2.Location = new System.Drawing.Point(495, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 13;
            // 
            // lb_total2
            // 
            this.lb_total2.AutoSize = true;
            this.lb_total2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lb_total2.ForeColor = System.Drawing.Color.Black;
            this.lb_total2.Location = new System.Drawing.Point(37, 38);
            this.lb_total2.Name = "lb_total2";
            this.lb_total2.Size = new System.Drawing.Size(100, 26);
            this.lb_total2.TabIndex = 0;
            this.lb_total2.Text = "R$ 00,00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(116, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(579, 318);
            this.dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ControlePousada.Properties.Resources.help;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(236, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ControlePousada.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_medioMensal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_real);
            this.Controls.Add(this.lb_ano);
            this.Controls.Add(this.np_ano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_financeiro";
            this.Text = "Frm_financeiro";
            this.Load += new System.EventHandler(this.Frm_financeiro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_ano)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_medioMensal2;
        private System.Windows.Forms.NumericUpDown np_ano;
        private System.Windows.Forms.Label lb_ano;
        private System.Windows.Forms.Label lb_medioMensal;
        private System.Windows.Forms.CheckBox cb_real;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_total2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.graficos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_medioRec2 = new System.Windows.Forms.Label();
            this.np_ano = new System.Windows.Forms.NumericUpDown();
            this.lb_ano = new System.Windows.Forms.Label();
            this.lb_medioRec = new System.Windows.Forms.Label();
            this.gb_valorMedioMensa = new System.Windows.Forms.GroupBox();
            this.lb_medioArec = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_medioArec2 = new System.Windows.Forms.Label();
            this.lb_medioTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_medioTotal2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_ano)).BeginInit();
            this.gb_valorMedioMensa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(744, 96);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 1;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // graficos
            // 
            chartArea1.Name = "ChartArea1";
            this.graficos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficos.Legends.Add(legend1);
            this.graficos.Location = new System.Drawing.Point(16, 314);
            this.graficos.Name = "graficos";
            this.graficos.Size = new System.Drawing.Size(803, 261);
            this.graficos.TabIndex = 2;
            this.graficos.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "tabela";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 581);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 299);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lb_medioRec2);
            this.panel1.Location = new System.Drawing.Point(36, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // lb_medioRec2
            // 
            this.lb_medioRec2.AutoSize = true;
            this.lb_medioRec2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lb_medioRec2.ForeColor = System.Drawing.Color.Black;
            this.lb_medioRec2.Location = new System.Drawing.Point(37, 38);
            this.lb_medioRec2.Name = "lb_medioRec2";
            this.lb_medioRec2.Size = new System.Drawing.Size(100, 26);
            this.lb_medioRec2.TabIndex = 0;
            this.lb_medioRec2.Text = "R$ 00,00";
            // 
            // np_ano
            // 
            this.np_ano.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np_ano.Location = new System.Drawing.Point(87, 37);
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
            this.lb_ano.Location = new System.Drawing.Point(13, 39);
            this.lb_ano.Name = "lb_ano";
            this.lb_ano.Size = new System.Drawing.Size(68, 16);
            this.lb_ano.TabIndex = 9;
            this.lb_ano.Text = "Ano Base";
            // 
            // lb_medioRec
            // 
            this.lb_medioRec.AutoSize = true;
            this.lb_medioRec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_medioRec.ForeColor = System.Drawing.Color.White;
            this.lb_medioRec.Location = new System.Drawing.Point(36, 31);
            this.lb_medioRec.Name = "lb_medioRec";
            this.lb_medioRec.Size = new System.Drawing.Size(68, 16);
            this.lb_medioRec.TabIndex = 10;
            this.lb_medioRec.Text = "Recebido";
            // 
            // gb_valorMedioMensa
            // 
            this.gb_valorMedioMensa.BackColor = System.Drawing.Color.Transparent;
            this.gb_valorMedioMensa.Controls.Add(this.lb_medioTotal);
            this.gb_valorMedioMensa.Controls.Add(this.panel3);
            this.gb_valorMedioMensa.Controls.Add(this.lb_medioArec);
            this.gb_valorMedioMensa.Controls.Add(this.panel2);
            this.gb_valorMedioMensa.Controls.Add(this.lb_medioRec);
            this.gb_valorMedioMensa.Controls.Add(this.panel1);
            this.gb_valorMedioMensa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gb_valorMedioMensa.ForeColor = System.Drawing.Color.White;
            this.gb_valorMedioMensa.Location = new System.Drawing.Point(16, 129);
            this.gb_valorMedioMensa.Name = "gb_valorMedioMensa";
            this.gb_valorMedioMensa.Size = new System.Drawing.Size(803, 167);
            this.gb_valorMedioMensa.TabIndex = 11;
            this.gb_valorMedioMensa.TabStop = false;
            this.gb_valorMedioMensa.Text = "Valor Médio Mensal";
            // 
            // lb_medioArec
            // 
            this.lb_medioArec.AutoSize = true;
            this.lb_medioArec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_medioArec.ForeColor = System.Drawing.Color.White;
            this.lb_medioArec.Location = new System.Drawing.Point(299, 31);
            this.lb_medioArec.Name = "lb_medioArec";
            this.lb_medioArec.Size = new System.Drawing.Size(74, 16);
            this.lb_medioArec.TabIndex = 12;
            this.lb_medioArec.Text = "A Receber";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lb_medioArec2);
            this.panel2.Location = new System.Drawing.Point(302, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 11;
            // 
            // lb_medioArec2
            // 
            this.lb_medioArec2.AutoSize = true;
            this.lb_medioArec2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lb_medioArec2.ForeColor = System.Drawing.Color.Black;
            this.lb_medioArec2.Location = new System.Drawing.Point(37, 38);
            this.lb_medioArec2.Name = "lb_medioArec2";
            this.lb_medioArec2.Size = new System.Drawing.Size(100, 26);
            this.lb_medioArec2.TabIndex = 0;
            this.lb_medioArec2.Text = "R$ 00,00";
            // 
            // lb_medioTotal
            // 
            this.lb_medioTotal.AutoSize = true;
            this.lb_medioTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_medioTotal.ForeColor = System.Drawing.Color.White;
            this.lb_medioTotal.Location = new System.Drawing.Point(565, 31);
            this.lb_medioTotal.Name = "lb_medioTotal";
            this.lb_medioTotal.Size = new System.Drawing.Size(39, 16);
            this.lb_medioTotal.TabIndex = 14;
            this.lb_medioTotal.Text = "Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.lb_medioTotal2);
            this.panel3.Location = new System.Drawing.Point(568, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 13;
            // 
            // lb_medioTotal2
            // 
            this.lb_medioTotal2.AutoSize = true;
            this.lb_medioTotal2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lb_medioTotal2.ForeColor = System.Drawing.Color.Black;
            this.lb_medioTotal2.Location = new System.Drawing.Point(37, 38);
            this.lb_medioTotal2.Name = "lb_medioTotal2";
            this.lb_medioTotal2.Size = new System.Drawing.Size(100, 26);
            this.lb_medioTotal2.TabIndex = 0;
            this.lb_medioTotal2.Text = "R$ 00,00";
            // 
            // Frm_financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ControlePousada.Properties.Resources.fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 892);
            this.Controls.Add(this.gb_valorMedioMensa);
            this.Controls.Add(this.lb_ano);
            this.Controls.Add(this.np_ano);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.graficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_financeiro";
            this.Text = "Frm_financeiro";
            this.Load += new System.EventHandler(this.Frm_financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.np_ano)).EndInit();
            this.gb_valorMedioMensa.ResumeLayout(false);
            this.gb_valorMedioMensa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_medioRec2;
        private System.Windows.Forms.NumericUpDown np_ano;
        private System.Windows.Forms.Label lb_ano;
        private System.Windows.Forms.Label lb_medioRec;
        private System.Windows.Forms.GroupBox gb_valorMedioMensa;
        private System.Windows.Forms.Label lb_medioTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_medioTotal2;
        private System.Windows.Forms.Label lb_medioArec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_medioArec2;
    }
}
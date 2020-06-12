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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.gb_filtros = new System.Windows.Forms.GroupBox();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.btn_pesquisa.Location = new System.Drawing.Point(12, 56);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(142, 54);
            this.btn_pesquisa.TabIndex = 1;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_filtros
            // 
            this.gb_filtros.Controls.Add(this.lb_cidade);
            this.gb_filtros.Controls.Add(this.txt_cidade);
            this.gb_filtros.Controls.Add(this.lb_nome);
            this.gb_filtros.Controls.Add(this.txt_nome);
            this.gb_filtros.Location = new System.Drawing.Point(160, 12);
            this.gb_filtros.Name = "gb_filtros";
            this.gb_filtros.Size = new System.Drawing.Size(668, 149);
            this.gb_filtros.TabIndex = 3;
            this.gb_filtros.TabStop = false;
            this.gb_filtros.Text = "Filtros";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(164, 28);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(40, 13);
            this.lb_cidade.TabIndex = 3;
            this.lb_cidade.Text = "Cidade";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(167, 44);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(152, 20);
            this.txt_cidade.TabIndex = 2;
            this.txt_cidade.TextChanged += new System.EventHandler(this.txt_cidade_TextChanged);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(6, 28);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(85, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome do Cliente";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(9, 44);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(152, 20);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Location = new System.Drawing.Point(12, 116);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(142, 17);
            this.cb_todos.TabIndex = 4;
            this.cb_todos.Text = "Listar todas as Reservas";
            this.cb_todos.UseVisualStyleBackColor = true;
            // 
            // Frm_reservaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.cb_todos);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.gb_filtros);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_reservaConsulta";
            this.Text = "Frm_reservaConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_filtros.ResumeLayout(false);
            this.gb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.GroupBox gb_filtros;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
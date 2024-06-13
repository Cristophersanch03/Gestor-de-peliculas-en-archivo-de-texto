namespace Gestor_de_peliculas_en_archivo_de_texto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tema_formulario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.txt_director = new System.Windows.Forms.TextBox();
            this.txt_productora = new System.Windows.Forms.TextBox();
            this.cbo_generos = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tema_formulario
            // 
            this.lbl_tema_formulario.AutoSize = true;
            this.lbl_tema_formulario.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tema_formulario.ForeColor = System.Drawing.Color.White;
            this.lbl_tema_formulario.Location = new System.Drawing.Point(197, 19);
            this.lbl_tema_formulario.Name = "lbl_tema_formulario";
            this.lbl_tema_formulario.Size = new System.Drawing.Size(603, 56);
            this.lbl_tema_formulario.TabIndex = 0;
            this.lbl_tema_formulario.Text = "GESTIÓN DE PELÍCULAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Productora";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 216);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(294, 298);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(143, 42);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Navy;
            this.btn_generar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.ForeColor = System.Drawing.Color.White;
            this.btn_generar.Location = new System.Drawing.Point(294, 178);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(143, 48);
            this.btn_generar.TabIndex = 8;
            this.btn_generar.Text = "GENERAR";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Green;
            this.btn_guardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(294, 124);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(143, 48);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_titulo
            // 
            this.txt_titulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_titulo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.ForeColor = System.Drawing.Color.White;
            this.txt_titulo.Location = new System.Drawing.Point(129, 130);
            this.txt_titulo.Multiline = true;
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(143, 20);
            this.txt_titulo.TabIndex = 10;
            this.txt_titulo.TextChanged += new System.EventHandler(this.txt_titulo_TextChanged);
            // 
            // txt_duracion
            // 
            this.txt_duracion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_duracion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duracion.ForeColor = System.Drawing.Color.White;
            this.txt_duracion.Location = new System.Drawing.Point(129, 224);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(143, 22);
            this.txt_duracion.TabIndex = 12;
            this.txt_duracion.TextChanged += new System.EventHandler(this.txt_duracion_TextChanged);
            // 
            // txt_director
            // 
            this.txt_director.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_director.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_director.ForeColor = System.Drawing.Color.White;
            this.txt_director.Location = new System.Drawing.Point(129, 271);
            this.txt_director.Name = "txt_director";
            this.txt_director.Size = new System.Drawing.Size(143, 22);
            this.txt_director.TabIndex = 13;
            this.txt_director.TextChanged += new System.EventHandler(this.txt_director_TextChanged);
            // 
            // txt_productora
            // 
            this.txt_productora.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_productora.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productora.ForeColor = System.Drawing.Color.White;
            this.txt_productora.Location = new System.Drawing.Point(129, 320);
            this.txt_productora.Name = "txt_productora";
            this.txt_productora.Size = new System.Drawing.Size(143, 22);
            this.txt_productora.TabIndex = 14;
            this.txt_productora.TextChanged += new System.EventHandler(this.txt_productora_TextChanged);
            // 
            // cbo_generos
            // 
            this.cbo_generos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbo_generos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_generos.ForeColor = System.Drawing.Color.White;
            this.cbo_generos.FormattingEnabled = true;
            this.cbo_generos.Items.AddRange(new object[] {
            "Acción",
            "",
            "Aventura",
            "",
            "Comedia",
            "",
            "Drama",
            "",
            "Terror",
            "",
            "Ciencia",
            "ficción",
            "",
            "Fantasía",
            "",
            "Animación",
            "",
            "Romance"});
            this.cbo_generos.Location = new System.Drawing.Point(129, 176);
            this.cbo_generos.Name = "cbo_generos";
            this.cbo_generos.Size = new System.Drawing.Size(143, 24);
            this.cbo_generos.TabIndex = 15;
            this.cbo_generos.SelectedIndexChanged += new System.EventHandler(this.cbo_generos_SelectedIndexChanged);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Olive;
            this.btn_limpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(294, 243);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(143, 48);
            this.btn_limpiar.TabIndex = 16;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(970, 362);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cbo_generos);
            this.Controls.Add(this.txt_productora);
            this.Controls.Add(this.txt_director);
            this.Controls.Add(this.txt_duracion);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tema_formulario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tema_formulario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.TextBox txt_productora;
        private System.Windows.Forms.ComboBox cbo_generos;
        private System.Windows.Forms.Button btn_limpiar;
    }
}


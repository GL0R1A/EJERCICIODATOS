
namespace nombre1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1resultado = new System.Windows.Forms.ListBox();
            this.textBox1resultado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3PROMEDIO = new System.Windows.Forms.Button();
            this.button3general = new System.Windows.Forms.Button();
            this.button3maxmin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(35, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "ARREGLOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1resultado
            // 
            this.listBox1resultado.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1resultado.ForeColor = System.Drawing.Color.Black;
            this.listBox1resultado.FormattingEnabled = true;
            this.listBox1resultado.ItemHeight = 16;
            this.listBox1resultado.Location = new System.Drawing.Point(6, 12);
            this.listBox1resultado.Name = "listBox1resultado";
            this.listBox1resultado.Size = new System.Drawing.Size(589, 420);
            this.listBox1resultado.TabIndex = 1;
            // 
            // textBox1resultado
            // 
            this.textBox1resultado.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1resultado.ForeColor = System.Drawing.Color.Red;
            this.textBox1resultado.Location = new System.Drawing.Point(720, 12);
            this.textBox1resultado.Multiline = true;
            this.textBox1resultado.Name = "textBox1resultado";
            this.textBox1resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1resultado.Size = new System.Drawing.Size(431, 435);
            this.textBox1resultado.TabIndex = 2;
            this.textBox1resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(173, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "CARGAR ARCHIVOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3PROMEDIO
            // 
            this.button3PROMEDIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3PROMEDIO.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3PROMEDIO.Location = new System.Drawing.Point(173, 603);
            this.button3PROMEDIO.Name = "button3PROMEDIO";
            this.button3PROMEDIO.Size = new System.Drawing.Size(132, 59);
            this.button3PROMEDIO.TabIndex = 4;
            this.button3PROMEDIO.Text = "PROMEDIO PARCIAL";
            this.button3PROMEDIO.UseVisualStyleBackColor = false;
            this.button3PROMEDIO.Click += new System.EventHandler(this.button3PROMEDIO_Click);
            // 
            // button3general
            // 
            this.button3general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3general.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3general.Location = new System.Drawing.Point(35, 619);
            this.button3general.Name = "button3general";
            this.button3general.Size = new System.Drawing.Size(132, 43);
            this.button3general.TabIndex = 5;
            this.button3general.Text = "GENERAL";
            this.button3general.UseVisualStyleBackColor = false;
            this.button3general.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3maxmin
            // 
            this.button3maxmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3maxmin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3maxmin.ForeColor = System.Drawing.Color.Black;
            this.button3maxmin.Location = new System.Drawing.Point(311, 611);
            this.button3maxmin.Name = "button3maxmin";
            this.button3maxmin.Size = new System.Drawing.Size(143, 43);
            this.button3maxmin.TabIndex = 6;
            this.button3maxmin.Text = "Maximo y Minimo";
            this.button3maxmin.UseVisualStyleBackColor = false;
            this.button3maxmin.Click += new System.EventHandler(this.button3maxmin_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(311, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "BORRAR LIX";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nombre1.Properties.Resources.notas_escolares_patron_sin_fisuras_sobre_fondo_verde_oscuro_herramientas_de_dibujo_color_de_fondo_de_dibujos_animados_jbh0a51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 666);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button3maxmin);
            this.Controls.Add(this.button3general);
            this.Controls.Add(this.button3PROMEDIO);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1resultado);
            this.Controls.Add(this.listBox1resultado);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1resultado;
        private System.Windows.Forms.TextBox textBox1resultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3PROMEDIO;
        private System.Windows.Forms.Button button3general;
        private System.Windows.Forms.Button button3maxmin;
        private System.Windows.Forms.Button button3;
    }
}


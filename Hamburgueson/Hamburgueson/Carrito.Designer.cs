namespace Hamburgueson
{
    partial class Carrito
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            lista = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.take_away1 = new Hamburgueson.Take_away();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(34, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(404, 63);
            label2.TabIndex = 24;
            label2.Text = "Carrito Mustard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(663, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 46);
            label4.TabIndex = 27;
            label4.Text = "Total:";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(37, 303);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(519, 46);
            label1.TabIndex = 30;
            label1.Text = "Informanos de tus alergenos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburgueson.Properties.Resources.curso_de_gestion_de_alergenos_en_la_hosteleria_cadiz;
            this.pictureBox1.Location = new System.Drawing.Point(45, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Hamburgueson.Properties.Resources.icons8_delete_sign_64;
            this.button1.Location = new System.Drawing.Point(564, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 56);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 352);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 123);
            this.textBox1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(657, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 110);
            this.button2.TabIndex = 33;
            this.button2.Text = "Realizar pedido";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.Location = new System.Drawing.Point(671, 78);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(137, 38);
            textBox2.TabIndex = 34;
            textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lista
            // 
            lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Precio});
            lista.HideSelection = false;
            lista.Location = new System.Drawing.Point(45, 78);
            lista.Name = "lista";
            lista.Size = new System.Drawing.Size(494, 222);
            lista.TabIndex = 35;
            lista.UseCompatibleStateImageBehavior = false;
            lista.View = System.Windows.Forms.View.Details;
            lista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 241;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            // 
            // take_away1
            // 
            this.take_away1.Location = new System.Drawing.Point(270, 110);
            this.take_away1.Name = "take_away1";
            this.take_away1.Size = new System.Drawing.Size(395, 253);
            this.take_away1.TabIndex = 36;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.Controls.Add(this.take_away1);
            this.Controls.Add(lista);
            this.Controls.Add(textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Name = "Carrito";
            this.Size = new System.Drawing.Size(859, 503);
            this.Load += new System.EventHandler(this.Carrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Precio;
        private Take_away take_away1;
        private static System.Windows.Forms.TextBox textBox2;
        private static System.Windows.Forms.ListView lista;
    }
}

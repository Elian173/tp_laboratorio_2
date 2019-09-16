namespace TrabajoPractico1
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.textoNumero1 = new System.Windows.Forms.TextBox();
            this.comboBoxOperadores = new System.Windows.Forms.ComboBox();
            this.textoNumero2 = new System.Windows.Forms.TextBox();
            this.botonOperar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.botonCovertirABinario = new System.Windows.Forms.Button();
            this.botonConvertirADecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNumero1
            // 
            this.textoNumero1.Location = new System.Drawing.Point(6, 81);
            this.textoNumero1.Name = "textoNumero1";
            this.textoNumero1.Size = new System.Drawing.Size(100, 20);
            this.textoNumero1.TabIndex = 0;
            // 
            // comboBoxOperadores
            // 
            this.comboBoxOperadores.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxOperadores.Location = new System.Drawing.Point(112, 81);
            this.comboBoxOperadores.Name = "comboBoxOperadores";
            this.comboBoxOperadores.Size = new System.Drawing.Size(75, 21);
            this.comboBoxOperadores.TabIndex = 2;
            this.comboBoxOperadores.TabStop = false;
            // 
            // textoNumero2
            // 
            this.textoNumero2.Location = new System.Drawing.Point(195, 81);
            this.textoNumero2.Name = "textoNumero2";
            this.textoNumero2.Size = new System.Drawing.Size(100, 20);
            this.textoNumero2.TabIndex = 3;
            // 
            // botonOperar
            // 
            this.botonOperar.Location = new System.Drawing.Point(6, 117);
            this.botonOperar.Name = "botonOperar";
            this.botonOperar.Size = new System.Drawing.Size(100, 23);
            this.botonOperar.TabIndex = 5;
            this.botonOperar.Text = "Operar";
            this.botonOperar.UseVisualStyleBackColor = true;
            this.botonOperar.Click += new System.EventHandler(this.BotonOperar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(112, 117);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.botonCerrar.Location = new System.Drawing.Point(195, 117);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(100, 23);
            this.botonCerrar.TabIndex = 7;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(12, 29);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(24, 25);
            this.labelResultado.TabIndex = 0;
            this.labelResultado.Text = "0";
            // 
            // botonCovertirABinario
            // 
            this.botonCovertirABinario.Location = new System.Drawing.Point(6, 157);
            this.botonCovertirABinario.Name = "botonCovertirABinario";
            this.botonCovertirABinario.Size = new System.Drawing.Size(124, 23);
            this.botonCovertirABinario.TabIndex = 8;
            this.botonCovertirABinario.Text = "Convertir a binario";
            this.botonCovertirABinario.UseVisualStyleBackColor = true;
            this.botonCovertirABinario.Click += new System.EventHandler(this.BotonCovertirABinario_Click);
            // 
            // botonConvertirADecimal
            // 
            this.botonConvertirADecimal.Location = new System.Drawing.Point(171, 157);
            this.botonConvertirADecimal.Name = "botonConvertirADecimal";
            this.botonConvertirADecimal.Size = new System.Drawing.Size(124, 23);
            this.botonConvertirADecimal.TabIndex = 9;
            this.botonConvertirADecimal.Text = "Convertir a Decimal";
            this.botonConvertirADecimal.UseVisualStyleBackColor = true;
            this.botonConvertirADecimal.Click += new System.EventHandler(this.BotonConvertirADecimal_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 195);
            this.Controls.Add(this.botonConvertirADecimal);
            this.Controls.Add(this.botonCovertirABinario);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonOperar);
            this.Controls.Add(this.textoNumero2);
            this.Controls.Add(this.comboBoxOperadores);
            this.Controls.Add(this.textoNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Elian Rojas del curso 2-C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero1;
        private System.Windows.Forms.ComboBox comboBoxOperadores;
        private System.Windows.Forms.TextBox textoNumero2;
        private System.Windows.Forms.Button botonOperar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button botonCovertirABinario;
        private System.Windows.Forms.Button botonConvertirADecimal;
    }
}


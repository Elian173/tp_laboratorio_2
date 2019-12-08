namespace Tp4ElianRojas
{
    partial class FormularioCorreo
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEstadoEnvio = new System.Windows.Forms.GroupBox();
            this.richTextBoxInformacionPaquetes = new System.Windows.Forms.RichTextBox();
            this.listBoxEntregado = new System.Windows.Forms.ListBox();
            this.listBoxEnViaje = new System.Windows.Forms.ListBox();
            this.listBoxIngresado = new System.Windows.Forms.ListBox();
            this.groupBoxPaquete = new System.Windows.Forms.GroupBox();
            this.buttonMostrarTodos = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTrackingId = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTrackingId = new System.Windows.Forms.MaskedTextBox();
            this.labelEntregado = new System.Windows.Forms.Label();
            this.labelEnViaje = new System.Windows.Forms.Label();
            this.labelIngresado = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxEstadoEnvio.SuspendLayout();
            this.groupBoxPaquete.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEstadoEnvio
            // 
            this.groupBoxEstadoEnvio.Controls.Add(this.richTextBoxInformacionPaquetes);
            this.groupBoxEstadoEnvio.Controls.Add(this.listBoxEntregado);
            this.groupBoxEstadoEnvio.Controls.Add(this.listBoxEnViaje);
            this.groupBoxEstadoEnvio.Controls.Add(this.listBoxIngresado);
            this.groupBoxEstadoEnvio.Controls.Add(this.groupBoxPaquete);
            this.groupBoxEstadoEnvio.Controls.Add(this.labelEntregado);
            this.groupBoxEstadoEnvio.Controls.Add(this.labelEnViaje);
            this.groupBoxEstadoEnvio.Controls.Add(this.labelIngresado);
            this.groupBoxEstadoEnvio.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEstadoEnvio.Name = "groupBoxEstadoEnvio";
            this.groupBoxEstadoEnvio.Size = new System.Drawing.Size(545, 366);
            this.groupBoxEstadoEnvio.TabIndex = 1;
            this.groupBoxEstadoEnvio.TabStop = false;
            this.groupBoxEstadoEnvio.Text = "Estado Paquetes";
            // 
            // richTextBoxInformacionPaquetes
            // 
            this.richTextBoxInformacionPaquetes.Location = new System.Drawing.Point(17, 229);
            this.richTextBoxInformacionPaquetes.Name = "richTextBoxInformacionPaquetes";
            this.richTextBoxInformacionPaquetes.ReadOnly = true;
            this.richTextBoxInformacionPaquetes.Size = new System.Drawing.Size(271, 131);
            this.richTextBoxInformacionPaquetes.TabIndex = 11;
            this.richTextBoxInformacionPaquetes.Text = "";
            // 
            // listBoxEntregado
            // 
            this.listBoxEntregado.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxEntregado.FormattingEnabled = true;
            this.listBoxEntregado.Location = new System.Drawing.Point(359, 49);
            this.listBoxEntregado.Name = "listBoxEntregado";
            this.listBoxEntregado.Size = new System.Drawing.Size(165, 160);
            this.listBoxEntregado.TabIndex = 10;
            // 
            // listBoxEnViaje
            // 
            this.listBoxEnViaje.FormattingEnabled = true;
            this.listBoxEnViaje.Location = new System.Drawing.Point(188, 49);
            this.listBoxEnViaje.Name = "listBoxEnViaje";
            this.listBoxEnViaje.Size = new System.Drawing.Size(165, 160);
            this.listBoxEnViaje.TabIndex = 9;
            // 
            // listBoxIngresado
            // 
            this.listBoxIngresado.FormattingEnabled = true;
            this.listBoxIngresado.Location = new System.Drawing.Point(17, 49);
            this.listBoxIngresado.Name = "listBoxIngresado";
            this.listBoxIngresado.Size = new System.Drawing.Size(165, 160);
            this.listBoxIngresado.TabIndex = 8;
            // 
            // groupBoxPaquete
            // 
            this.groupBoxPaquete.Controls.Add(this.buttonMostrarTodos);
            this.groupBoxPaquete.Controls.Add(this.buttonAgregar);
            this.groupBoxPaquete.Controls.Add(this.labelDireccion);
            this.groupBoxPaquete.Controls.Add(this.labelTrackingId);
            this.groupBoxPaquete.Controls.Add(this.textBoxDireccion);
            this.groupBoxPaquete.Controls.Add(this.maskedTextBoxTrackingId);
            this.groupBoxPaquete.Location = new System.Drawing.Point(294, 229);
            this.groupBoxPaquete.Name = "groupBoxPaquete";
            this.groupBoxPaquete.Size = new System.Drawing.Size(251, 131);
            this.groupBoxPaquete.TabIndex = 7;
            this.groupBoxPaquete.TabStop = false;
            this.groupBoxPaquete.Text = "Paquete";
            // 
            // buttonMostrarTodos
            // 
            this.buttonMostrarTodos.Location = new System.Drawing.Point(133, 74);
            this.buttonMostrarTodos.Name = "buttonMostrarTodos";
            this.buttonMostrarTodos.Size = new System.Drawing.Size(97, 37);
            this.buttonMostrarTodos.TabIndex = 11;
            this.buttonMostrarTodos.Text = "Mostrar Todos";
            this.buttonMostrarTodos.UseVisualStyleBackColor = true;
            this.buttonMostrarTodos.Click += new System.EventHandler(this.buttonMostrarTodos_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(133, 23);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(97, 37);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(24, 75);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 9;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelTrackingId
            // 
            this.labelTrackingId.AutoSize = true;
            this.labelTrackingId.Location = new System.Drawing.Point(24, 23);
            this.labelTrackingId.Name = "labelTrackingId";
            this.labelTrackingId.Size = new System.Drawing.Size(63, 13);
            this.labelTrackingId.TabIndex = 8;
            this.labelTrackingId.Text = "Tracking ID";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(27, 91);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 7;
            // 
            // maskedTextBoxTrackingId
            // 
            this.maskedTextBoxTrackingId.Location = new System.Drawing.Point(27, 39);
            this.maskedTextBoxTrackingId.Mask = "###-###-####";
            this.maskedTextBoxTrackingId.Name = "maskedTextBoxTrackingId";
            this.maskedTextBoxTrackingId.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTrackingId.TabIndex = 6;
            // 
            // labelEntregado
            // 
            this.labelEntregado.AutoSize = true;
            this.labelEntregado.Location = new System.Drawing.Point(356, 33);
            this.labelEntregado.Name = "labelEntregado";
            this.labelEntregado.Size = new System.Drawing.Size(56, 13);
            this.labelEntregado.TabIndex = 5;
            this.labelEntregado.Text = "Entregado";
            // 
            // labelEnViaje
            // 
            this.labelEnViaje.AutoSize = true;
            this.labelEnViaje.Location = new System.Drawing.Point(185, 33);
            this.labelEnViaje.Name = "labelEnViaje";
            this.labelEnViaje.Size = new System.Drawing.Size(46, 13);
            this.labelEnViaje.TabIndex = 4;
            this.labelEnViaje.Text = "En Viaje";
            // 
            // labelIngresado
            // 
            this.labelIngresado.AutoSize = true;
            this.labelIngresado.Location = new System.Drawing.Point(14, 33);
            this.labelIngresado.Name = "labelIngresado";
            this.labelIngresado.Size = new System.Drawing.Size(54, 13);
            this.labelIngresado.TabIndex = 3;
            this.labelIngresado.Text = "Ingresado";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // FormularioCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 390);
            this.Controls.Add(this.groupBoxEstadoEnvio);
            this.Name = "FormularioCorreo";
            this.Text = "Correo UTN por Elian.Rojas.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioCorreo_FormClosing);
            this.groupBoxEstadoEnvio.ResumeLayout(false);
            this.groupBoxEstadoEnvio.PerformLayout();
            this.groupBoxPaquete.ResumeLayout(false);
            this.groupBoxPaquete.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEstadoEnvio;
        private System.Windows.Forms.ListBox listBoxEntregado;
        private System.Windows.Forms.ListBox listBoxEnViaje;
        private System.Windows.Forms.ListBox listBoxIngresado;
        private System.Windows.Forms.GroupBox groupBoxPaquete;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTrackingId;
        private System.Windows.Forms.Label labelEntregado;
        private System.Windows.Forms.Label labelEnViaje;
        private System.Windows.Forms.Label labelIngresado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBoxInformacionPaquetes;
        private System.Windows.Forms.Button buttonMostrarTodos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTrackingId;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}


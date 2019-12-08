using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tp4ElianRojas
{
    public partial class FormularioCorreo: Form
    {
        private Correo correo;

        public FormularioCorreo()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        private void buttonAgregar_Click( object sender, EventArgs e )
        {
            if (maskedTextBoxTrackingId.Text != string.Empty && textBoxDireccion.Text != string.Empty)
            {
                Paquete paquete = new Paquete(maskedTextBoxTrackingId.Text, textBoxDireccion.Text);
                paquete.InformaEstado += paq_InformaEstado;

                try
                {
                    correo += paquete;
                }
                catch (TrackingIdRepetidoException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "ERROR", MessageBoxButtons.OK);
                }

                ActualizarEstados();
            }
            else
            {
                MessageBox.Show("Primero ingrese todos los datos", "Error", MessageBoxButtons.OK);
            }
        }

        private void paq_InformaEstado( object sender, EventArgs e )
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        private void ActualizarEstados()
        {
            listBoxIngresado.Items.Clear();
            listBoxEnViaje.Items.Clear();
            listBoxEntregado.Items.Clear();

            foreach (Paquete paquete in correo.Paquetes)
            {
                switch (paquete.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                    listBoxIngresado.Items.Add(paquete);
                    break;

                    case Paquete.EEstado.EnViaje:
                    listBoxEnViaje.Items.Add(paquete);
                    break;

                    case Paquete.EEstado.Entregado:
                    listBoxEntregado.Items.Add(paquete);
                    break;
                }
            }
        }

        private void FormularioCorreo_FormClosing( object sender, FormClosingEventArgs e )
        {
            correo.FinEntregas();
        }

        private void buttonMostrarTodos_Click( object sender, EventArgs e )
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>) correo);
        }

        private void MostrarInformacion<T>( IMostrar<T> elemento )
        {
            string descripcion = string.Empty;

            if (elemento != null)
            {
                if (elemento is Paquete)
                {
                    descripcion = ((Paquete) elemento).MostrarDatos((IMostrar<Paquete>) elemento);
                }
                else if (elemento is Correo)
                {
                    descripcion = correo.MostrarDatos((IMostrar<List<Paquete>>) elemento);
                }

                richTextBoxInformacionPaquetes.Text = descripcion;

                try
                {
                    descripcion.Guardar("salida.txt");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error guardando el archivo", MessageBoxButtons.OK);
                }
            }
        }

        private void mostrarToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>) listBoxEntregado.SelectedItem);
        }
    }
}
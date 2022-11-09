using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP3B
{
    public partial class frmRepuesto : Form
    {

        public struct structRepuestos
        {
            public string Marca;
            public string Origen;
            public string Numero;
            public string Descripcion;
            public float Precio;
        }

        structRepuestos[] vecRepuestos = new structRepuestos[100];

        int vIndiceRegistro = 0;
        public frmRepuesto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (vIndiceRegistro < vecRepuestos.Length)
            {
                vecRepuestos[vIndiceRegistro].Marca = cboMarcaRepuesto.Text;
                vecRepuestos[vIndiceRegistro].Origen = cboOrigen.Text;
                vecRepuestos[vIndiceRegistro].Numero = txtNumero.Text;
                vecRepuestos[vIndiceRegistro].Precio = float.Parse(txtPrecio.Text);
                vecRepuestos[vIndiceRegistro].Descripcion = rtxDescripcion.Text;
                vIndiceRegistro++;
                LimpiarControl();
                MessageBox.Show("Registro exitoso");
            }
        }

        public void LimpiarControl()
        {
            cboMarcaRepuesto.Text = "";
            cboOrigen.Text = "";
            txtPrecio.Text = "";
            txtNumero.Text = "";
            rtxDescripcion.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            for (int indice = 0; indice < vecRepuestos.Length; indice++)
            {
                if (vecRepuestos[indice].Marca == cboMarca.Text)
                {
                    if (optImportado.Checked)
                    {
                        if (vecRepuestos[indice].Origen == "I")
                        {
                            rtxDescripcionIngresados.Text = rtxDescripcionIngresados.Text + "Numero: " + vecRepuestos[indice].Numero.ToString() + "Precio: " + vecRepuestos[indice].Precio.ToString() + "\n";

                        }
                    }
                    if (optNacional.Checked)
                    {
                        if (vecRepuestos[indice].Origen=="N")
                        {
                            rtxDescripcionIngresados.Text = rtxDescripcionIngresados.Text + "Numero: " + vecRepuestos[indice].Numero + "Precio:" + vecRepuestos[indice].Precio + "\n";
                        }
                    }
                }
            }
        }
    }
}

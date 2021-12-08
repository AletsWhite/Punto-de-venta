using PuntoDeVenta.BackEnd;
using PuntoDeVenta.POJOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class ProductoVenta : Form
    {
        public ProductoVenta()
        {
            
            InitializeComponent();
            lblNumeroOrde.Text = "123";
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dtvProducto.DataSource = ProductoDAO.Buscar(txtProducto.Text);
            txtClave.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void dtvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtClave.Text = dtvProducto.Rows[0].Cells[0].Value.ToString();
                txtNombre.Text = dtvProducto.Rows[0].Cells[1].Value.ToString();
                txtPrecio.Text = dtvProducto.Rows[0].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Selecciona un elemento chido");
            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            string dia = fecha.Day.ToString();
            string mes = fecha.Month.ToString();
            string año = fecha.Year.ToString();
            string formatoConsulta = año + "-" + mes + "-" + dia;

            int cantidad = int.Parse(Cantidad.Value.ToString());

            if (dtvProducto.SelectedRows == null)
            {
                if (MessageBox.Show("Comprar", "Confirmación de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ProductoDAO.agregarProductoOrden(int.Parse(lblNumeroOrde.Text), int.Parse(txtClave.Text), double.Parse(txtPrecio.Text), txtNombre.Text, formatoConsulta, cantidad);
                    dtvProducto.DataSource = ProductoDAO.Buscar(txtNombre.Text);
                    txtClave.Text = "";
                    txtNombre.Text = "";
                    txtPrecio.Text = "";

                    int numOrde = int.Parse(lblNumeroOrde.Text);
                    int nuevaOrde = numOrde + 1;
                    lblNumeroOrde.Text = nuevaOrde.ToString();
                }
                else
                {
                    MessageBox.Show("Error al comprar");
                }
            } else
            {
                MessageBox.Show("Selecciona el producto");
            }

            
        }
    }
}

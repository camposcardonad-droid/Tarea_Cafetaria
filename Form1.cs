
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Form1 : Form
    {
        public BindingList<Pedido> ListaPedidos { get; set; }

        public Form1()
        {
            InitializeComponent();
            ListaPedidos = new BindingList<Pedido>();
            dgvCafe.DataSource = ListaPedidos;
            dgvCafe.AllowUserToAddRows = false;
            dgvCafe.ReadOnly = true;
            dgvCafe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCafe.DataSource = ListaPedidos;
            cmbBoxProducto.Items.Add(new Producto("Café", 30m));
            cmbBoxProducto.Items.Add(new Producto("Té", 25m));
            cmbBoxProducto.Items.Add(new Producto("Sándwich", 55m));
            cmbBoxProducto.Items.Add(new Producto("Galletas", 20m));
            cmbBoxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPrecio.ReadOnly = true;
            nmUDCantidad.Minimum = 1;
            nmUDCantidad.Maximum = 10;
            cmbBoxProducto.SelectedIndexChanged += cmbBoxProducto_SelectedIndexChanged;
            ActualizarTotal();
        }
        private void cmbBoxProducto_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            Producto producto = cmbBoxProducto.SelectedItem as Producto;
            if (producto != null)
            {
                txtPrecio.Text = producto.Precio.ToString("C2");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = cmbBoxProducto.SelectedItem as Producto;
            if (producto == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }
            ListaPedidos.Add(new Pedido(producto, (int)nmUDCantidad.Value, chkLlevar.Checked));
            ActualizarTotal();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCafe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido para eliminar.");
                return;
            }

            Pedido seleccionado = dgvCafe.SelectedRows[0].DataBoundItem as Pedido;
            if (seleccionado != null)
            {
                ListaPedidos.Remove(seleccionado);
                ActualizarTotal();
            }
        }
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas vaciar todos los pedidos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaPedidos.Clear();
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0m;
            foreach (Pedido pedido in ListaPedidos)
            {
                total += pedido.Subtotal;
            }
            lblResultado.Text = total.ToString("C2");
        }
    }
}


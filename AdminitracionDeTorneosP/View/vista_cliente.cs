using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class vista_cliente : Form
    {
        CLIENTEDB adminCliente = new CLIENTEDB();
        int opcion = 1;

        public vista_cliente()
        {
            InitializeComponent();
            actualizar();
        }

        private void actualizar()
        {
            grid.DataSource = adminCliente.verClientes();
        }

        private int getid()
        {
            try
            {
                return int.Parse(grid.Rows[grid.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {

                Cliente cliente = new Cliente();

                cliente.DPI = dpi.Text;
                cliente.Nombres = nombres.Text;
                cliente.Apellidos = apellidos.Text;
                cliente.Telefono = telefono.Text;
                cliente.Correo = correo.Text;

                adminCliente.agregarCliente(cliente);

            }
            else if (opcion == 0)
            {


                Cliente cliente = new Cliente();

                cliente.DPI = dpi.Text;
                cliente.Nombres = nombres.Text;
                cliente.Apellidos = apellidos.Text;
                cliente.Telefono = telefono.Text;
                cliente.Correo = correo.Text;
                cliente.Id = getid();

                adminCliente.actualizarCliente(cliente);

            }

            actualizar();
            opcion = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = getid();
            Cliente clientes = adminCliente.busarCliente(id);

            dpi.Text = clientes.DPI;
            nombres.Text = clientes.Nombres;
            apellidos.Text = clientes.Apellidos;
            telefono.Text = clientes.Telefono;
            correo.Text = clientes.Correo;

            opcion = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminCliente.eliminarCliente(getid());
            actualizar();
        }
    }
}

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
    public partial class vista_usuarios : Form
    {
        USUARIODB adminUsuario = new USUARIODB();
        int opcion = 1;

        public vista_usuarios()
        {
            InitializeComponent();
            actualizar();
        }
        private void actualizar()
        {
            grid.DataSource = adminUsuario.verUsuarios();
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

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {

                Usuarios usuarios = new Usuarios();
                usuarios.DPI = dpi.Text;
                usuarios.Nombres = nombres.Text;
                usuarios.Apellidos = apellidos.Text;
                usuarios.Usuario = usario.Text;
                usuarios.Clave = contraseña.Text;
                usuarios.Telefono = telefono.Text;
                usuarios.Direccion = direccion.Text;
                usuarios.Correo = correo.Text;
                usuarios.Puesto = puesto.Text;
                usuarios.Rol = Convert.ToString(comborol.SelectedItem);

                adminUsuario.agregarUsuario(usuarios);
                actualizar();
                opcion = 1;
            }
            else if (opcion == 0)
            {

                Usuarios usuarios = new Usuarios();
                usuarios.Id = getid();
                usuarios.DPI = dpi.Text;
                usuarios.Nombres = nombres.Text;
                usuarios.Apellidos = apellidos.Text;
                usuarios.Usuario = usario.Text;
                usuarios.Clave = contraseña.Text;
                usuarios.Telefono = telefono.Text;
                usuarios.Direccion = direccion.Text;
                usuarios.Correo = correo.Text;
                usuarios.Puesto = puesto.Text;
                usuarios.Rol = Convert.ToString(comborol.SelectedItem);

                adminUsuario.actualizarUsuario(usuarios);
                actualizar();
                opcion = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = getid();

            Usuarios usuarios = adminUsuario.buscarUsuario(ID);

            dpi.Text = usuarios.DPI;
            nombres.Text = usuarios.Nombres;
            apellidos.Text = usuarios.Apellidos;
            usario.Text = usuarios.Usuario;
            contraseña.Text = usuarios.Clave;
            telefono.Text = usuarios.Telefono;
            direccion.Text = usuarios.Direccion;
            correo.Text = usuarios.Correo;
            puesto.Text = usuarios.Puesto;
            comborol.Text = usuarios.Rol;

            opcion = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminUsuario.desactivarUsuario(getid());
            actualizar();
        }
    }
}

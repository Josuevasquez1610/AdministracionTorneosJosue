using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Model;
using AdminitracionDeTorneosP.Database;


namespace AdminitracionDeTorneosP.View
{
    public partial class Reporte_Jugadores1 : Form
    {
        public Reporte_Jugadores_BD JugadoressContext = new Reporte_Jugadores_BD();

        public Reporte_Jugadores1()
        {
            InitializeComponent();
            MostrarJugadores();
        }
        public void MostrarJugadores()
        {
            ListadoJugadores.DataSource = JugadoressContext.Mostrar_Jugadores();
        }
        private void Reporte_Jugadores1_Load(object sender, EventArgs e)
        {

        }
    }
}

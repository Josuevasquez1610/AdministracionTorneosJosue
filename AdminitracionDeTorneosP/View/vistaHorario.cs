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
    public partial class vistaHorario : Form
    {
        HORARIODB adminHorario = new HORARIODB();
        int opcion = 1;

        public vistaHorario()
        {
            InitializeComponent();
            actualizar();
        }

        private void actualizar()
        {
            adminHorario.verHorarios(grid);
        }

        private string get()
        {
            try
            {
                return grid.Rows[grid.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan abierto = new TimeSpan(Convert.ToDateTime(horaabierto.Text).Hour, Convert.ToDateTime(horaabierto.Text).Minute, Convert.ToDateTime(horaabierto.Text).Second);
            TimeSpan cerrado = new TimeSpan(Convert.ToDateTime(horacierra.Text).Hour, Convert.ToDateTime(horacierra.Text).Minute, Convert.ToDateTime(horacierra.Text).Second);
            Horario horarios = new Horario();

            if (opcion == 1)
            {
                horarios.Dia = combodias.Text;
                horarios.Apertura = abierto;
                horarios.Cierre = cerrado;

                adminHorario.agregarHorario(horarios);
                opcion = 1;
                actualizar();
            }
            else if (opcion == 0)
            {
                horarios.Dia = get();
                horarios.Apertura = abierto;
                horarios.Cierre = cerrado;

                adminHorario.actualizarHorario(horarios);
                opcion = 1;
                actualizar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dia = get();

            Horario horarios = adminHorario.buscarHorario(dia);

            horaabierto.Text = Convert.ToString(horarios.Apertura);
            horacierra.Text = Convert.ToString(horarios.Cierre);
            combodias.Text = horarios.Dia;
            opcion = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminHorario.eliminarHorario(get());
            actualizar();
        }
    }
}

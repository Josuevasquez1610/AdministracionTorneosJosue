using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    class Usuarios
    {
		public int Id { get; set; }

		public string DPI { get; set; }

		public string Nombres { get; set; }

		public string Apellidos { get; set; }

		public string Usuario { get; set; }

		public string Clave { get; set; }

		public string Telefono { get; set; }

		public string Direccion { get; set; }
		
		public string Correo { get; set; }

		public string Puesto { get; set; }

		public string Rol { get; set; }

		public Boolean Activo { get; set; }
	}
}

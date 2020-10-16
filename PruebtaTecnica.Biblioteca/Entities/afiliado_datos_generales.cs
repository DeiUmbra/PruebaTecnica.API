using System;
using System.ComponentModel.DataAnnotations;

namespace PruebtaTecnica.Biblioteca.Entities
{
	public class afiliado_datos_generales
	{
		[Key]
		public int afi_id { get; set; }

		public string afi_nombre { get; set; }
		public string afi_apellido { get; set; }
		public string afi_direccion { get; set; }
		public string afi_dui { get; set; }
		public DateTime? afi_datecreated { get; set; }
		public DateTime? afi_dateupdated { get; set; }
		public int afi_status { get; set; }
	}
}
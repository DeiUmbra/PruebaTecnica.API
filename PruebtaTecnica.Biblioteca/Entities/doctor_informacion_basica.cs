using System;
using System.ComponentModel.DataAnnotations;

namespace PruebtaTecnica.Biblioteca.Entities
{
	public class doctor_informacion_basica
	{
		[Key]
		public int id_doctor { get; set; }
		public string doctor_nombre { get; set; }
		public string doctor_apellido { get; set; }
		public string doctor_codigo { get; set; }
	}
}
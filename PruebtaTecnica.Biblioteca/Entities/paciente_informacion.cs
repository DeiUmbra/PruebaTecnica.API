using System;
using System.ComponentModel.DataAnnotations;

namespace PruebtaTecnica.Biblioteca.Entities
{
	public class paciente_informacion
	{
		[Key]
		public int id_paciente { get; set; }
		public string paciente_nombre { get; set; }
		public string paciente_apellido { get; set; }
		public string paciente_direccion { get; set; }
		public string paciente_telefono { get; set; }
		public string paciente_documento { get; set; }
		public string paciente_numero_documento { get; set; }
		public DateTime? date_created { get; set; }
	}
}
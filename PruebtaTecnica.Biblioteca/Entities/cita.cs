using System;
using System.ComponentModel.DataAnnotations;

namespace PruebtaTecnica.Biblioteca.Entities
{
	public class cita
	{
		[Key]
		public int id_cita { get; set; }
		public int paciente_id { get; set; }
		public int doctor_id { get; set; }
		public DateTime fecha_cita { get; set; }

	}
}
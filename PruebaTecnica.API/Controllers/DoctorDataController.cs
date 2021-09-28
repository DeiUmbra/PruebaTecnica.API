using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebtaTecnica.Biblioteca.Contexts;
using PruebtaTecnica.Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaTecnica.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DoctorDataController : ControllerBase
	{
		private readonly appDBContext context;

		public DoctorDataController(appDBContext context)
		{
			this.context = context;
		}

		// GET: api/DoctorData
		[HttpGet]
		public IEnumerable<doctor_informacion_basica> Get()
		{
			return context.doctor_informacion_basica.ToList();
		}

		// GET: api/DoctorData/5
		[HttpGet("{id}", Name = "GetDoctor")]
		public doctor_informacion_basica Get(int id)
		{
			var doctor = context.doctor_informacion_basica.FirstOrDefault(p => p.id_doctor == id);
			return doctor;
		}

		// POST: api/DoctorData
		[HttpPost]
		public ActionResult Post([FromForm] doctor_informacion_basica doctor)
		{
			try
			{
				context.doctor_informacion_basica.Add(doctor);
				context.SaveChanges();
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest();
			}
		}

		// PUT: api/DoctorData/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromForm] doctor_informacion_basica doctor)
		{
			if (doctor.id_doctor == id)
			{
				try
				{

					context.Entry(doctor).State = EntityState.Modified;
					context.SaveChanges();
					return Ok();
				}
				catch (Exception ex)
				{
					return BadRequest();
				}
			}
			else
			{
				return BadRequest();
			}
		}

		// DELETE: api/DoctorData/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			var doctor = context.doctor_informacion_basica.FirstOrDefault(p => p.id_doctor == id);
			if (doctor != null)
			{
				context.Remove(doctor);
				context.SaveChanges();
				return Ok();
			}
			else
			{
				return BadRequest();
			}
		}
	}
}
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
	public class CitaDataController : ControllerBase
	{
		private readonly appDBContext context;

		public CitaDataController(appDBContext context)
		{
			this.context = context;
		}

		// GET: api/CitaGeneral
		[HttpGet]
		public IEnumerable<cita> Get()
		{
			return context.cita.ToList();
		}

		// GET: api/CitaGeneral/5
		[HttpGet("{id}", Name = "GetCita")]
		public cita Get(int id)
		{
			var cita = context.cita.FirstOrDefault(p => p.id_cita == id);
			return cita;
		}

		// POST: api/CitaGeneral
		[HttpPost]
		public ActionResult Post([FromForm] cita cita)
		{
			try
			{

				context.cita.Add(cita);
				context.SaveChanges();
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest();
			}
		}

		// PUT: api/CitaGeneral/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromForm] cita cita)
		{
			if (cita.id_cita == id)
			{
				try
				{
					context.Entry(cita).State = EntityState.Modified;
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

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			var cita = context.cita.FirstOrDefault(p => p.id_cita == id);
			if (cita != null)
			{
				context.Remove(cita);
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
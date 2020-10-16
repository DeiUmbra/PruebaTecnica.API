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
	public class AfliadoDataGeneralController : ControllerBase
	{
		private readonly appDBContext context;

		public AfliadoDataGeneralController(appDBContext context)
		{
			this.context = context;
		}

		// GET: api/AfliadoDataGeneral
		[HttpGet]
		public IEnumerable<afiliado_datos_generales> Get()
		{
			return context.afiliado_datos_generales.ToList();
		}

		// GET: api/AfliadoDataGeneral/5
		[HttpGet("{id}", Name = "Get")]
		public afiliado_datos_generales Get(int id)
		{
			var afiliado = context.afiliado_datos_generales.FirstOrDefault(p => p.afi_id == id);
			return afiliado;
		}

		// POST: api/AfliadoDataGeneral
		[HttpPost]
		public ActionResult Post([FromBody] afiliado_datos_generales afiliado)
		{
			try
			{
				afiliado.afi_datecreated = DateTime.Now;
				afiliado.afi_status = 1;
				context.afiliado_datos_generales.Add(afiliado);
				context.SaveChanges();
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest();
			}
		}

		// PUT: api/AfliadoDataGeneral/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromBody] afiliado_datos_generales afiliado)
		{
			if (afiliado.afi_id == id)
			{
				try
				{
					afiliado.afi_dateupdated = DateTime.Now;
					context.Entry(afiliado).State = EntityState.Modified;
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
			var afiliado = context.afiliado_datos_generales.FirstOrDefault(p => p.afi_id == id);
			if (afiliado != null)
			{
				context.Remove(afiliado);
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
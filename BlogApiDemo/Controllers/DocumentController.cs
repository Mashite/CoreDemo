using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DocumentController : ControllerBase
	{
		[HttpGet]
		[Route("CreatePdf")]
		public ActionResult<string> CreatePdf(string Html)
		{
			

				return Html.Substring(0,1); // return PDF as base64 string
			
		}
	}
}

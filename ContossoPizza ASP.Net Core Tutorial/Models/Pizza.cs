using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ContossoPizza.Models;
using ContossoPizza;

namespace ContossoPizza.Models
{
	public class Pizza
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsGlutenFree { get; set; }
	}

}



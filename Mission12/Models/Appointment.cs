using System;
using Microsoft.AspNetcore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace mission12.Models
{
	public Appointment()
	{
		[Key]
		public int AppointmentID { get; set; }
		public string Name { get; set; }
		public int Size { get; set; }
		public string Email { get; set; }
		public int Phone { get; set; }
		public string ApptTime { get; set; }
		
		
	}
}

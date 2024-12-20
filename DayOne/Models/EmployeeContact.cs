using System;
namespace DayOne.Models
{
	public class EmployeeContact
	{
		public Guid Id{ get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public Guid EmployeeId { get; set; }
		public Employee Employee { get; set; }
	}
}


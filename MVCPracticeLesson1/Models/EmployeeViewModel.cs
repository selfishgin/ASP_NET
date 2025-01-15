using System.Collections.Generic;
using MVCPracticeLesson1.Entities;

namespace MVCPracticeLesson1.Models
{
	public class EmployeeViewModel
	{
		public List<Employee> Employees { get; set; }
		public List<string> Cities { get; set; }

	}
}

﻿using System.ComponentModel.DataAnnotations;

namespace MVCPracticeLesson1.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }

	}
}

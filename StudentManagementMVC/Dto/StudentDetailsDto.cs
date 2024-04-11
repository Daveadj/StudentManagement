﻿namespace StudentManagementMVC.Dto
{
    public class StudentDetailsDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public string Gender { get; set; }
    }
}
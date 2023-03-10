﻿using Inter_Assignment.Data.Models;

namespace Inter_Assignment.Models.EmployeeModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;
        
        public string Emial { get; set; } = null!;
       
        public string PhoneNumber { get; set; } = null!;
        
        public string DateOfBirth { get; set; } = null!;
        
        public double MonthlySalary { get; set; }

        public int NumberOfCompletedTasks { get; set; }

        public IEnumerable<EmployeeReview> EmployeeReviews { get; set; } = new List<EmployeeReview>();
    }
}

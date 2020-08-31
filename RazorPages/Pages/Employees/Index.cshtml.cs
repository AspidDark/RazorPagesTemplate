﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Services;
using RazorPagesModel;

namespace RazorPages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public IEnumerable<Employee> Employees { get; set; }

        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void OnGet()
        {
            Employees = _employeeRepository.GetAllEmployees();
        }
    }
}
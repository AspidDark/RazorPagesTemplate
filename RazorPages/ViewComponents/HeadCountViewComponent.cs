using Microsoft.AspNetCore.Mvc;
using RazorPages.Services;
using RazorPagesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.ViewComponents
{
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository employeeRepository;

        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Dept? departmentName=null)
        {
            var result = employeeRepository.EmployeeCountByDept(departmentName);
            return View(result);
        }
    }
}

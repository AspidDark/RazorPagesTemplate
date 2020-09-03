using RazorPagesModel;
using System;
using System.Collections.Generic;

namespace RazorPages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployee(int id);

        Employee Update(Employee updatedEmployee);

        Employee Add(Employee newEmployee);

        Employee Delete(int id);
    }
}

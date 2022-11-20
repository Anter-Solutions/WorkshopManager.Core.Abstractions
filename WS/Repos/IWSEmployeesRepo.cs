using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.Entities;

namespace WorkshopManager.Core.Abstractions.WS.Repos
{
    /// <summary>
    /// Employees repository.
    /// </summary>
    public interface IWSEmployeesRepo
    {
        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>Collection of employees.</returns>
        IEnumerable<WSEmployee> GetAll();
        /// <summary>
        /// Get employee by id.
        /// </summary>
        /// <param name="id">Id of employee.</param>
        /// <returns>Employee.</returns>
        WSEmployee Get(int id);
        /// <summary>
        /// Adds an employee to the repository.
        /// </summary>
        /// <param name="employee">Employee</param>
        void Add(WSEmployee employee);
        /// <summary>
        /// Deletes an employee by id.
        /// </summary>
        /// <param name="id">Id of employee.</param>
        void Delete(int id);
        /// <summary>
        /// Updates an employee.
        /// </summary>
        /// <param name="updatedEmployee">Update employee.</param>
        void Update(WSEmployee updatedEmployee);
    }
}

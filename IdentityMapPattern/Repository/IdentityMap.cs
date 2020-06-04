using IdentityMapPattern.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMapPattern.Repository
{
    public class IdentityMap<T>
    {
        Hashtable entities = new Hashtable();

        public T GetByID(Guid id)
        {
            if (entities.ContainsKey(id))
            {
                return (T)entities[id];
            }
            else
            {
                return default(T);
            }
        }

        public void Store(T entity, Guid key)
        {
            if (!entities.ContainsKey(key))
            {
                entities.Add(key, entity);
            }
        }
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        private IdentityMap<Employee> _employeeMap;

        public EmployeeRepository(IdentityMap<Employee> employeeMap)
        {
            _employeeMap = employeeMap;
        }

        public Employee FindBy(Guid Id)
        {
            Employee employee = _employeeMap.GetByID(Id);

            if (employee == null)
            {
                employee = DatastoreFindBy(Id);

                if (employee != null)
                {
                    _employeeMap.Store(employee, employee.ID);
                }
            }

            return employee;
        }

        private Employee DatastoreFindBy(Guid Id)
        {
            Employee employee = default(Employee);

            // Code to hydrate employee from datastore...
            return employee;
        }
    }
}

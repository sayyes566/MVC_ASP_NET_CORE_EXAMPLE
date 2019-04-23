#region snippet_BookServiceClass
using System.Collections.Generic;
using System.Linq;
using BookStore.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace BookStore.Services
{
    public class EmployeeService
    {
        private readonly IMongoCollection<Employee> _emp;

        #region snippet_EmployeeServiceConstructor
        public EmployeeService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("BookstoreDb"));
            var database = client.GetDatabase("BookstoreDb");
            _emp = database.GetCollection<Employee>("Employee");
        }
        #endregion

        public List<Employee> Get()
        {
            return _emp.Find(book => true).ToList();
        }

        public Employee Get(string id)
        {
            return _emp.Find<Employee>(emp => emp.Id == id).FirstOrDefault();
        }

        public Employee Create(Employee emp)
        {
            _emp.InsertOne(emp);
            return emp;
        }

        public void Update(string id, Employee empIn)
        {
            _emp.ReplaceOne(emp => emp.Id == id, empIn);
        }

        public void Remove(Employee empIn)
        {
            _emp.DeleteOne(emp => emp.Id == empIn.Id);
        }

        public void Remove(string id)
        {
            _emp.DeleteOne(emp => emp.Id == id);
        }
    }
}
#endregion

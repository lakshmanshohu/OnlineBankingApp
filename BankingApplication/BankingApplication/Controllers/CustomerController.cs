using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingApplication.Models;
using BankingApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingApplication.Controllers
{
    [Route("bankmanagement/api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IBankManagementService _bankManagementService;

        public CustomerController(IBankManagementService bankManagementService) 
        {
            _bankManagementService = bankManagementService ?? throw new ArgumentNullException(nameof(bankManagementService));
        }
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _bankManagementService.GetCustomers();
        }

        //// GET: api/Customer/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _bankManagementService.Insert(customer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

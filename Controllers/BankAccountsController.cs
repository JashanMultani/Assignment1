using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Assignment1.Context;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public BankAccountsController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }
        // GET: api/<BankAccounts>
        [HttpGet]
        public IEnumerable<BankAccount> Get()
        {
            return _CRUDContext.BankAccounts;
        }

        // GET api/<BankAccounts>/5
        [HttpGet("{id}")]
        public BankAccount Get(int id)
        {
            return _CRUDContext.BankAccounts.SingleOrDefault(x => x.AccountNumber == id);
        }

        // POST api/<BankAccounts>
        [HttpPost]
        public void Post([FromBody] BankAccount bankAccount)
        {
            _CRUDContext.BankAccounts.Add(bankAccount);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<BankAccounts>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] BankAccount bankAccount)
        {
            _CRUDContext.BankAccounts.Update(bankAccount);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<BankAccounts>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.BankAccounts.FirstOrDefault(x => x.AccountNumber == id);
            if(item != null)
            {
                _CRUDContext.BankAccounts.Remove(item);
                _CRUDContext.SaveChanges();
            }

        }
    }
}

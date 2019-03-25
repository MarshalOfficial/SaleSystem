using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SaleSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashController : ControllerBase
    {
        // GET: api/Cash
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cash/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cash
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cash/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        #region CashLogin



        #endregion

        #region CustomerModule



        #endregion

        #region ProductModule



        #endregion

        #region PurchaseModule



        #endregion

        #region SaleModule



        #endregion

        #region StockAdjustmentModule



        #endregion

        #region SotckModule



        #endregion

        #region UserModule

        

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OER2.WebApi.Entities;
using OER2.WebApi.Services.Interfaces;

namespace OER2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        private readonly ISalesOrderService _salesOrderService;
        private readonly ILogger _logger;


        public SalesOrderController(ISalesOrderService salesOrderService, ILogger<SalesOrderController> logger)
        {
            _logger = logger;
            _salesOrderService = salesOrderService;
        }


        // GET: api/SalesOrder
        [HttpGet]
        public IEnumerable<SalesOrder> Get()
        {
            return _salesOrderService.GetAll();
        }

        // GET: api/SalesOrder/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SalesOrder
        [HttpPost]
        [Route("Orders")]
        public async Task Post(List<SalesOrder> orders)
        {
            await _salesOrderService.InsertMulti(orders);
        }

        
        [HttpPost]
        [Route("Order")]
        public void Post(SalesOrder order)
        {
            _salesOrderService.Insert(order);
        }

        // PUT: api/SalesOrder/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

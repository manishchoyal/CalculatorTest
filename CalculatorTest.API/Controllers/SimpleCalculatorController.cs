using CalculatorTest.API.Models;
using CalculatorTest.CoreLib;
using CalculatorTest.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculatorTest.API.Controllers
{
    [EnableCors(origins: "http://localhost:51780", headers: "*", methods: "*")]
    public class SimpleCalculatorController : ApiController
    {
        
        [HttpPost]
        [Route("Calculator/Add")]
        public IHttpActionResult Add([Required(ErrorMessage = "Numbers are required in the parameter.")] Numbers input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input passed.");
            }

            if( input == null)
            {
                return BadRequest("Invalid input passed.");
            }
                
            IDiagnostics diagnostics = new Diagnostics(LoggingMode.EntityFramework, new EntityFrameworkManager());
            ISimpleCalculator simpleCalculator = new SimpleCalculator(diagnostics);
            var response = simpleCalculator.Add(input.value1, input.value2);
            return Ok(response);
        }

       
        [HttpPost]
        [Route("Calculator/Subtract")]
        public IHttpActionResult Subtract([Required(ErrorMessage = "Numbers are required in the parameter.")] Numbers input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input passed.");
            }

            if (input == null)
            {
                return BadRequest("Invalid input passed.");
            }
            IDiagnostics diagnostics = new Diagnostics(LoggingMode.EntityFramework, new EntityFrameworkManager());
            ISimpleCalculator simpleCalculator = new SimpleCalculator(diagnostics);
            var response = simpleCalculator.Subtract(input.value1, input.value2);
            return Ok(response);
        }
        [HttpPost]
        [Route("Calculator/Multiply")]
        public IHttpActionResult Multiply([Required(ErrorMessage = "Numbers are required in the parameter.")] Numbers input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input passed.");
            }

            if (input == null)
            {
                return BadRequest("Invalid input passed.");
            }
            IDiagnostics diagnostics = new Diagnostics(LoggingMode.EntityFramework, new EntityFrameworkManager());
            ISimpleCalculator simpleCalculator = new SimpleCalculator(diagnostics);
            var response = simpleCalculator.Multiply(input.value1, input.value2);
            return Ok(response);
        }
        [HttpPost]
        [Route("Calculator/Divide")]
        public IHttpActionResult Divide([Required(ErrorMessage = "Numbers are required in the parameter.")] Numbers input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input passed.");
            }

            if (input == null)
            {
                return BadRequest("Invalid input passed.");
            }
            IDiagnostics diagnostics = new Diagnostics(LoggingMode.EntityFramework, new EntityFrameworkManager());
            ISimpleCalculator simpleCalculator = new SimpleCalculator(diagnostics);
            var response = simpleCalculator.Divide(input.value1, input.value2);
            return Ok(response);
        }
    }
}

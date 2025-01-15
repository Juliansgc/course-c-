using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_hector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal a, decimal b ) {
            return a + b;
        }

        [HttpPost]
        public decimal Post( Pepito numbers, [FromHeader] string Host, 
            [FromHeader (Name = "Control-Length")] string ContentLength,
            [FromHeader (Name = "X-Some")] string Some)
        {
            Console.WriteLine(Host);
            Console.WriteLine(ContentLength);
            Console.WriteLine(Some);
            return numbers.A + numbers.B;
        }

        [HttpPut]
        public decimal Put(decimal a, decimal b)
        {
            return a * b; 
        }

        [HttpDelete]
        public decimal Delete(decimal a, decimal b)
        {
            return a / b;
        }


    }

    public class Pepito { 
        public decimal A { get; set; }
        public decimal B { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class twynsensorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "FINE", "PERFECT", "BAD", "VERYBAD", "EXCELLENT", "GOOD", "POOR", "Hot"
    };

        private readonly ILogger<twynsensorController> _logger;

        public twynsensorController(ILogger<twynsensorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "twynsensor")]
        public IEnumerable<twynsensor> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new twynsensor
            {
                Date = DateTime.Now.AddDays(index),
                CURRENT = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
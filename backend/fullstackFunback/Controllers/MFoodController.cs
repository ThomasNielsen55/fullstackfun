using fullstackFunback.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fullstackFunback.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MFoodController : ControllerBase
    {
        private IFoodRepository _foodRepository;
        public MFoodController(IFoodRepository temp)
        {
            _foodRepository = temp;
        }
        [HttpGet]
        public IEnumerable<MarriottFood> Get()
        {
            var foodData = _foodRepository.Foods.ToArray();

            return foodData;
        }
    }
}

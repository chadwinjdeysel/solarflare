using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace solarflare.api.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase {
        private readonly Supabase.Client _client;
        private readonly IMapper _mapper;

        public TestController(Supabase.Client client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Test() {
            var kitResult = await _client
                .From<Entities.Kit>()
                .Select("*, component_kits!inner(*), components!inner(*)")
                .Where(x => x.Id == "9dbf12ec-8415-4358-af68-06f1ca93e085")
                .Single();

            var kits = _mapper.Map<Models.Kit>(kitResult);

            return Ok(kits);
        }
    }
}

using DonutShop.Data;
using DonutShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DonutShop.Controllers
{
    //[Route("donutSpecials")]
    //[ApiController]
    //public class SpecialsController : Controller
    //{
    //    private readonly DonutShopContext _db;

    //    public SpecialsController(DonutShopContext db)
    //    {
    //        _db = db;
    //    }

    //    [HttpGet]
    //    public async Task<ActionResult<List<DonutSpecial>>> GetSpecials()
    //    {
    //        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    //    }
    //}


    [Route("api/[controller]")]
    [ApiController]
    public class SpecialsController : ControllerBase
    {
        private readonly DonutShopContext _db;

        public SpecialsController(DonutShopContext db)
        {
            _db = db;
        }

        // GET: api/specials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonutSpecial>>> GetSpecials()
        {
            var specials = await _db.Specials
                                    .AsNoTracking() //AsNoTracking pour des requêtes en lecture seule pour de meilleures performances.
                                    .OrderByDescending(s => s.BasePrice)
                                    .ToListAsync();
            return Ok(specials); // Ok pour encapsuler la liste dans une réponse 200 OK.
        }

        // GET: api/decorations
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Decoration>>> GetDecorations()
        //{
        //    var specials = await _db.Decorations
        //                            .AsNoTracking() //AsNoTracking pour des requêtes en lecture seule pour de meilleures performances.
        //                            .OrderByDescending(s => s.Price)
        //                            .ToListAsync();
        //    return Ok(specials); // Ok pour encapsuler la liste dans une réponse 200 OK.
        //}
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using Project.Models.Resource;
using Project.Persistence;

namespace Project.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public MakesController(VegaDbContext _context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = _context;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes =  await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Makes>, List<MakeResource>>(makes);

        }
    }
}
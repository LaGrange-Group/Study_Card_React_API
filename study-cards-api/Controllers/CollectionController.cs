using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using study_cards_api.Data;

namespace study_cards_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CollectionController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
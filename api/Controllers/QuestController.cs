using api.Data;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/quest")]
    [ApiController]
    public class QuestController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public QuestController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var quests = _context.Quests.ToList()
            .Select(s => s.ToQuestDto());

            return Ok(quests);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var quest = _context.Quests.Find(id);

            if (quest == null) 
            {
                return NotFound();
            }

            return Ok(quest.ToQuestDto());
        }

    }
}
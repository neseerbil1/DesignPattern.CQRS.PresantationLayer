using DesignPattern.CQRS.PresantationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresantationLayer.CQRS.Handlers.PersonHandlers;
using DesignPattern.CQRS.PresantationLayer.CQRS.Queries.PersonQueries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.PresantationLayer.Controllers
{
    public class PersonController : Controller
    {
        private readonly GetPersonHumanResourceQueryHandler _getPersonHumanResourceQueryHandler;
        private readonly GetPersonByIdQueryHandler _getPersonByIDQueryHandler;
        private readonly CreatePersonHandler _createPersonHandler;

        public PersonController(GetPersonHumanResourceQueryHandler getPersonHumanResourceQueryHandler, GetPersonByIdQueryHandler getPersonByIDQueryHandler, CreatePersonHandler createPersonHandler)
        {
            _getPersonHumanResourceQueryHandler = getPersonHumanResourceQueryHandler;
            _getPersonByIDQueryHandler = getPersonByIDQueryHandler;
            _createPersonHandler = createPersonHandler;
        }

        public IActionResult Index()
        {
            var values = _getPersonHumanResourceQueryHandler.Handle(new GetPersonHumanResourceQuery());
            return View(values);
        }
        public IActionResult GetPerson(int id)
        {
            var values = _getPersonByIDQueryHandler.Handle(new GetPersonByIDQuery(id));
            return View(values);

        }
        [HttpGet]
        public IActionResult AddPerson()
        {
           
            return View();

        }
        [HttpPost]
        public IActionResult AddPerson(CreatePersonCommand command)
        {
           _createPersonHandler.Handle(command);    
            return RedirectToAction("Index");   

        }

    }
}

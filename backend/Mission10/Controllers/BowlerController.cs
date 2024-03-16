using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Data;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp) 
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var teamData = from Bowlers in _bowlerRepository.Bowlers
                           join Teams in _bowlerRepository.Teams
                           on Bowlers.TeamId equals Teams.TeamId
                           where Teams.TeamName == "Marlins" || Teams.TeamName == "Sharks"
                           select new
                           {
                               BowlerId = Bowlers.BowlerId,
                               BowlerFirstName = Bowlers.BowlerFirstName,
                               BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                               BowlerLastName = Bowlers.BowlerLastName,
                               BowlerAddress = Bowlers.BowlerAddress,
                               BowlerCity = Bowlers.BowlerCity,
                               BowlerState = Bowlers.BowlerState,
                               BowlerZip = Bowlers.BowlerZip,
                               BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                               TeamName = Teams.TeamName
                           };

            return teamData.ToList();
        }
    }
}



using Microsoft.EntityFrameworkCore;

namespace Mission10.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _Bowlercontext;

        public EFBowlerRepository(BowlerContext temp)
        {
            _Bowlercontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _Bowlercontext.Bowlers
               .Include(t => t.Team);

        public IEnumerable<Team> Teams => _Bowlercontext.Teams;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Models
{
    public partial class Team
    {
        public int TotalSalary
        {
            get
            {
                int sum = 0;

                var seasson = App.DB.Season.ToList().Last();

                var playersInTeam = App.DB.PlayerInTeam.Where(x => x.TeamId == TeamId && x.SeasonId == seasson.SeasonId).ToList();
                foreach (var player in playersInTeam)
                    sum += (int)player.Salary;

                return sum;
            }
        }
    }
}

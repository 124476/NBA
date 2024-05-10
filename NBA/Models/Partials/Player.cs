using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Models
{
    public partial class Player
    {
        public double Salary
        {
            get
            {
                double sum = 0;
                var playerInTeam = App.DB.PlayerInTeam.Where(x => x.PlayerId == PlayerId).ToList();
                foreach (var item in playerInTeam)
                {
                    sum += (double)item.Salary;
                }
                return sum;
            }
        }
        public string TeamName
        {
            get
            {
                var team = App.DB.PlayerInTeam.FirstOrDefault(x => x.PlayerId == PlayerId);

                return team.Team.TeamName;
            }
        }

        public string Exp
        {
            get
            {
                return (DateTime.Now.Year - JoinYear.Year).ToString() + " Years";
            }
        }
    }
}

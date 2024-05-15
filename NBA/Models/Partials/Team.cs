using Microsoft.Office.Interop.Excel;
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

        public int Points
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Point;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public int Rebounds
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Rebound;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public int Assists
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Assist;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public int Steals
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Steal;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public int Blocks
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Block;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public int Turnovers
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Turnover;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public int Fouls
        {
            get
            {
                var playersStatics = App.DB.PlayerStatistics.Where(x => x.TeamId == TeamId).ToList();
                int sum = 0;
                foreach (var item in playersStatics)
                {
                    sum += item.Foul;
                }

                if (App.IsRange)
                {
                    return sum / playersStatics.Count;
                }

                return sum;
            }
        }
        public string Rank
        {
            get
            {
                var teamId = App.teams.IndexOf(this);
                return teamId.ToString();
            }
        }
    }
}

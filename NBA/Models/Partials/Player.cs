using LiveCharts;
using LiveCharts.Wpf;
using OxyPlot.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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
                var teams = App.DB.PlayerInTeam.Where(x => x.PlayerId == PlayerId).ToList();

                if (App.season != null)
                    teams = teams.Where(x => x.SeasonId == App.season.SeasonId).ToList();

                var team = teams.FirstOrDefault();
                return team.Team.TeamName;
            }
        }

        public string Exp
        {
            get
            {
                if (App.season == null)
                {
                    var lastSeasson = App.DB.Season.ToList().LastOrDefault();
                    if (lastSeasson != null)
                        return (Int32.Parse(lastSeasson.Name.Split('-')[0]) - JoinYear.Year).ToString();
                    return "-";
                }
                var seasson = App.DB.Season.FirstOrDefault(x => x.SeasonId == App.season.SeasonId);
                if (seasson != null)
                    return (Int32.Parse(seasson.Name.Split('-')[0]) - JoinYear.Year).ToString();
                return "-";
            }
        }

        public string DateNow
        {
            get
            {
                if (App.season == null)
                {
                    var lastSeasson = App.DB.Season.ToList().LastOrDefault();
                    return lastSeasson.Name;
                }
                var seasson = App.DB.Season.FirstOrDefault(x => x.SeasonId == App.season.SeasonId);
                return seasson.Name;
            }
        }
    }
}

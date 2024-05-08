using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Models
{
    public partial class Matchup
    {
        public string StatusName
        {
            get
            {
                if (Status == 1)
                    return "Finished";
                return "No Start";
            }
        }
        public string Result
        {
            get
            {
                return Team_Home_Score.ToString() + " - " + Team_Away_Score.ToString();
            }
        }
    }
}

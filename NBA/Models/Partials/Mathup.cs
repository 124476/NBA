using System;
using System.Collections.Generic;
using System.Data;
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
                if (Status == -1 && Starttime <= App.dateNow)
                    return "Running";
                return "Not Start";
            }
        }
        public string Result
        {
            get
            {
                return Team_Home_Score.ToString() + " - " + Team_Away_Score.ToString();
            }
        }

        public string StatusColor
        {
            get
            {
                if (StatusName == "Finished")
                    return "Gray";
                if (StatusName == "Not Start")
                    return "Blue";
                return "Red";
            }
        }
        public bool StatusIsEn
        {
            get
            {
                if (StatusName == "Not Start")
                    return false;
                return true;
            }
        }

    }
}

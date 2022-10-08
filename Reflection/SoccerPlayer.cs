using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{

    public class SoccerPlayer : Player
    {
        
        public int Goals { get; private set; }
        public SoccerPlayer() { Goals = 0; }
        public void AddGoal() { Goals++; }

    }
}




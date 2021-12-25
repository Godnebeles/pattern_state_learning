using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattertn_state_learn
{
    public class PlayerBehaviorIdle : IPlayerBeahavior
    {
        public void Enter()
        {
            System.Console.WriteLine("Enter Idle State");
        }

        public void Exit()
        {
            System.Console.WriteLine("Exit Idle State");
        }

        public void Update()
        {
            System.Console.WriteLine("Update Idle State");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattertn_state_learn
{
    public class PlayerBehaviorAgressive : IPlayerBeahavior
    {
        public void Enter()
        {
            System.Console.WriteLine("Enter Agressive State");
        }

        public void Exit()
        {
            System.Console.WriteLine("Exit Agressive State");
        }

        public void Update()
        {
            System.Console.WriteLine("Update Agressive State");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattertn_state_learn
{
    public interface IPlayerBeahavior
    {
        void Enter();
        void Exit();
        void Update();
    }
}

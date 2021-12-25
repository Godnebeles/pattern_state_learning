

namespace pattertn_state_learn
{
    public class PlayerBehaviorActive : IPlayerBeahavior
    {
        public void Enter()
        {
            System.Console.WriteLine("Enter Active State");
        }

        public void Exit()
        {
            System.Console.WriteLine("Exit Active State");
        }

        public void Update()
        {
            System.Console.WriteLine("Update Active State");
        }
    }
}

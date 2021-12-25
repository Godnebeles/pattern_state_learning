using System;

namespace pattertn_state_learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();


            player.SetBehaviorIdle();

            player.SetBehaviorAgressive();

            player.SetBehaviorIdle();
        }
    }
}

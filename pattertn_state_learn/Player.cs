using System;
using System.Collections.Generic;


namespace pattertn_state_learn
{
    public class Player
    {
        private Dictionary<Type, IPlayerBeahavior> _beahaviorMap;
        private IPlayerBeahavior _currentBeahavior;

        public Player()
        {
            InitBeahavoir();
            SetBehaviorByDefault();
        }

        private void InitBeahavoir()
        {
            _beahaviorMap = new Dictionary<Type, IPlayerBeahavior>();

            _beahaviorMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive();
            _beahaviorMap[typeof(PlayerBehaviorAgressive)] = new PlayerBehaviorAgressive();
            _beahaviorMap[typeof(PlayerBehaviorIdle)] = new PlayerBehaviorIdle();
        }

        private void SetBehavior(IPlayerBeahavior newPlayerBeahavior)
        {
            if (_currentBeahavior != null)
                _currentBeahavior.Exit();

            _currentBeahavior = newPlayerBeahavior;
            _currentBeahavior.Enter();
        }

        private void SetBehaviorByDefault()
        {
            var behaviorByDefault = GetBehavior<PlayerBehaviorIdle>();

            SetBehavior(behaviorByDefault);
        }

        private IPlayerBeahavior GetBehavior<T>() where T : IPlayerBeahavior
        {
            var type = typeof(T);

            return (IPlayerBeahavior)_beahaviorMap[type];
        }

        public void SetBehaviorIdle()
        {
            var behavior = GetBehavior<PlayerBehaviorIdle>();

            SetBehavior(behavior);
        }

        public void SetBehaviorActive()
        {
            var behavior = GetBehavior<PlayerBehaviorActive>();

            SetBehavior(behavior);
        }

        public void SetBehaviorAgressive()
        {
            var behavior = GetBehavior<PlayerBehaviorAgressive>();

            SetBehavior(behavior);
        }
    }
}

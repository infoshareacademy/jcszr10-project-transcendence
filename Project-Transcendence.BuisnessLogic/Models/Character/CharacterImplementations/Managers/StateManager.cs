using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.States;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.Managers
{
    public class StateManager
    {
        public List<IState> StateList { get;}

        public StateManager()
        {
            StateList = new List<IState>();
        }


        public void Update()
        {
            foreach (var state in StateList)
            {
                if(state.Duration > 0)
                {
                    if(state.Duration == 0)
                    {
                        StateList.Remove(state);
                    }
                    state.Duration--;
                }
            }
        }

        public void AddState(IState state)
        {
            StateList.Add(state);
        }

        public void RemoveState(IState state)
        {
            StateList.Remove(state);
        }   

    }
}

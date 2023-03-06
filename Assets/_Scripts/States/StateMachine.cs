using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.States
{
    public enum StateGame { START_GAME, END_GAME }

    public class StateMachine
    {
        private StartGameState _startGameState;
        private StopGameState _stopGameState;
        private IState _currentState;

        public void EntryState(StateGame stateGame)
        {
            _currentState.Exit();
            switch(stateGame)
            {
                case StateGame.START_GAME:
                    _currentState = _startGameState;
                    break;
                case StateGame.END_GAME:
                    _currentState = _stopGameState;
                    break;
            }
            _currentState.Enter();
        }

    }
}

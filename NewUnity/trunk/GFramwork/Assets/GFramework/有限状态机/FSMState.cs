using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GFramework.FSM
{
    public enum Transition
    {
        NullTransition, StartTrans, RuningTrans
    }

    public enum StateID
    {
        NullState, Start, Runing
    }

    public abstract class FSMState
    {
        protected FSMSystem fsm;

        protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();
        protected StateID stateID;
        public StateID ID { get { return stateID; } }

        public FSMState(FSMSystem fsm)
        {
            this.fsm = fsm;
        }

        public void AddTransition(Transition transition, StateID stateID)
        {
            if (transition == Transition.NullTransition)
            {
                return;
            }
            if (stateID == StateID.NullState)
            {
                return;
            }
            if (map.ContainsKey(transition))
            {
                return;
            }
            map.Add(transition, stateID);
        }

        public void DeleteTransition(Transition transition)
        {
            if (transition == Transition.NullTransition)
            {
                return;
            }

            if (map.ContainsKey(transition))
            {
                map.Remove(transition);
                return;
            }
        }

        public StateID GetoutputState(Transition transition)
        {
            if (map.ContainsKey(transition))
            {
                return map[transition];
            }
            return StateID.NullState;
        }

        public virtual void DoBeforEnterint() { }

        public virtual void DoBeforLeaving() { }

        public abstract void Update();
    }
}

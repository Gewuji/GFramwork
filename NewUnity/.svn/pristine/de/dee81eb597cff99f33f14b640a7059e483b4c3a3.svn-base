using UnityEngine;
using GFramework.FSM;

public class Example_Runing : FSMState
{
    public Example_Runing(FSMSystem fsm) : base(fsm)
    {
        stateID = StateID.Runing;
    }

    public override void DoBeforEnterint()
    {
        Debug.Log(GetType().Name + "enterfunction");
    }

    public override void DoBeforLeaving()
    {
        Debug.Log(GetType().Name + "leavingfunction");
    }

    public override void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("切换到Start");
            fsm.PerformTransition(Transition.StartTrans);
        }
    }
}

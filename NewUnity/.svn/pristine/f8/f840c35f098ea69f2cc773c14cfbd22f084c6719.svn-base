
using UnityEngine;
using GFramework.FSM;

public class Example_Start : FSMState
{
    public Example_Start(FSMSystem fsm) : base(fsm)
    {
        stateID = StateID.Start;
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
            Debug.Log("切换到Runing");
            fsm.PerformTransition(Transition.RuningTrans);
        }
    }
}

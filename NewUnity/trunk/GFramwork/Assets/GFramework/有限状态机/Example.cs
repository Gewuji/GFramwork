using System.Collections;

using UnityEngine;
using GFramework.FSM;

public class Example : MonoBehaviour
{
    private FSMState fSMState;
    private FSMSystem fSMSystem;

    void Start()
    {
        fSMSystem = new FSMSystem();

        fSMState = new Example_Start(fSMSystem);
        fSMState.AddTransition(Transition.RuningTrans, StateID.Runing);
        fSMSystem.AddState(fSMState);

        fSMState = new Example_Runing(fSMSystem);
        fSMState.AddTransition(Transition.StartTrans, StateID.Start);
        fSMSystem.AddState(fSMState);

        fSMSystem.Start();
    }

    void Update()
    {
        fSMSystem.Update();
    }
}

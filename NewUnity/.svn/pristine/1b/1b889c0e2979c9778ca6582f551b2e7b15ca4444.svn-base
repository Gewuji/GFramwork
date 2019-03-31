using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GFramework.FSM
{
    /// <summary>
    /// 状态机控制系统
    /// </summary>
    public class FSMSystem
    {
        /// <summary>
        /// 保存所有状态的列表
        /// </summary>
        private List<FSMState> states;

        /// <summary>
        /// 当前状态ID（枚举）
        /// </summary>
        private StateID currentStateID;
        public StateID CurrentStateID { get { return currentStateID; } }

        /// <summary>
        /// 当前状态
        /// </summary>
        private FSMState currentState;
        public FSMState CurrentState { get { return CurrentState; } }

        public FSMSystem()
        {
            states = new List<FSMState>();//实例化队列
        }

        #region 事件函数

        public void Start()
        {
            currentState.DoBeforEnterint();
        }

        /// <summary>
        /// 每一帧执行的当前状态的函数
        /// </summary>
        public void Update()
        {
            currentState.Update();
        }

        #endregion
        /// <summary>
        /// 向状态机添加状态
        /// </summary>
        /// <param name="s">传递一个状态</param>
        public void AddState(FSMState s)
        {
            if (s == null) return;//为空返回

            if (states.Count == 0)//状态列表长度为0，没有状态
            {
                states.Add(s);//直接添加
                currentState = s;//参数状态设置为当前状态
                currentStateID = s.ID;//参数状态ID设置为当前状态ID
            }

            foreach (FSMState state in states)//已有状态则循环遍历
            {
                if (state.ID == s.ID)//如果已有该状态则返回
                {
                    return;
                }
            }
            states.Add(s);//所有判断结束，添加状态
        }

        /// <summary>
        /// 删除状态
        /// </summary>
        /// <param name="id">传递ID（枚举）</param>
        public void DeleteState(StateID id)
        {
            if (id == StateID.NullState)
            {
                return;
            }
            foreach (var state in states)//循环
            {
                if (state.ID == id)//如果保存的状态队列中有对应的状态ID则删除
                {
                    states.Remove(state);
                    return;
                }
            }
        }

        /// <summary>
        /// 状态切换
        /// </summary>
        /// <param name="trans">切换条件（枚举）</param>
        public void PerformTransition(Transition trans)
        {
            if (trans == Transition.NullTransition) return;//切换条件不为空

            StateID id = currentState.GetoutputState(trans);//获得切换条件对应的状态ID

            if (id == StateID.NullState)//状态id不能为空
            {
                return;
            }

            currentStateID = id;//条件对应ID设置为当前状态ID

            foreach (FSMState state in states)//遍历状态列表
            {
                if (state.ID == currentStateID)//如果状态列表中有对应的状态
                {
                    currentState.DoBeforLeaving();//当前状态执行退出状态操作
                    currentState = state;//设置新状态
                    currentState.DoBeforEnterint();//执行新状态进入操作
                    break;
                }
            }
        }
    }
}

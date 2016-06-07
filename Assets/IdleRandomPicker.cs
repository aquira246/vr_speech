using UnityEngine;
using System.Collections;

public class IdleRandomPicker : StateMachineBehaviour {
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //Pick one new state based off of randomness.
        float randFloat = Random.Range(0.7f, 1.0f);
        if(randFloat < 0.7)
        {
            animator.SetInteger("IdleIdx", 0);

        }
        else if (randFloat < 0.8)
        {
            animator.SetInteger("IdleIdx", 1);

        }
        else if (randFloat < 0.95)
        {
            animator.SetInteger("IdleIdx", 2);
        }
        else
        {
            animator.SetInteger("IdleIdx", 3);
            //And play sneeze sound.
        }


    }

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateMachineEnter is called when entering a statemachine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
    //
    //}

    // OnStateMachineExit is called when exiting a statemachine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
    //
    //}
}

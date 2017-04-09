using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum States { Break, Idle, Moving };

// 0: Break
// 1: Idle
// 2: Moving

public class StateMachine : MonoBehaviour {

	Movement movement;

	public States state = States.Idle;

	public float horizontal;
	public float vertical;

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<Movement>();
	}

	void Update ()
	{
		UpdateMovementState();
	}

	// INPUTS //

	public void ReceiveHorizontalAxis (float _horizontal)
	{
		horizontal = _horizontal;
	}

	public void ReceiveVerticalAxis (float _vertical)
	{
		vertical = _vertical;
	}

	// STATE CONTROL //

	void Transition (States newState)
	{
		state = newState;
	}

	bool CanTransition (States newState)
	{
		switch (state)
		{
			case States.Break:
				return new int[] { 0, 1, 2 }.Contains((int)newState);

			case States.Idle:
				return new int[] { 0, 1, 2 }.Contains((int)newState);

			case States.Moving:
				return new int[] { 0, 1, 2 }.Contains((int)newState);

			default:
				return false;
		}
	}

	// MOVEMENT //

	void UpdateMovementState ()
	{
		if (horizontal != 0 || vertical != 0)
		{
			if (CanTransition(States.Moving) || state == States.Moving)
			{
				Transition(States.Moving);
				movement.ReceiveInput(horizontal, vertical);
			}
		}
		else
		{
			if (CanTransition(States.Idle) || state == States.Idle)
			{
				Transition(States.Idle);
			}
		}
	}

	bool CanMove ()
	{
		int[] moveableStates = new int[] { 1, 2 };
		return moveableStates.Contains((int)state);
	}
}

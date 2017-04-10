using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum States { Break, Idle, Warm, Fire };

// 0: Break
// 1: Idle
// 2: Warm
// 3: Fire

public class StateMachine : MonoBehaviour {

	Movement movement;

	public States state = States.Idle;

	public bool moving;

	public float horizontal;
	public float vertical;

	public bool fire;
	public bool fireDown;
	public bool fireUp;

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<Movement>();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
		UpdateWarm();
		UpdateFire();
	}

	// INPUTS //

	public void ReceiveHVAxis (float _horizontal, float _vertical)
	{
		horizontal = _horizontal;
		vertical = _vertical;
	}

	public void ReceiveFire (bool _fire, bool _fireDown, bool _fireUp)
	{
		fire = _fire;
		fireDown = _fireDown;
		fireUp = _fireUp;
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
				return new int[] { 0, 1 }.Contains((int)newState);

			case States.Idle:
				return new int[] { 0, 1, 2 }.Contains((int)newState);

			case States.Warm:
				return new int[] { 0, 3 }.Contains((int)newState);

			case States.Fire:
				return new int[] { 0, 1 }.Contains((int)newState);

			default:
				return false;
		}
	}

	// MOVEMENT //

	void UpdateMovement ()
	{
		if (horizontal != 0 || vertical != 0)
		{
			if (CanMove())
			{
				moving = true;
				movement.ReceiveInput(horizontal, vertical);
			}
		}
		else
		{
			moving = false;
		}
	}

	bool CanMove ()
	{
		int[] moveableStates = new int[] { 1, 2 };
		return moveableStates.Contains((int)state);
	}

	// WARM AND FIRE //

	void UpdateWarm ()
	{
		if (fire && CanTransition(States.Warm))
		{
			Transition(States.Warm);
		}
	}

	void UpdateFire ()
	{
		if (fireUp && CanTransition(States.Fire))
		{
			Transition(States.Fire);
		}
	}

	// if fire is down, and can transition to warming, do so.
	// if warm, and button is up, transition to FIRING
	// if firing, and break, transition to idle

}

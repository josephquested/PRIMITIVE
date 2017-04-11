using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum States { Break, Idle };

public class StateMachine : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<Movement>();
		anim = GetComponent<Animator>();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
		UpdateAnimator();
	}

	// INPUTS //

	float horizontal;
	float vertical;

	public void ReceiveHVAxis (float _horizontal, float _vertical)
	{
		horizontal = _horizontal;
		vertical = _vertical;
	}

	// STATE CONTROL //

	public States state = States.Idle;

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
				return new int[] { 0, 1 }.Contains((int)newState);

			default:
				return false;
		}
	}

	// MOVEMENT //

	Movement movement;
	public bool moving;

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
		int[] moveableStates = new int[] { 1 };
		return moveableStates.Contains((int)state);
	}

	// ANIMATOR //

	Animator anim;

	void UpdateAnimator ()
	{
		anim.SetBool("Moving", moving);
		if (Input.GetButtonDown("Fire"))
		{
			anim.SetTrigger("360");
		}
	}
}

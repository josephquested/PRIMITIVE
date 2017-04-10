using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum States { Break, Idle, Warm, Fire, Block };

public class StateMachine : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<Movement>();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
	}

	void Update ()
	{
		UpdateWarm();
		UpdateFire();
		UpdateBlock();
	}

	// INPUTS //

	float horizontal;
	float vertical;
	bool fire;
	bool fireDown;
	bool fireUp;

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
				return new int[] { 0, 1, 2, 4 }.Contains((int)newState);

			case States.Warm:
				return new int[] { 0, 3 }.Contains((int)newState);

			case States.Fire:
				return new int[] { 0, 1 }.Contains((int)newState);

			case States.Block:
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
		int[] moveableStates = new int[] { 1, 2 };
		return moveableStates.Contains((int)state);
	}

	// OFFENCE //

	public Weapon weapon;

	void UpdateWarm ()
	{
		if (fire && CanTransition(States.Warm) && weapon.canWarm)
		{
			Transition(States.Warm);
			weapon.Warm();
		}
	}

	void UpdateFire ()
	{
		if (fireUp && CanTransition(States.Fire) && weapon.canFire)
		{
			StartCoroutine(FireRoutine());
		}
	}

	IEnumerator FireRoutine ()
	{
		Transition(States.Fire);
		weapon.Fire();

		while (weapon.firing)
		{
			yield return null;
		}

		Transition(States.Idle);
	}

	// DEFENCE //

	bool block;
	bool blockDown;
	bool blockUp;

	void UpdateBlock ()
	{
		if (blockDown && CanTransition(States.Block))
		{
			weapon.BlockStart();
		}

		if (blockUp && CanTransition(States.Idle))
		{
			weapon.BlockStop();
		}
	}

	public void ReceiveBlock (bool _block, bool _blockDown, bool _blockUp)
	{
		block = _block;
		blockDown = _blockDown;
		blockUp = _blockUp;
	}
}

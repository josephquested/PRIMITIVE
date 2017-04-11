using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// SYSTEM //

	StateMachine sm;

	void Start ()
	{
		sm = GetComponent<StateMachine>();
	}

	void Update ()
	{
		HVAxis();
	}

	// INPUTS //

	void HVAxis ()
	{
		sm.ReceiveHVAxis(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}
}

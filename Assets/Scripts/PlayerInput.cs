using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	StateMachine sm;

	void Start ()
	{
		sm = GetComponent<StateMachine>();
	}

	void Update ()
	{
		HorizontalAxis();
		VerticalAxis();
	}

	void HorizontalAxis ()
	{
		sm.ReceiveHorizontalAxis(Input.GetAxis("Horizontal"));
	}

	void VerticalAxis ()
	{
		sm.ReceiveVerticalAxis(Input.GetAxis("Vertical"));
	}
}

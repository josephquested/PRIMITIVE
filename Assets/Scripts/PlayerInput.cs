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
		HVAxis();
		Fire();
	}

	void HVAxis ()
	{
		sm.ReceiveHVAxis(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}

	void Fire ()
	{
		sm.ReceiveFire(Input.GetButton("Fire"), Input.GetButtonDown("Fire"), Input.GetButtonUp("Fire"));
	}
}

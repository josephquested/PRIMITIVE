using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;

 	// SYSTEM //

	public void ReceiveInput (float horizontal, float vertical)
	{
		// Move(GetMovement(horizontal, vertical));
	}

	// MOVEMENT //

	// Vector3 GetMovement (float horizontal, float vertical)
	// {
	// 	Vector3 movement = new Vector3(horizontal, 0, vertical);
	// 	return movement * speed;
	// }
	//
	// void Move (Vector3 movement)
	// {
	// 	transform.Translate(movement, ForceMode.Impulse);
	// }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public CharacterController characterController;

	public float movementSpeed;

	public PlayerShotController shotController;


	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;

		if(Input.GetKey(KeyCode.Space)){
			shotController.Shoot();
		}

		characterController.Move(movement * Time.deltaTime * movementSpeed);
	}
}

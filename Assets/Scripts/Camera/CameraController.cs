using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float distanceToPlayer;

	private PlayerController _player;

	private Vector3 _cameraOrbit;


	void Awake(){
		_player = FindObjectOfType<PlayerController>();		
	}

	void Start(){
		SetCameraOrbit();
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 speed = Vector3.zero;
		this.transform.position = _player.transform.position + _cameraOrbit * distanceToPlayer;
		this.transform.LookAt(_player.transform.position);
	}

	private void SetCameraOrbit(){
		_cameraOrbit = this.transform.position - _player.transform.position;
		_cameraOrbit.Normalize();
	}
}

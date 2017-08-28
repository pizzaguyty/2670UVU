using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInputScript : MonoBehaviour {

	CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
		MovementScript.KeyAction = Move;
	}

	void Move (float _movement){
		print (_movement);
	}		
}

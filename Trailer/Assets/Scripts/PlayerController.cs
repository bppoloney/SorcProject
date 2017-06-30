using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// The PlayerController class is used to handle player input
/// </summary>
public class PlayerController : MonoBehaviour {

	private PlayerBody body;

	// Use this for initialization
	void Start () {
		body = this.GetComponent<PlayerBody> ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void FixedUpdate() {
		if (Input.GetKey(KeyCode.D)) {
			body.MoveRight ();
		}

		if (Input.GetKey(KeyCode.A)) {
			body.MoveLeft ();
		}

		if (Input.GetKey(KeyCode.W)) {
			body.MoveUp ();
		}

		if (Input.GetKey(KeyCode.S)) {
			body.MoveDown ();
		}
	}
}

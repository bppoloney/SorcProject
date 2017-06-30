using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
[RequireComponent(typeof (BoxCollider2D))]
[RequireComponent(typeof (SpriteRenderer))]
public class PlayerBody : MonoBehaviour {

	const float PLAYER_SPEED = .05f;

	public Sprite downSprite;
	public Sprite upSprite;
	public Sprite leftSprite;
	public Sprite rightSprite;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = this.GetComponentInChildren<SpriteRenderer> ();
	}

	public void MoveUp() {
		transform.position = new Vector3 (transform.position.x, transform.position.y + PLAYER_SPEED, transform.position.z);
		//rigidBody.AddForce(transform.up * 1.1f);
		sr.sprite = upSprite;

	}

	public void MoveRight() {
		transform.position = new Vector3 (transform.position.x + PLAYER_SPEED, transform.position.y, transform.position.z);
		sr.sprite = rightSprite;
	}

	public void MoveLeft() {
		transform.position = new Vector3 (transform.position.x - PLAYER_SPEED, transform.position.y, transform.position.z);
		//rigidBody.AddForce(transform.right * -1.1f);
		sr.sprite = leftSprite;
	}

	public void MoveDown() {
		transform.position = new Vector3 (transform.position.x, transform.position.y - PLAYER_SPEED, transform.position.z);
		//rigidBody.AddForce(transform.up * -1.1f);
		sr.sprite = downSprite;
	}
}

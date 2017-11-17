using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float jump_power = 5.0f;

	private Rigidbody2D rigid;
	private Animator animator;
	private bool jump_state = false;
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
		animator = gameObject.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) {
			jump_state = true;
			animator.SetTrigger ("doing_jump");
		}
	}

	void FixedUpdate() {
		Jump ();
	}

	void Jump() {
		if (!jump_state)
			return;

		rigid.velocity = Vector2.zero;

		Vector2 jump_velocity = new Vector2 (0, jump_power);
		rigid.AddForce (jump_velocity, ForceMode2D.Impulse);

		jump_state = false;
	}
}

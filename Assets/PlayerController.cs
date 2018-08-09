using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2D;

	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D> ();
	}

	// うごくアル。 Translateってうごくってことある。
	void move(KeyCode arrow, int x){
		if (Input.GetKeyDown (arrow)) {
			transform.Translate (x, 0, 0);
		}
	}

	// somehow jump failing
	void Jump(){
		if (Input.GetKeyDown (KeyCode.S)) {
			float jumpForce = 200.0f;
			this.rigid2D.AddForce (new Vector2(0, jumpForce));
		}
	}

	// うちを右左に動かしてくれるアル
	void moveHorizontallyIfKeyPushed(){
		int interval = 1;
		move (KeyCode.RightArrow, interval);
		move (KeyCode.LeftArrow, -1 * interval);	
	}

	void Update () {
		Jump ();
		moveHorizontallyIfKeyPushed ();
	}
}

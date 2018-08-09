using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShumaiController : MonoBehaviour {

	// うちの位置情報とかある
	GameObject player;

	void Start(){
		// 初期化する必要があるある
		this.player = GameObject.Find ("player");
	}

	// シューマイ落ちるよい
	void Fall(){
		float velocity = -0.1f;
		transform.Translate (0, velocity, 0);		
	}

	// はみ出たらシューマイ消すある
	void DestroyIfOutOfRange(){
		float bottomPosition = -5.0f;
		if(transform.position.y < bottomPosition){
			Destroy (gameObject);
		}
	}

	float RadiusOfChineseGirl(){
		return 0.5f;
	}

	float RadiusOfPao(){
		return 1.0f;
	}

	bool IsCollided(float distanceBetweenPaoAndChineseGirl){
		return (distanceBetweenPaoAndChineseGirl < RadiusOfChineseGirl () + RadiusOfPao ());
	}

	void decreaseHP(){
		GameObject Director = GameObject.Find ("GameDirector"); 		Director.GetComponent<GameDirector> ().DecreaseHP ();
	}

	// シューマイにぶつかった時にいろいろやるある
	void ManageCollision(){
		Vector2 shumai  = transform.position; 
		Vector2 player  = this.player.transform.position;
		float   distanceBetweenShumaiAndChineseGirl = (shumai - player).magnitude;
		if (IsCollided(distanceBetweenShumaiAndChineseGirl)) {
			decreaseHP ();
			Destroy(gameObject);
		}
	}

	void Update () {
		Fall ();
		DestroyIfOutOfRange ();
		ManageCollision ();
	}
}


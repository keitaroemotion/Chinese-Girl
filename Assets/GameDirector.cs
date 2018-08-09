using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	GameObject hp;

	void Start () {
		this.hp = GameObject.Find ("hp");		
	}

	public void DecreaseHP(){
		this.hp.GetComponent<Image> ().fillAmount -= 0.1f;
	}

	void Update () {
		
	}
}

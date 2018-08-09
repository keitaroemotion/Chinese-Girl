using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShumaiGenerator : MonoBehaviour {

	public GameObject shumaiPrefab;
	float intervalsBetweenShumais = 1.1f; // 難しさある
	float timeElapsed             = 0;

	int GetHorizontalRange(){
		return Random.Range (-6, 8);
	}

	GameObject CopyPao(){
		return Instantiate (shumaiPrefab) as GameObject;
	}

	void Update () {
		this.timeElapsed += Time.deltaTime;
		if (this.timeElapsed > this.intervalsBetweenShumais) {
			this.timeElapsed = 0;
			CopyPao().transform.position = new Vector3(GetHorizontalRange(), 7, 0);
		}
	}
}


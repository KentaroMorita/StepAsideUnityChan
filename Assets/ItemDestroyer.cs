using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {
	
	private GameObject unityChan;

	// Use this for initialization
	void Start () {
		this.unityChan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		//unityちゃんとオブジェクトの距離比較
		if (this.transform.position.z - unityChan.transform.position.z < -20) {
			Destroy(this.gameObject);
		}
	}
}

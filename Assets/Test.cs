using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		// 要素数5の配列を初期化する
		string[] points = new string[5];

		// 配列の各要素に値を代入する
		points [0] = "a";
		points [1] = "b";
		points [2] = "c";
		points [3] = "d";
		points [4] = "e";

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

		for (int i = 4; i >= 0; i--	) {
			Debug.Log (points [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

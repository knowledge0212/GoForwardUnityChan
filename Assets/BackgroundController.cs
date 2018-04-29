﻿using System.Collections;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	//スクロール速度
	private float scrollSpeed = -0.03f;
	//背景終了位置
	private float deadLine = -16;
	//背景開始位置
	private float startLine = 15.8f;
	
	// Update is called once per frame
	void Update () {
		//背景を移動する
		this.transform.Translate(this.scrollSpeed,0,0);

		//画面外に出たら、画面右端に移動する
		if(transform.position.x < this.deadLine){
			this.transform.position = new Vector2 (this.startLine,0);
		}
	}
}

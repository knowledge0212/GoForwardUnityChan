using System.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;

	//AudioSource
	private AudioSource audioSource;

	void Start(){
		audioSource = this.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		this.transform.Translate(this.speed,0,0);

		//画面外に出たら消滅させる
		if(this.transform.position.x < this.deadLine){
			Destroy (this.gameObject);
		}
	}

	//他のオブジェクトに衝突した場合
	void OnCollisionEnter2D(Collision2D other){
		//Unityちゃん2Dとの衝突でなければ音を鳴らす
		if(other.gameObject.name != "UnityChan2D"){
			this.audioSource.PlayOneShot (this.audioSource.clip);
		}
	}
}

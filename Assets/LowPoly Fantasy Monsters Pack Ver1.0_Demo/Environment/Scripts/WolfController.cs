using UnityEngine;
using System.Collections;

public class WolfController : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	//animatorコンポネートを取得
	this.myAnimator=GetComponennt<Animator>();
	//走るアニメーションを開始
	this.myAnimator.SetFloat("Speed",1);
	// Update is called once per frame
	void Update () {
	}
}
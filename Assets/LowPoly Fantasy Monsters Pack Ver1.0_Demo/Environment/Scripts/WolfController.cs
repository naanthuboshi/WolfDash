using UnityEngine;
using System.Collections;

public class WolfController : MonoBehaviour {
	//アニメーションするためのコンポーネントを入れる
	Animator myAnimator;
	//狼を移動するためのコンポーネントを入れる追加
	private Rigidbody myRightbody;
	//前進するための力（追加）
	private float forwardForce=800.0f;
	//左右に移動するための力（追加）
	private float turnForce=500.0f;
    //左右の移動できる範囲（追加）
	private float movableRange=3.4f;

	// Use this for initialization
	void Start () {
		//animatorコンポネートを取得
		this.myAnimator = GetComponent<Animator>();
		//走るアニメーションを開始
		this.myAnimator.SetBool("run", true);
		//Rightbodyコンポーネントを取得（追加）
		this.myRightbody=GetComponent<Rigidbody>();
	}
	// Update is called once per frame
	void Update () {
		//狼に全方向の力を加える（追加）
		this.myRightbody.AddForce(this.transform.forward*this.forwardForce);
		//狼を矢印キーまたはボタンに応じて左右に移動させる(追加)
		if (Input.GetKey (KeyCode.LeftArrow) &this.transform.position.x< -this.movableRange) 
			//左に移動（追加)
			this.myRightbody.AddForce (-this.turnForce,0, 0);
		else if(Input.GetKey(KeyCode.RightArrow)&&this.transform.position.x<this.movableRange){
	 //右に移動（追加）
			this.myRightbody.AddForce(this.turnForce,0,0);

		}
		}
		}

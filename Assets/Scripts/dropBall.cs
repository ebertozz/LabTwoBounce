using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropBall : MonoBehaviour {

	public Text myBounces;
	public int bounceCount;

	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			transform.position = new Vector2(transform.position.x, 6f);
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){

		Debug.Log("ran this");
		bounceCount ++;
		myBounces.text = bounceCount.ToString();
	}
	
}

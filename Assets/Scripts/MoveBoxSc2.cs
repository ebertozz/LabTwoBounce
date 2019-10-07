using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxSc2 : MonoBehaviour {

float speed = 0.8f;
	
	
	// Update is called once per frame
	void Update () {

		

		if(Input.GetKey(KeyCode.RightArrow)){  // if the game hears a right arrow key press
			GetComponent<Rigidbody2D>().velocity = new Vector2(2,0); // move the transform of the attached to the right
		} else if(Input.GetKey(KeyCode.LeftArrow)){ //if the game hears a left arrow press
			GetComponent<Rigidbody2D>().velocity = new Vector2(-2,0); // move transform to the left
		} else if(!(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey (KeyCode.RightArrow))) {
			GetComponent <Rigidbody2D>().velocity = new Vector2 (0, 0);
		
		}
	}
}

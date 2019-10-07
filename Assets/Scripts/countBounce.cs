using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countBounce : MonoBehaviour {
	public Text bounceText; //The Text component we want to update.

	public int bounceCount = 0; //How many bounces this ball has had.

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			transform.position = new Vector2(transform.position.x, 2f);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		bounceCount++;
		bounceText.text = bounceCount.ToString();
	}
}

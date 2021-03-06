﻿using UnityEngine;
using System.Collections;

public partial class charactorConroller : MonoBehaviour {
	
	private float angle = 0;
	protected float speed = 0;
	private float y = 0;
	
	void Update ()
	{

		float input = Input.GetAxisRaw ("Vertical");

		if(input != 0){
			y = input;
			angle += y;
		}

		if(angle >= 90){
			angle = 90;
		}
		else if(angle <= -90){
			angle = -90;
		}

        speed = Mathf.Abs(Mathf.Sin(Mathf.Deg2Rad * angle));
		if(angle >= 90 || angle <= -90){
			speed = 0;
		}
		
		Vector2 direction = new Vector2(0, y);

		GetComponent<Rigidbody2D>().rotation = angle;
		GetComponent<Rigidbody2D>().velocity = speed * direction;
	}
}

﻿using UnityEngine;
using System.Collections;

public class charactorConroller : MonoBehaviour {
	
	private float angle = 0;
	protected float speed = 1;
	private float y = 0;
	
	void Update ()
	{

		float input = Input.GetAxisRaw ("Vertical");

		if(input != 0){
			y = input;
			angle += y;
            //Debug.Log(y);
		}

		if(angle >= 90){
			angle = 90;
		}
		else if(angle <= -90){
			angle = -90;
		}
        //Debug.Log(angle);
		
		Vector2 direction = new Vector2(0, y);

        var rigidbody = GetComponent<Rigidbody2D>();
        if(rigidbody!=null){
            rigidbody.rotation = angle;
            rigidbody.velocity = speed * direction;
        }
	}
}

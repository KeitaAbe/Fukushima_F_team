using UnityEngine;
using System.Collections;

public class charactorConroller : MonoBehaviour {
	
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

		speed = Mathf.Abs(Mathf.Cos(angle));
		if(angle >= 90 || angle <= -90){
			speed = 0;
		}
		Debug.Log("angle" + angle);
		Debug.Log("speed" + speed);
		Debug.Log("y" + y);
		
		Vector2 direction = new Vector2(0, y);

		GetComponent<Rigidbody2D>().rotation = angle;
		GetComponent<Rigidbody2D>().velocity = speed * direction;
	}
}

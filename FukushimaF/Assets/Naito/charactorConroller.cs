using UnityEngine;
using System.Collections;

public class charactorConroller : MonoBehaviour {
	
	private float angle = 0;
	protected float speed = 9;
	private float y = 0;
	
	void Update ()
	{

		float input = Input.GetAxisRaw ("Vertical");

		if(input != 0){
			y = input;
			angle += y;
			Debug.Log(y);
		}

		if(angle >= 90){
			angle = 90;
		}
		else if(angle <= -90){
			angle = -90;
		}
		Debug.Log(angle);
		speed = -(Mathf.Abs(angle) - 90) / 50;

	/*	if(speed < 0){
			speed = 0.1f;
		}*/
		//角度の絶対値が大きければスピードは遅い


		Vector2 direction = new Vector2(0, y);

		GetComponent<Rigidbody2D>().rotation = angle;
		GetComponent<Rigidbody2D>().velocity = speed * direction;
	}
}

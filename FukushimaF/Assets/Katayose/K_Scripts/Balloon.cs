using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour
{
	// : objポジションの取得変数.
	private Vector3 obj_Pos ;
	// : 時間の取得変数.
	private float   time    ;
	public  float 	speed   ;
	private float   b_Speed ;

	private int  count    ;

	void Start ()
	{
		// : ポジションの取得.
		obj_Pos = this.transform.position ;
		time = 0.0f ;

		b_Speed = speed ;
	}
	
	void Update ()
	{
		time = Time.deltaTime ;
		obj_Pos.y += speed ;
		obj_Pos.x += b_Speed ;
		this.transform.position = obj_Pos ;

		if( obj_Pos.x >= 1.0f )
		{
			b_Speed *= -1 ;
		}
		if( obj_Pos.x <= -1.0f )
		{
			b_Speed *= -1 ;
		}
	}
}

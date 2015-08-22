using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour
{
	// : objポジションの取得変数.
	private Vector3 obj_Pos ;
	// : 時間の取得変数.
	public  float 	speed   ;
	private float   b_Speed ;

	void Start ()
	{
		// : ポジションの取得.
		obj_Pos = this.transform.position ;

		b_Speed = speed ;
	}
	
	void Update ()
	{
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

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
		obj_Pos.x -= b_Speed ;
		this.transform.position = obj_Pos ;

		float pos = this.transform.position.y ;
		if( pos >= 6.5f )
		{
			Destroy(this.gameObject) ;
		}
	}
}

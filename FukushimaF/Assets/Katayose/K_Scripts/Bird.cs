using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
	// : objポジションの取得変数.
	private Vector3 obj_Pos ;
	// : 時間の取得変数.
	private float   time  ;
	private float   b_Time ;
	public  float 	speed ;

	public Sprite[] bird ;
	private int count = 0 ;

	void Start ()
	{
		obj_Pos = this.transform.position ;

		b_Time = 0.0f ;
		time = 0.0f ;
	}

	void Update ()
	{
		runEnemy() ;
		float pos = this.transform.position.x ;
		if( pos <= -9.5f )
		{
			Destroy(this.gameObject) ;
		}

		time += Time.deltaTime ;
		if( time >= 0.5f )
		{
			time = 0.0f ;

			this.GetComponent<SpriteRenderer>().sprite = bird[count] ;

			if( count == 0 )
			{
				count = 1 ;
			}
			else if( count == 1 )
			{
				count = 0 ;
			}
		}
	}


	public void runEnemy()
	{
		// : 時間の取得.
		b_Time = Time.deltaTime ;
		// : 経過時間に対応した移動・反映.
		obj_Pos.x += b_Time * -speed ;
		this.transform.position = obj_Pos ;	
	}
}
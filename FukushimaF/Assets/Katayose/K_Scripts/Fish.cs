using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour
{
	private bool  jumpFlag = true ;

	public  float thrust_UP ;
	public  float thrust_LEFT ;
	
	void Update ()
	{
		if( jumpFlag )
		{
			sound.instance.Mizuoto() ;

			GetComponent<Rigidbody2D>().AddForce(Vector2.up   * thrust_UP) ;
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * thrust_LEFT) ;
			
			//float angle = Mathf.Atan2( thrust_UP, thrust_LEFT ) * Mathf.Rad2Deg;

			jumpFlag = false ;
		}

		float pos = this.transform.position.y ;
		if( pos <= -6.5f )
		{
			Destroy(this.gameObject) ;
		}
	}
}
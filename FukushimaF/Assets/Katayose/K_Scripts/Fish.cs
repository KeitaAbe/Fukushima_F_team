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
			GetComponent<Rigidbody2D>().AddForce(Vector2.up   * thrust_UP) ;
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * thrust_LEFT) ;
			jumpFlag = false ;
		}
	}
}

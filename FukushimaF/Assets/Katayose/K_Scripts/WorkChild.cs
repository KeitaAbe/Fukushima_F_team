using UnityEngine;
using System.Collections;

public class WorkChild : MonoBehaviour
{
	Animator animator ;
	float time = 0.0f ;
	bool  isColl = false ;

	void Start ()
	{
		animator = GetComponent<Animator>() ;
		animator.speed = 0.0f ;
	}

	void Update ()
	{
		if( isColl )
		{
			animator.speed = 1.0f ;

			time += Time.deltaTime ;

			if( time >= 1.0f )
			{
				animator.speed = 0.0f ;
				Destroy(this.gameObject) ;
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		if( coll.tag == "Player" )
		{
			isColl = true ;
		}
	}
}

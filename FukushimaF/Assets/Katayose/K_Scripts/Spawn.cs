using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
	// : 発射オブジェクト.
	public GameObject[] obj ;

	private int rand ;

	void Start ()
	{
		rand = Random.Range(0, 4) ;

		switch( rand )
		{
			case 0 :
				Instantiate( obj[0], this.transform.position, Quaternion.identity ) ;
				break ;

			case 1 :
				Instantiate( obj[0], this.transform.position, Quaternion.identity ) ;
				break ;

			case 2 :
				Instantiate( obj[0], this.transform.position, Quaternion.identity ) ;
				break ;

			case 3 :
				Instantiate( obj[1], this.transform.position, Quaternion.identity ) ;
				break ;				
		}
	}
}

using UnityEngine;
using System.Collections;

public class DistansHit : MonoBehaviour
{
	public GameObject icarus ;

	private Vector2 ica_Pos ;
	private float ica_RD ;

	private Vector2 pos  ;
	private float radius ;

	private float difference ;

	void Start ()
	{
		pos = this.transform.position ;
		radius = this.transform.position.x / 2 ;

		if( !icarus )
		{
            icarus = GameObject.FindGameObjectWithTag("Player");
            if (icarus != null)
            {
                ica_Pos = icarus.transform.position;
                ica_RD = icarus.transform.localScale.x / 2;
            }
		}
	}
	
	void Update ()
	{
		difference = Vector2.Distance(ica_Pos, pos) ;

		if( difference >= 3.0f )
		{
            //Debug.Log("d") ;
		}
	}
}
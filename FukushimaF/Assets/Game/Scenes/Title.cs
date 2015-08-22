using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour
{
	void Update ()
	{
		if( Input.touchCount > 0 || Input.GetMouseButtonDown(0) )
		{
			Debug.Log("a") ;
			Application.LoadLevel("main") ;	
		}
	}
}

using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
	
	private Vector3 obj_Pos ;
	private float   time  ;

	public  float 	speed ;

	void Start ()
	{
		obj_Pos = this.transform.position ;
		time = 0.0f ;
	}

	void Update ()
	{
		time = Time.deltaTime ;

		obj_Pos.x += time * -1 * speed ;
		this.transform.position = obj_Pos ;
	}
}

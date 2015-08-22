using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
	// : objポジションの取得変数.
	private Vector3 obj_Pos ;
	// : 時間の取得変数.
	private float   time  ;
	public  float 	speed ;


	void Start ()
	{
		// : ポジションの取得.
		obj_Pos = this.transform.position ;
		time = 0.0f ;
	}

	void Update ()
	{
		runEnemy() ;
	}


	public void runEnemy()
	{
		// : 時間の取得.
		time += Time.deltaTime ;
		// : 経過時間に対応した移動・反映.
		obj_Pos.x += time * -speed ;
		this.transform.position = obj_Pos ;	
	}
}

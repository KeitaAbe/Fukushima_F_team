using UnityEngine;
using System.Collections;

public class ResultController : MonoBehaviour {

	public Vector3 StartPosition;
	public Vector3 PausePosition;
	public Vector3 EndPosition;

	public GameObject[] Digits;

	public int score;
	private int score_;

	private int phase;
	private float t;
	public float timeMove = 1f;
	
	private Transform tr;

	// Call this for Start Result Window
	void Result ( int sc ) {
		score = sc;
		phase = 1;
		t = 0;
	}



	// Use this for initialization
	void Start () {
		phase = 0;
		tr = transform;
		tr.position = StartPosition;
	}
	
	// Update is called once per frame
	void Update () {
		switch( phase )
		{
			case 0:	// wait for Result() calling
				break;
			case 1:	// slide in
				t += Time.deltaTime;
				if( t >= timeMove ) {
					t = timeMove;
					phase = 2;
				}
				Vector3 p = StartPosition * (timeMove-t)/timeMove + PausePosition * t/timeMove;
				break;
			case 2:	// Count up score
				break;
			case 3:	// Wait for touch/key
				break;
			case 4:	// slide out
				break;
			case 5: // LoadLevel
				Application.LoadLevel("Title");
				phase = 6;
				break;
			default:
				break;
		}
	}
}

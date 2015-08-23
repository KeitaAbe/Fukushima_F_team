using UnityEngine;
using System.Collections;

public class ResultController : MonoBehaviour {

	public Vector3 StartPosition;
	public Vector3 PausePosition;
	public Vector3 EndPosition;

	public GameObject[] Digits;

	public int score;
	private int score_t;

	private int phase;
	private float t;
	public float timeMove = 1f;
	
	private Transform tr;
	
	public AudioClip seRankIn;
	public AudioClip seDecide;
	private AudioSource aud;

	// Call this for Start Result Window
	void Result ( int sc ) {
		score = sc;
		score_t = 0;
		phase = 1;
		t = 0;
		//
		aud.PlayOneShot( seRankIn, 1f );
	}

	// Use this for initialization
	void Start () {
		phase = 0;
		tr = transform;
		tr.position = StartPosition;
		aud = GetComponent<AudioSource>();

		// test
		//Result( 567567 );
	}
	
	// Update is called once per frame
	void Update () {
		float r;
		Vector3 p;
		switch( phase )
		{
			case 0:	// wait for Result() calling
				t = 0;
				break;
			case 1:	// slide in
				t += Time.deltaTime;
				if( t >= timeMove ) {
					t = timeMove;
					phase = 2;
				}
				r = Mathf.Sin( Mathf.PI / 2 * t / timeMove );
				p = StartPosition * ( 1f - r ) + PausePosition * r;
				tr.position = p;
				break;
			case 2:	// Count up score
				if( score - score_t > 100000 ) score_t += 30000;
				if( score - score_t > 10000 ) score_t += 3000;
				if( score - score_t > 1000 ) score_t += 300;
				if( score - score_t > 100 ) score_t += 30;
				if( score - score_t > 10 ) score_t += 3;
				if( score - score_t > 0 ) score_t += 1;
				if( score_t >= score ){
					score_t = score;
					phase = 3;
				}
				for( int i = 0; i < Digits.Length; i++ ){
					int d = (int)Mathf.Floor( ( score_t % Mathf.Pow( 10, i+1 ) ) / Mathf.Pow( 10, i ) );
					Digits[i].SendMessage( "SetNum", d );
				}
				break;
			case 3:	// Wait for touch/key
				if( Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") )
				{
					phase = 4;
					t = 0;
					//
					aud.PlayOneShot( seDecide, 1f );
				}
				break;
			case 4:	// slide out
				t += Time.deltaTime;
				if( t >= timeMove ) {
					t = timeMove;
					phase = 5;
				}
				r = Mathf.Cos( Mathf.PI / 2 * t / timeMove );
				p = EndPosition * ( 1f - r ) + PausePosition * r;
				tr.position = p;
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

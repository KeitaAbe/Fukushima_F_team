using UnityEngine;
using System.Collections;

public class DigitController : MonoBehaviour {

	public int num;

	private Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void SetNum ( int n ) {
		num = n;
		float u = 0.0625f * n;
		rend.material.SetTextureOffset( "_MainTex", new Vector2( u, 0 ) );		
	}
}

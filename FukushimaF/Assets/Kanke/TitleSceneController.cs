using UnityEngine;
using System.Collections;

public class TitleSceneController : MonoBehaviour {

	public GameObject ica;
	private Vector3 icaP;
	public float icaA;		// Accel
	public float icaV;		// Verocity
	public float icaMax;	// Max x

	public Renderer tr;
	public Renderer br0;
	public Renderer br1;
	
	public float scTop;
	public float scBottom0;
	public float scBottom1;
	
	private float scTopU;
	private float scBottom0U;
	private float scBottom1U;
	
	private bool isTouched;

	// Use this for initialization
	void Start () {
		scTopU = 0f;
		scBottom0U = 0f;
		scBottom1U = 0f;
		icaP = ica.transform.position;
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		scTopU = ( scTopU + scTop * Time.deltaTime ) % 1f;
		scBottom0U = ( scBottom0U + scBottom0 * Time.deltaTime ) % 1f;
		scBottom1U = ( scBottom1U + scBottom1 * Time.deltaTime ) % 1f;

		tr.material.SetTextureOffset("_MainTex", new Vector2( scTopU, 0));
		br0.material.SetTextureOffset("_MainTex", new Vector2( scBottom0U, 0));
		br1.material.SetTextureOffset("_MainTex", new Vector2( scBottom1U, 0));
		
		if( !isTouched && Input.GetMouseButtonDown(0) ) {
			isTouched = true;
		}
		
		if( isTouched ) {
			icaV += icaA * Time.deltaTime;
			icaP = icaP + new Vector3( icaV * Time.deltaTime, 0f, 0f );
			ica.transform.position = icaP;
			if( icaP.x > icaMax )
				Application.LoadLevel("");
		}
	}
	
}

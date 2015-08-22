using UnityEngine;
using System.Collections;

public partial class IcarusController : MonoBehaviour {
	
	public float speed;
	public float speedAngle;
	private float angle = 0;
	
	private Script_SpriteStudio_PartsRoot spriteStudioRoot;
	private bool isKilled;

	void Start ()
	{
		spriteStudioRoot = GetComponentInChildren<Script_SpriteStudio_PartsRoot>();
		isKilled = false;
	}

	void Update ()
	{

		float input = Input.GetAxisRaw ("Vertical");
		
		if( !isKilled )
			angle += speedAngle * input * Time.deltaTime;

		angle = Mathf.Max( -90f, Mathf.Min( 90f, angle ) );

		Vector3 verocity = new Vector3(
			speed * Mathf.Cos( angle * Mathf.Deg2Rad ) * 0f,
			speed * Mathf.Sin( angle * Mathf.Deg2Rad ),
			0f
		);
		
		Vector3 angles = new Vector3( 0f, 0f, angle );

		transform.localEulerAngles = angles;
		transform.position += verocity;
		
		/*
		// TEST
		if( Input.GetMouseButtonDown(0) ){
			ChangeKilledAnimation();
		}
		*/
	}

	void ChangeKilledAnimation () {
		isKilled = true;
		angle = 0;
		spriteStudioRoot.AnimationPlay( 2, 1 );	
	}

 	void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        Die(collider.gameObject.tag);
    }

    //死亡開始
    void Die(string deadReasonTag)
    {
        Debug.Log("icarus die. -> "+deadReasonTag);
		ChangeKilledAnimation();	// Play Killed Animation...
        //Application.LoadLevel("title");	// ...But oh can't see!
    }
}

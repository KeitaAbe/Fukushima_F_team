using UnityEngine;
using System.Collections;

public partial class IcarusController : MonoBehaviour {
	
	public float speed;
	public float speedAngle;
	private float angle = 0;
	
	void Start ()
	{
		
	}

	void Update ()
	{

		float input = Input.GetAxisRaw ("Vertical");
		
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
    }
}

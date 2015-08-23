using UnityEngine;
using System.Collections;

public class WorkChild : MonoBehaviour
{
	Animator animator ;
	float time = 0.0f ;
	bool  isColl = false ;
    public GameObject _helpEmoIconPrefab = null;
    GameObject _helpEmoIcon = null;

	void Start ()
	{
		animator = GetComponent<Animator>() ;
		animator.speed = 0.0f ;

        _helpEmoIcon = GameObject.Instantiate<GameObject>(_helpEmoIconPrefab);
        _helpEmoIcon.transform.SetParent(transform, false);
        _helpEmoIcon.transform.localPosition = new Vector3(-0.5f, 0.5f, -1f);
    }

	void Update ()
	{
		if( isColl )
		{
			animator.speed = 1.0f ;

			time += Time.deltaTime ;

			if( time >= 1.0f )
			{
				animator.speed = 0.0f ;
				Destroy(this.gameObject) ;
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		if( coll.tag == "Player" )
		{
			isColl = true ;
			sound.instance.CharaGet() ;
            animator.Play("WorkChild");

            if (_helpEmoIcon)
            {
                Destroy(_helpEmoIcon);
            }
		}
	}
}

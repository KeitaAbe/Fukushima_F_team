﻿using UnityEngine;
using System.Collections;

public partial class IcarusController : MonoBehaviour {
	
	public float speed;
	public float speedAngle;
	private float angle = 0;
	

	private Script_SpriteStudio_PartsRoot spriteStudioRoot;
	private bool isKilled;
    private bool iseffect;

    public GameObject scoreObj ;
    Score scoreScr ;
    public GameObject _seshoutotsu;
    public GameObject _serakka;
    public GameObject waterEffect;
    public GameObject fireEffect;
    public GameObject damageEffect;

    float _seTimer = 0f;

    enum State
    {
        Move,
        Dead,
    }
    State _status = State.Move;
    float _deadTimer = 0f;

	void Start ()
	{

		spriteStudioRoot = GetComponentInChildren<Script_SpriteStudio_PartsRoot>();
		isKilled = false;
        iseffect = false;

        scoreObj = GameObject.Find("Score") ;
        scoreScr = scoreObj.GetComponent<Score>() ;
	}

	void Update ()
	{
        if (transform.position.y < -2.7f && !iseffect)
        {
            iseffect = true;
            Instantiate(waterEffect, transform.position, transform.rotation);
        }
        switch (_status)
        {
            case State.Move:
                {
                    Update_Move();
                }
                break;

            case State.Dead:
                {
                    _deadTimer += Time.smoothDeltaTime;
                    if (_deadTimer > 2f)
                    {
                        Application.LoadLevel("Title");
                    }
                }
                break;
        }
	}

    void Update_Move()
    {
        float input = Input.GetAxisRaw("Vertical");
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.y > ((float)Screen.height / 2f))
            {
                //上半分
                input = 1f;
            }
            else
            {
                //下半分
                input = -1f;
            }
        }

        if (!isKilled)
            angle += speedAngle * input * Time.deltaTime;

        angle = Mathf.Max(-90f, Mathf.Min(90f, angle));

        Vector3 verocity = new Vector3(
            speed * Mathf.Cos(angle * Mathf.Deg2Rad) * 0f,
            speed * Mathf.Sin(angle * Mathf.Deg2Rad),
            0f
        );

        Vector3 angles = new Vector3(0f, 0f, angle);

        transform.localEulerAngles = angles;
        transform.position += verocity;

        /*
        // TEST
        if( Input.GetMouseButtonDown(0) ){
            ChangeKilledAnimation();
        }
        */

        _seTimer += Time.smoothDeltaTime;
        if (_seTimer > 0.7f)
        {
            _seTimer = 0f;
            sound.instance.Haneoto();
        }
    }

	void ChangeKilledAnimation () {
		isKilled = true;
		angle = 0;
		spriteStudioRoot.AnimationPlay( 2, 1 );
        Update_Move();
	}

 	void OnTriggerEnter2D(Collider2D collider)
    {
        if( collider.tag == "Obstacle" )
        {
            Debug.Log(collider.gameObject.tag);
            Die(collider.gameObject.tag);
        }

        if( collider.tag == "Bonus" )
        {
            Debug.Log(collider.gameObject.tag);
            scoreScr.ScorePlus() ;
        }
    }

    //死亡開始
    void Die(string deadReasonTag)
    {
        if (_status != State.Move)
        {
            return;
        }
        if (transform.position.y > 1.3f)
        {
            GameObject obj = (GameObject)Instantiate(fireEffect, transform.position, Quaternion.identity);
            obj.transform.parent = transform;
            Invoke("waterEffectIns", 0.7f);
        }
        else if (transform.position.y > -1.6f)
        {
            Instantiate(damageEffect, transform.position, transform.rotation);
        }
        _seshoutotsu.GetComponent<AudioSource>().Play();
        _serakka.GetComponent<AudioSource>().Play();
        Debug.Log("icarus die. -> "+deadReasonTag);
		ChangeKilledAnimation();	// Play Killed Animation...
        speed = 0f;
        _status = State.Dead;
    }

    void waterEffectIns()
    {
        Vector2 pos = new Vector2(transform.position.x, -2.4f);
        Instantiate(waterEffect, pos, Quaternion.identity);
    }
}

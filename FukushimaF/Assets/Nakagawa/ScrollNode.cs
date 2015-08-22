using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollNode : MonoBehaviour {
    public float _scrollSpeed = 0f;
    Vector3 _initialPos = Vector3.zero;

    void Awake()
    {
    }

	// Use this for initialization
	void Start () {
        ScrollController.instance.AddNode(this);
        _initialPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if(ScrollController.instance==null){
            return;
        }
        //自身の初期設定されたScroll速度と、Playerの移動を加味したScrollSpeedで構成
        var speed = (_scrollSpeed * 0.5f) + (ScrollController.instance.scrollSpeed * 0.5f);
        var newPos = transform.localPosition;
        newPos.x += speed * Time.smoothDeltaTime;
        transform.localPosition = newPos;
	}

    public void ArrivedEndPoint()
    {
        var newPos = _initialPos;
        newPos.x = ScrollController.instance.scrollStartLocator.position.x;
        transform.position = newPos;
    }
}

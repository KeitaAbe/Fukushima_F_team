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
        var newPos = transform.localPosition;
        newPos.x += _scrollSpeed * Time.smoothDeltaTime;
        transform.localPosition = newPos;
	}

    public void ArrivedEndPoint()
    {
        var newPos = _initialPos;
        newPos.x = ScrollController.instance.scrollStartLocator.position.x;
        transform.position = newPos;
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollController : MonoBehaviour {
    public static ScrollController instance = null;
    public Transform scrollStartLocator = null;
    public Transform scrollEndLocator = null;
    List<ScrollNode> _nodeList = new List<ScrollNode>();

    public void AddNode(ScrollNode node)
    {
        if (!_nodeList.Contains(node))
        {
            _nodeList.Add(node);
        }
    }

    void Awake()
    {
        instance = this;
    }

    void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        foreach (var node in _nodeList)
        {
            if (node.transform.position.x < scrollEndLocator.position.x)
            {
                node.ArrivedEndPoint();
            }
        }
	}
}

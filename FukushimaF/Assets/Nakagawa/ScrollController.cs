using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollController : MonoBehaviour {
    public static ScrollController instance = null;
    public Transform scrollStartLocator = null;
    public Transform scrollEndLocator = null;
    List<ScrollNode> _nodeList = new List<ScrollNode>();

    public Transform waveRoot = null;
    public Transform waveSpawnLocator = null;
    public Transform waveKillLocator = null;
    public List<GameObject> wavePrefabs = new List<GameObject>();

    const int kWaveArraySize = 3;
    WaveController[] _waveControllers = new WaveController[kWaveArraySize];
    int _waveHead = 0;

    float _scrollSpeed = -1f;
    public float scrollSpeed { get { return _scrollSpeed; } }

    public void AddNode(ScrollNode node)
    {
        if (!_nodeList.Contains(node))
        {
            _nodeList.Add(node);
        }
    }

    public void SpawnWave()
    {
#if false
        if (_waveControllers[_waveHead] != null)
        {
            DestroyObject(_waveControllers[_waveHead].gameObject);
        }
#endif

        var index = Random.Range(0, wavePrefabs.Count - 1);
        var prefab = wavePrefabs[index];
        var gobj = ScriptableObject.Instantiate<GameObject>(prefab);
        gobj.transform.SetParent(waveRoot);
        gobj.transform.position = waveSpawnLocator.position;
        var waveController = gobj.AddComponent<WaveController>();
        _waveControllers[_waveHead] = waveController;

        _waveHead = (_waveHead + 1) % kWaveArraySize;
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
        SpawnWave();
	}

    // Update is called once per frame
    void Update()
    {
        //Playerからスクロール値を取得
        var playerGObj = GameObject.FindGameObjectWithTag("Player");
        if(playerGObj!=null){
            var ccon = playerGObj.GetComponent<charactorConroller>();
            if(ccon!=null){
                _scrollSpeed = ccon.rightVelocity * -1f;
            }
        }

        //ScrollNodeのEndLocator到着チェック
        foreach (var node in _nodeList)
        {
            if (node.transform.position.x < scrollEndLocator.position.x)
            {
                node.ArrivedEndPoint();
            }
        }
	}
}

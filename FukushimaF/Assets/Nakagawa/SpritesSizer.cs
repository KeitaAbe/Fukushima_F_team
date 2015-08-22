using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SpritesSizer : MonoBehaviour {
	public Vector2 designResolution;

    void ApplyOthroSize()
    {
        Camera.main.orthographicSize = designResolution.y / 2f / 100f;
    }

    void Awake()
    {
        ApplyOthroSize();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ApplyOthroSize();
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SystemObject : MonoBehaviour {
	public static SystemObject instance = null;

//	public SaveData SaveData = null;

    void Awake()
    {
		if (instance != null)
		{
			if (instance != this)
			{
				Destroy(gameObject);
				return;
			}
		}
		instance = this;
		DontDestroyOnLoad(gameObject);

//		SaveData = SaveData.Load();
    }

	void Start()
	{
	}
}



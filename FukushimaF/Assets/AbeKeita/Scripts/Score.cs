using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	private float score;

    void Start(){
        score = 0;
    }

	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "SCORE : " + score + " m";
	}

}

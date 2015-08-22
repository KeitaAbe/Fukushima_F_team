﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public float bonuspoint=5;
	private float score;
    IcarusController icaruscontroller;

    void Start(){
        score = 0;
        icaruscontroller = GameObject.Find("icarus_Control").GetComponent<IcarusController>();
    }

	// Update is called once per frame
	void Update () {
        score += icaruscontroller.rightVelocity * Time.deltaTime;
        GetComponent<Text>().text = "SCORE : " + score.ToString("N1") + " m";
	}

    public void ScorePlus()
    {
        score += bonuspoint;
    }

}

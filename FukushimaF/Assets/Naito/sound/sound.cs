using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	public AudioSource kettei;
	public AudioSource wing;
	public AudioSource shoutotsu;
	public AudioSource rakka;
	public AudioSource mizuoto;
	public AudioSource haneoto;
	public AudioSource charaget;
	public AudioSource gameover;
	public AudioSource rankin;


	public void Kettei(){
		kettei.Play();
	}

	public void Wing(){
		wing.Play();
	}
	
	public void Shoutotsu(){
		shoutotsu.Play();
	}

	public void Rakka(){
		rakka.Play();
	}

	public void Mizuoto(){
		mizuoto.Play();
	}

	public void Haneoto(){
		haneoto.Play();
	}

	public void CharaGet(){
		charaget.Play();
	}

	public void Gameover(){
		gameover.Play();
	}

	public void Rankin(){
		rankin.Play();
	}
}

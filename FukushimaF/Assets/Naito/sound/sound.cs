using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	public AudioClip kettei;
	public AudioClip wing;
	public AudioClip shoutotsu;
	public AudioClip rakka;
	public AudioClip mizuoto;
	public AudioClip haneoto;
	public AudioClip charaget;
	public AudioClip gameover;
	public AudioClip rankin;


	public void Kettei(){
		kettei.Play();
	}

	public void Wing(){
		wing.Play();
	}
	
	public void Shoutotsu(){
		//shoutotsu = Resources.Load("Icarus_shototsu",typeof(AudioClip))as AudioClip;
		shoutotsu.Play();
	}

	public void Rakka(){
		//rakka = Resources.Load("Icarus_Rakka",typeof(AudioClip))as AudioClip;
		rakka.Play();
	}

	public void Mizuoto(){
		//mizuoto = Resources.Load("Fish_mizuoto",typeof(AudioClip))as AudioClip;
		mizuoto.Play();
	}

	public void Haneoto(){
		//charaget = Resources.Load("Icarus_Haneoto",typeof(AudioClip))as AudioClip;
		charaget.Play();
	}

	public void CharaGet(){
		//charaget = Resources.Load("Bonus_Chara_GET",typeof(AudioClip))as AudioClip;
		charaget.Play();
	}

	public void Gameover(){
		//gameover = Resources.Load("Game_Over_Jingle",typeof(AudioClip))as AudioClip;
		gameover.Play();
	}

	public void Rankin(){
		//rankin = Resources.Load("RANK_In",typeof(AudioClip))as AudioClip;
		rankin.Play();
	}
}

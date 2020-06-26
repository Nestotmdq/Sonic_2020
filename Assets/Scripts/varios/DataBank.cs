using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataBank : MonoBehaviour {

	public Text canvaspuntaje;
    int vidas;
	bool canJ;
	int rings;
    int score;	
	public static DataBank dataBank;
	void Start () {

	dataBank = this;	
	vidas = 1;
	rings = 0;
	score = 0;
	
	}
	
	public int GetVidas(){
		return vidas;
	}
	public void SetVidas(int vida){
	vidas += vida ;
	Debug.Log("Se resto una vida");
	
	}
	
    public void SetRings(){
    rings++;
	}
	public string GetRings(){
	string rin = rings.ToString();
	return rin;
	}
	public void cerorings (){
		rings = 0;
	}
	public void sumascore(int number){

		score = score + number;
		canvaspuntaje.text = score +"";

	}
	public int getscore(){

		return score;
	}
	

	 
	}


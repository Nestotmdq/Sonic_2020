using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataBank : MonoBehaviour {

	
	
	
    int vidas;
	bool canJ;
	int rings;
	
	public static DataBank dataBank;
	void Start () {
//	Debug.Log("El juego se inicio");	
	dataBank = this;	
	vidas = 3;
	rings = 0;
	
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
	
	

	 
	}


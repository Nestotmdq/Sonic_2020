using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBank : MonoBehaviour {

	
	public static DataBank dataBank;
    int vidas;
	int puntos;

	void Start () {
	Debug.Log("El juego se inicio");	
	dataBank = this;	
	vidas = 3;
	puntos = 0;
	
	}
	
	public int GetVidas(){
		return vidas;
	}
	public void SetVidas(int vida){
	vidas += vida;
	
	}
    
	 
	}


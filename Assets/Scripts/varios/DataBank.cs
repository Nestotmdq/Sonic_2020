using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBank : MonoBehaviour {

	
	public static DataBank dataBank;
    int vidas;
	bool canJ;
	//int puntos;
	
	

	void Start () {
//	Debug.Log("El juego se inicio");	
	dataBank = this;	
	vidas = 10;
	//puntos = 0;
	
	}
	
	public int GetVidas(){
		return vidas;
	}
	public void SetVidas(int vida){
	vidas += vida ;
	//Debug.Log("Se resto una vida");
	
	}
	public void SetcanJ(bool valor){
         
		 canJ = valor;

	}
	public bool GetcanJ(){

		return canJ;
	}
    
	 
	}


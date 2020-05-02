using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBank : MonoBehaviour {

	public static DataBank dataBank;
	private int vidas;
	private int puntos;
	private int sortijas;
	private float posicionX;


	void Start () {
		
	dataBank = this;	
	vidas = 3;
	puntos = 0;
	sortijas = 0;
	posicionX = 0.0f;
	}
	
	public int GetVidas(){
		return vidas;
	}
	public void SetVidas(int vida){
	vidas += vida;
	}
	}


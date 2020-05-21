using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour {

	public void Jugar(){

		SceneManager.LoadScene("first");
	}

	public void Salir(){

		Application.Quit();
	}
}

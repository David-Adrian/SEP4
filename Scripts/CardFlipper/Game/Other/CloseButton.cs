using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour {

	[SerializeField] private Button closeBttn;
	
	void Start () {

		closeBttn.gameObject.SetActive(false);

	}

	public void bttnAppear(){

		closeBttn.gameObject.SetActive(true);

	}

	public void gameClose(){

		Application.Quit();

		Debug.Log("Game Closed!");

	}
}

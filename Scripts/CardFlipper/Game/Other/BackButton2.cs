using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton2 : MonoBehaviour {

	[SerializeField] public Button backBttn;
	
	public void backToMenu(){

		SceneManager.LoadScene(0);

	}

}

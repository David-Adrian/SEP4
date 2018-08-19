using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	[SerializeField] public Button backBttn;
	
	void Start () {

		backBttn.gameObject.SetActive(false);

	}

	public void bttnDissapper(){

		backBttn.gameObject.SetActive(false);

	}

	public void bttnAppear(){

		backBttn.gameObject.SetActive(true);

	}

	public void backToLevels(){

		SceneManager.LoadScene(2);

	}

}

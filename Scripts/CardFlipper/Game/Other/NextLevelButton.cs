using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour {

	[SerializeField] private Button nextBttn;

	// Use this for initialization
	void Start () {

		nextBttn.gameObject.SetActive(false);

	}
	
	public void OnMouseDown(){
			if(nextBttn.gameObject.activeSelf){

				
				
			}
	}


	public void nextLvLAppear(){

		nextBttn.gameObject.SetActive(true);

	}

	public void level2(){

		SceneManager.LoadScene(4);	
		
	}

	public void level3(){

		SceneManager.LoadScene(5);	
		
	}

	public void level4(){

		SceneManager.LoadScene(6);	
		
	}

}

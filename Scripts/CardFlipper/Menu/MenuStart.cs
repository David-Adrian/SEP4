using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour {

	

	[SerializeField] public Button startBttn;
	[SerializeField] private Button backBttn;
	[SerializeField] private Button exitBttn;

	//Game Types
	[SerializeField] public GameObject GameType;
	[SerializeField] public Button cardFlipper;
	[SerializeField] public Button findTheItem;

	//backgrounds
	[SerializeField] public SpriteRenderer background;
	[SerializeField] public SpriteRenderer background2;


	void Start(){
		
		backBttn.gameObject.SetActive(false);

		GameType.SetActive(false);

		background2.GetComponent<Renderer>().enabled = false;

		startBttn.onClick.AddListener(GameTypes);
		cardFlipper.onClick.AddListener(chooseLevel);
		findTheItem.onClick.AddListener(startLevel);
		backBttn.onClick.AddListener(goBack);
		exitBttn.onClick.AddListener(exitGame);
	}

	void GameTypes(){

		background.GetComponent<Renderer>().enabled = false;
		startBttn.gameObject.SetActive(false);
		exitBttn.gameObject.SetActive(false);

		GameType.SetActive(true);

		background2.GetComponent<Renderer>().enabled = true;
		backBttn.gameObject.SetActive(true);

	}

	void goBack(){

		 if(GameType.activeSelf){

			GameType.SetActive(false);
			startBttn.gameObject.SetActive(true);
			exitBttn.gameObject.SetActive(true);
			backBttn.gameObject.SetActive(false);

			background2.GetComponent<Renderer>().enabled = false;
			background.GetComponent<Renderer>().enabled = true;

		}

	}

	void chooseLevel(){

		SceneManager.LoadScene(2);					

	}
	
	void startLevel(){
		
		SceneManager.LoadScene(1);

	}

	void exitGame(){

		Application.Quit();

	}
}

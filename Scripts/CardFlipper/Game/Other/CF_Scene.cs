using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CF_Scene : MonoBehaviour {


	[SerializeField] public Button level1;
	[SerializeField] public Button level2;
	[SerializeField] public Button level3;
	[SerializeField] public Button level4;

	void Start () {

		level1.onClick.AddListener(Level1);
		level2.onClick.AddListener(Level2);
		level3.onClick.AddListener(Level3);
		level4.onClick.AddListener(Level4);

	}

	void Level1(){

		SceneManager.LoadScene(3);

	}

	void Level2(){

		SceneManager.LoadScene(4);
	}

	void Level3(){

		SceneManager.LoadScene(5);
	}

	void Level4(){

		SceneManager.LoadScene(6);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlPassedSign : MonoBehaviour {

	public GameObject sign;
	public AudioSource sound;

	void Start () {
		
		sign.SetActive(false);

	}
	
	
	public void appear(){

		sign.SetActive(true);
		sound.Play();

	}
}

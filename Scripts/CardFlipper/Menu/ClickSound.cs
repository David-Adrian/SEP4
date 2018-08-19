using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClickSound : MonoBehaviour {

	public AudioSource click;
	
	public void playClick(){
		click.Play();
	}
}

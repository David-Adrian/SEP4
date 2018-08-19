using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalCard4 : MonoBehaviour {

	[SerializeField] private GameObject CardBack;

	[SerializeField] private AudioSource clicks;

	[SerializeField] private SceneController4 sceneController;

	private bool revealed = false;

	public void OnMouseDown(){
			if(CardBack.activeSelf && sceneController.canReveal){

				clicks.Play();

				CardBack.SetActive(false);
				sceneController.cardRevealead(this);
				revealed = true;
			}
	}

	private int id;

	public int getId{
		get { return id; }
	}

	public void spriteChange(int id,Sprite image){

		this.id = id;
		GetComponent<SpriteRenderer>().sprite = image;

	}

	public bool isRevealed(){
		return revealed;
	}

	public void unreveal(){
		CardBack.SetActive(true);
		revealed = false;
	}

}

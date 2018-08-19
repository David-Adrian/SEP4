using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController4 : MonoBehaviour {
	
	[SerializeField] public  int rows;
	[SerializeField] public  int cols;
	public const float offsetX = 9f;
	public const float offsetY = 6.6f;
	
	private OriginalCard4 firstCard;
	private OriginalCard4 secondCard;	
	private int score = 0;

	public lvlPassedSign lvlPassedSign;

	private bool gameStatus = false;

	[SerializeField] public int scoreMax = 0;
	[SerializeField] private CloseButton CloseButton;
	[SerializeField] private BackButton BackButton;
	[SerializeField] OriginalCard4 originalCard;
	[SerializeField] Sprite[] clones;

	void Start () {

		//Cards
		Vector3 startPos = originalCard.transform.position;

		int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7};

		numbers = Schuffle(numbers);

		for(int i = 0; i < cols; i++){
			for(int j = 0; j < rows; j++){

				OriginalCard4 card;

				if(i == 0 && j == 0){

					card = originalCard;

				}else{

					card = Instantiate(originalCard) as OriginalCard4;
					card.gameObject.tag = "CardTag";

				}

				int index = j * cols + i;
				int id = numbers[index];
				card.spriteChange(id, clones[id]);

				float posX = (offsetX * i) + startPos.x;
				float posY = (offsetY * j) + startPos.y;
				card.transform.position = new Vector3(posX, posY, startPos.z);

			}
		}

	}

	private int[] Schuffle(int[] numbers){
		
		int[] newArray = numbers.Clone() as int[];

		for(int i = 0; i < newArray.Length; i++){

			int temp = newArray[i];
			int r = Random.Range(i, newArray.Length);
			newArray[i] = newArray[r];
			newArray[r] = temp;

		}

		return newArray;

	}

	public bool canReveal{

		get { return secondCard == null; }

	}

	public void cardRevealead(OriginalCard4 card){

		if( firstCard == null){
			
			firstCard = card;
		
		}else{

			secondCard = card;
			StartCoroutine(matchCheck());

		}
	}

	IEnumerator matchCheck(){

		if( firstCard.getId == secondCard.getId){

			score++;
			gameFinished();

		}else{
			yield return new WaitForSeconds(0.5f);

			firstCard.unreveal();
			secondCard.unreveal();

		}

		firstCard = null;
		secondCard = null;

	}

	void gameFinished(){

		if(score == scoreMax){
			BackButton.bttnAppear();
			CloseButton.bttnAppear();

			GameObject[] temps = GameObject.FindGameObjectsWithTag("CardTag");

			for(int i = 0; i <= temps.Length - 1; i++){
				temps[i].SetActive(false);
			}

			lvlPassedSign.appear();
				
			gameStatus = true;

		}else
			gameStatus = false;
	}

	public bool GameStatus(){
		return gameStatus;
	}
}

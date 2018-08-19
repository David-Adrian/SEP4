using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameTextObjects : MonoBehaviour {

    public const float offsetX = 10f;
    public const float offsetY = 10f;
    [SerializeField] public int rows = 6;
    
    public GameObject[] ObjArray;
    public GameObject[] placeholders;

    public string[] lvlDone;
    
   
    
    void Start()
    {
        ListItems();
    }

    //goes through the item array shrinking it
    public void arrayReset()
    {
        for (int i = 0; i < ObjArray.Length - 5; i++)
        {
            ObjArray[i] = ObjArray[i + 5];

        }
        System.Array.Resize(ref ObjArray, ObjArray.Length - 5);
        ListItems();
    }

    //changes the empty text boxes, in the placeholders array, to 5 elements from the item array
    //if there are no elements in the item array then the text boxes are empty
    public void ListItems()
    {
        for (int i = 0; i < 5; i++)
        {

            if (ObjArray.Length == 0)
            {
                placeholders[i].GetComponent<Text>().text = lvlDone[i].ToString();
            }
            else
            {
                placeholders[i].name = ObjArray[i].name;
                placeholders[i].GetComponent<Text>().text = ObjArray[i].name.ToString();
            }


        }
    }
        
}

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Identifier : MonoBehaviour {


    // Items' buttons
    [SerializeField] private Button trashcan;
    [SerializeField] private Button Sink;
    [SerializeField] private Button Chair1;
    [SerializeField] private Button Chair2;
    [SerializeField] private Button Fridge;
    [SerializeField] private Button Table;
    [SerializeField] private Button Stove;
    [SerializeField] private Button Clock;
    [SerializeField] private Button Rabbit;
    [SerializeField] private Button Car;
    [SerializeField] private Button Shoes;
    [SerializeField] private Button BlueVase;
    [SerializeField] private Button Clothes;
    [SerializeField] private Button UmbrellaRed;
    [SerializeField] private Button Gloves;
    [SerializeField] private Button Keys;
    [SerializeField] private Button Cap;
    [SerializeField] private Button UmbrellaBlack;
    [SerializeField] private Button TV;
    [SerializeField] private Button Fishbowl;
    [SerializeField] private Button Astronaut;
    [SerializeField] private Button Skates;
    [SerializeField] private Button DollHouse;
    [SerializeField] private Button Couch;
    [SerializeField] private Button Plant;
    [SerializeField] private Button GalaxyRug;
    [SerializeField] private Button Backpack;
    [SerializeField] private Button Airplane;
    [SerializeField] private Button Books;
    [SerializeField] private Button PC;
    [SerializeField] private Button Cactus;
    [SerializeField] private Button Bed;
    [SerializeField] private Button TeddyBear;
    [SerializeField] private Button ToyTruck;
    [SerializeField] private Button ChairGray;
    [SerializeField] private Button ToyBlocks;

    //"Option" buttons
    [SerializeField] private Button ExitButton;
    [SerializeField] private Button ReturnButton;


    [SerializeField] private Image Parchment;
    public lvlPassedSign lvlPassedSign;
    [SerializeField] private Image tack;

    public GameObject[] placeholders;
    public Color TextColor;
    private int score;
    public int scoreMax= 35;

    public GameTextObjects reset;

    void Start()
    {
        Airplane.onClick.AddListener(airplaneClick);
        Astronaut.onClick.AddListener(AstronautClick);
        Backpack.onClick.AddListener(BackpackClick);
        Bed.onClick.AddListener(BedClick);
        BlueVase.onClick.AddListener(BlueVaseClick);
        Books.onClick.AddListener(BooksClick);

        trashcan.onClick.AddListener(trashcanClick);
        Sink.onClick.AddListener(SinkClick);
        Chair1.onClick.AddListener(ChairClick);
        Chair2.onClick.AddListener(ChairClick);
        Fridge.onClick.AddListener(FridgeClick);
        Table.onClick.AddListener(TableClick);
        Stove.onClick.AddListener(StoveClick);
        Clock.onClick.AddListener(ClockClick);
        Rabbit.onClick.AddListener(RabbitClick);
        Car.onClick.AddListener(CarClick);
        Shoes.onClick.AddListener(ShoesClick);
        Clothes.onClick.AddListener(ClothesClick);
        UmbrellaRed.onClick.AddListener(UmbrellaRedClick);
        Gloves.onClick.AddListener(GlovesClick);
        Keys.onClick.AddListener(KeysClick);
        Cap.onClick.AddListener(CapClick);
        UmbrellaBlack.onClick.AddListener(UmbrellaBlackClick);
        TV.onClick.AddListener(TVClick);
        Fishbowl.onClick.AddListener(FishbowlClick);
        Skates.onClick.AddListener(SkatesClick);
        DollHouse.onClick.AddListener(DollHouseClick);
        Couch.onClick.AddListener(CouchClick);
        Plant.onClick.AddListener(PlantClick);
        GalaxyRug.onClick.AddListener(GalaxyRugClick);
        PC.onClick.AddListener(PCClick);
        Cactus.onClick.AddListener(CactusClick);
        TeddyBear.onClick.AddListener(TeddyBearClick);
        ToyTruck.onClick.AddListener(ToyTruckClick);
        ChairGray.onClick.AddListener(ChairGrayClick);
        ToyBlocks.onClick.AddListener(ToyBlocksClick);   

        for (int i = 0; i < placeholders.Length; i++)
        {
           
                placeholders[i].GetComponent<Text>().color = Color.blue;

        }   
    }

    void Update()
    {

    //goes through the list of items, changing the items and adding 5 every time to the user's score

      if (placeholders[0].GetComponent<Text>().color == Color.green &&
            placeholders[1].GetComponent<Text>().color == Color.green &&
            placeholders[2].GetComponent<Text>().color == Color.green &&
            placeholders[3].GetComponent<Text>().color == Color.green &&
            placeholders[4].GetComponent<Text>().color == Color.green)
        {
            placeholders[0].GetComponent<Text>().color = Color.blue;
            placeholders[1].GetComponent<Text>().color = Color.blue;
            placeholders[2].GetComponent<Text>().color = Color.blue;
            placeholders[3].GetComponent<Text>().color = Color.blue;
            placeholders[4].GetComponent<Text>().color = Color.blue;
            reset.arrayReset();

            score += 5;

            gameFinished();

        }
    }


    //the list of items is done
    void gameFinished()
    {

        if (score == scoreMax)
        {

            Parchment.enabled = false;
            tack.enabled = false;
         
            lvlPassedSign.appear();
        }

    }

    //Methods for item clicks
    public void airplaneClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Airplane.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void AstronautClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Astronaut.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void BackpackClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Backpack.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void BedClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Bed.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void BlueVaseClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == BlueVase.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void BooksClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Books.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void CactusClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Cactus.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void CarClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Car.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void CapClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Cap.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ChairClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Chair1.name || placeholders[i].name == Chair2.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ChairGrayClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == ChairGray.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ClockClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Clock.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ClothesClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Clothes.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void CouchClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Couch.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void DollHouseClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == DollHouse.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }


    public void FishbowlClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Fishbowl.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void FridgeClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Fridge.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void GalaxyRugClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == GalaxyRug.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void GlovesClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Gloves.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
                 
            }
        }
    }

    public void KeysClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Keys.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void PCClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == PC.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void PlantClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Plant.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void RabbitClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Rabbit.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ShoesClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Shoes.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }
    

    public void SinkClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Sink.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void SkatesClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Skates.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void StoveClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Stove.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void TableClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == Table.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void TeddyBearClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == TeddyBear.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ToyBlocksClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == ToyBlocks.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void ToyTruckClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == ToyTruck.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void trashcanClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == trashcan.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void TVClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == TV.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void UmbrellaRedClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == UmbrellaRed.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }

    public void UmbrellaBlackClick()
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            if (placeholders[i].name == UmbrellaBlack.name)
            {
                placeholders[i].GetComponent<Text>().color = Color.green;
            }
        }
    }
}
    


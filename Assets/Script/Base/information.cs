using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Data
{
    
    public static Data data;

   

    public int price;
    public Sprite shape;
    public Sprite weapon;


}



public class information : MonoBehaviour
{
    static public information instance;
    public Data[] data; 
    public Image[] monsterUI;
    public Image[] weaponUI;
    public Text[] priceText;


    public void Start()
    {
     
        instance = this;
        for(int i=0;i<data.Length;i++)
        {
            monsterUI[i].sprite = data[i].shape;
            weaponUI[i].sprite = data[i].weapon;
            priceText[i].text = data[i].price.ToString();
        }
       
    }

   
}



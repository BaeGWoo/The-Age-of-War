using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class Item
{
    public int price;
 
}
public class DataManager : MonoBehaviour
{
    public Item itemList = new Item();

    void Start()
    {
        
        itemList.price += 100;

        Save();
        Load();

    }

    public void Save()
    {
        JsonData data = JsonMapper.ToJson(itemList);

        File.WriteAllText
            (
            Application.dataPath + "/Data.json",
            data.ToString()
            );
    }

    public void Load()
    {
        string JsonString = File.ReadAllText(Application.dataPath + "/Resources/Data.json");

        JsonData item = JsonMapper.ToObject(JsonString);

      

        for(int i=0;i<item.Count;i++)
        {
            Debug.Log(itemList.price);
        }
    }

   
}

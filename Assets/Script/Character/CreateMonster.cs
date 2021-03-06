using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CreateMonster : MonoBehaviour
{

  
    public Button[] CreateButton;


    private void Start()
    {
        InvokeRepeating("EnemyInstance", 0, 3);
    }


    public void Create(string name)
    {
        switch (name)
        {
            case "Goblin":
                if (information.instance.data[0].price <= DataManager.instance.stuff.money)
                {
                    DataManager.instance.stuff.money -= information.instance.data[0].price;
                    Instantiate(
                        Resources.Load<GameObject>("Warrior Goblin"),
                        new Vector3(-28, 0, 50),
                        Quaternion.Euler(0, 90, 0)
                     );
                    StartCoroutine(Wait(3.0f, CreateButton[0]));
                }
                break;
            case "Troll":
                if (information.instance.data[1].price <= DataManager.instance.stuff.money)
                {
                    DataManager.instance.stuff.money -= information.instance.data[1].price;
                    Instantiate(
                    Resources.Load<GameObject>("Troll"),
                    new Vector3(-28, 0, 50),
                    Quaternion.Euler(0, 90, 0)
                );
                    StartCoroutine(Wait(5.0f, CreateButton[1]));
                }
                break;

            case "Lich":
                if (information.instance.data[2].price <= DataManager.instance.stuff.money)
                {
                    DataManager.instance.stuff.money -= information.instance.data[2].price;
                    Instantiate(
                Resources.Load<GameObject>("Lich"),
                new Vector3(-28, 0, 50),
                Quaternion.Euler(0, 90, 0)
                );
                    StartCoroutine(Wait(10.0f, CreateButton[2]));
                }
                break;
        }
       
       
    }


    public void EnemyInstance()
    {
        if (!GameManager.instance.state) return;

        int rand = Random.Range(0, 3);
       
        if (rand == 1)
        {
          
            Instantiate
                (
                Resources.Load<GameObject>("Enemy Warrior Goblin"),
                new Vector3(28, 0, 50),
                Quaternion.Euler(0, -90, 0)
                );
        }
    }


    //??????????????? ?????? ???????????? ??????
    IEnumerator Wait(float timer,Button button)
    {

        button.interactable = false;
        
        while(timer>1.0f)
        {
            timer -= Time.deltaTime;
            button.image.fillAmount = (1.0f / timer);
            yield return new WaitForFixedUpdate();
        }

        //??????
        button.interactable = true;
    }
}

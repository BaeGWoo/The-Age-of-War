using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CreateMonster : MonoBehaviour
{
    public Button goblinButton;


    private void Start()
    {
        InvokeRepeating("EnemyInstance", 0, 5);
    }


    public void Create()
    {
        Instantiate
            (
            Resources.Load<GameObject>("Warrior Goblin"),
            new Vector3(-28,0,50),
            Quaternion.Euler(0,90,0)
            );
        StartCoroutine(Wait(3.0f));
    }


    public void EnemyInstance()
    {
        if (GameManager.instance.state) return;

        int rand = Random.Range(0, 3);
       
        if (rand == 1||rand==2||rand==0)
        {
            Debug.Log(rand);
            Instantiate
                (
                Resources.Load<GameObject>("Enemy Warrior Goblin"),
                new Vector3(28, 0, 50),
                Quaternion.Euler(0, -90, 0)
                );
        }
    }


    //매개변수로 넣은 숫자만큼 대기
    IEnumerator Wait(float timer)
    {

        goblinButton.interactable = false;
        
        while(timer>1.0f)
        {
            timer -= Time.deltaTime;
            goblinButton.image.fillAmount = (1.0f / timer);
            yield return new WaitForFixedUpdate();
        }

        //수행
        goblinButton.interactable = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject window;


  public void GameStart()
    {
        window.SetActive(false);
        GameManager.instance.state = true;
    }
}

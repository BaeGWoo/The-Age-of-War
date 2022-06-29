using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    static public GameManager instance;
    public bool state;
    void Start()
    {
        instance = this;
    }

}

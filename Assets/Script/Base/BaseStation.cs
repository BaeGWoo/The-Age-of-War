using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BaseStation : MonoBehaviour
{
    public Text HealthText;
    public float currentHealth;
    public float MaxHealth;

    private void Start()
    {
        MaxHealth = currentHealth;
    }

    private void Update()
    {
        HealthText.text = (currentHealth / MaxHealth*100).ToString();
        
        if (currentHealth<=0)
        {
            GameManager.instance.state = false;  
        }
    }
}

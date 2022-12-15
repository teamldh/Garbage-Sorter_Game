using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [Header("Health")]
    private int maxHealth = 100;
    Image healthBar;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        if(health >= maxHealth){
            health = maxHealth;
        }
        Debug.Log(health);
    }
}

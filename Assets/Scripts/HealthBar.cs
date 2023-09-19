using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerStats playerStats;
    public Image fill;
    public Slider slider;

    void Update()
    {
        float fillHealth = (playerStats.playerHealth / playerStats.maxHealth);
        slider.value = fillHealth;
    }
}

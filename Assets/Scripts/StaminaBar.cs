using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Image fill;
    public Slider slider;
    public float action = 1f;
    private bool sprint => Input.GetKeyDown(KeyCode.LeftShift);
    
    public float playerStamina;
    public float maxStamina = 10f;

    void Start()
    {
        playerStamina = 10f;
        slider.value = maxStamina;
    }
    
    void Update()
    {
        decreaseStamina();
    }

    public void decreaseStamina()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerStamina -= action;
            slider.value = playerStamina;
        }

        StartCoroutine(increaseStamina());
    }

    public IEnumerator increaseStamina()
    {
        yield return new WaitForSeconds(2f);
        while (playerStamina < maxStamina || !sprint)
        {
            playerStamina += action;
            slider.value = playerStamina;
            yield return new WaitForSeconds(0.1f);
        }
    }
}

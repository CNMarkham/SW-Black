using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public int curHealth;
    public Image fill;
    public bool canChange;
    public void Update()
    {
        slider.value = curHealth;

    }
    public void SetMaxHealth(int health)
    {
        Debug.Log("setting max health");
        //slider's max value is the health because it can't get any higher than that
        slider.maxValue = health;
        //value of the slider is the health.
        slider.value = health;
        curHealth = health;
        //the fill colour is the gradient that i have created.
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        Debug.Log("setting health");
        //again, the slider's value is the health.
        slider.value = health;

        //like before, the fill's colour is equal to the gradient i have created and set it to. setting the og colour to the colour selected.
        fill.color = gradient.Evaluate(slider.normalizedValue);
        curHealth = health;
        //if the slider's value is less than or equal to 0...
        if (slider.value <= 0)
        {
            //load scene 0 (menu) so you have to restart the game.
            SceneManager.LoadScene(0);
        }
    }

    public void ShowChange()
    {
        Debug.Log(slider.value);

    }
}

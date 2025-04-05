using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;

    public float totalLapTime;
    public float totalCountdownTime;

    // Update is called once per frame
    void Update()
    {
        //making lapTime.text the totalLapTime's value
        lapTime.text = Mathf.Round(totalLapTime).ToString();
        //startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        //Stop reading this
        //make totalLapTime minus Time.deltaTime's value
        totalLapTime -= Time.deltaTime;

        //if the total lap time is below or equal to 0...
        if (totalLapTime < 0)
        {
            //send this lovely message to the console.
            Debug.Log("lololololololololololololololololololololololololololololololololololololololololololololololololololololololololololololoHaHaYouSucklololololololololololololololololololololololol.");
            //load scene 0/menu so the player has to restart the game haha... hahaha...?
            SceneManager.LoadScene(0);
        }
    }
}

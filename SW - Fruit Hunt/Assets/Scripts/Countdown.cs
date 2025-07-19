using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public GameObject robParent;
    public GameObject Rob;
    public bool helgaTalked;
    public bool cnmTalked;
    public bool kidTalked;
    public bool robDIED;
    public bool appleCollected;
    public bool cherryCollected;
    public bool grapeCollected;
    public bool strawberryCollected;
    public bool kiwiCollected;
    public bool lemonCollected;
    public bool bananaCollected;
    public bool watermelonCollected;
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
        if (totalLapTime <= 0)
        {
            //send this lovely message to the console.
            Debug.Log("Uh oh! Time is up. Looks like you need to restart.");
            //load scene 7/lose scene because u failed.
            SceneManager.LoadScene(7);
        }

        if (Rob.activeInHierarchy)
        {
            Destroy(lapTime);
        }

    }

    public void SpawnRob()
    {
        if(helgaTalked && kidTalked && cnmTalked)
        {
            robParent.SetActive(true);
        }
    }
}

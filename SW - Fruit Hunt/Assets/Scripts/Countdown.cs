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

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("PabloEscobar", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //making lapTime.text the totalLapTime's value
        lapTime.text = Mathf.Round(totalLapTime).ToString();
        //startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        //Stop reading this
        totalLapTime -= Time.deltaTime;

        if (totalLapTime < 0)
        {
            Debug.Log("lololololololololololololololololololololololololololololololololololololololololololololololololololololololololololololoHaHaYouSucklololololololololololololololololololololololol.");
            SceneManager.LoadScene(0);
        }
    }
}

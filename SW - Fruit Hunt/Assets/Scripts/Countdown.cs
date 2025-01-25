using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

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

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        //startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
        }

        if (totalCountdownTime <= 0)
        {
            //startCountdown.text = string.Empty;
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
        }

        if (totalLapTime < 0)
        {
            Debug.Log("TIME UP LOSER.");
            SceneManager.LoadScene(0);
        }
    }
}

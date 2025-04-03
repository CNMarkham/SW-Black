using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guideScene: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //once clicked...
    public void OnMouseDown()
    {
        //load scene 4/the guide scene
        SceneManager.LoadScene(4);
    }
}

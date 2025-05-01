using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateScene: MonoBehaviour
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
        //load scene 5/the update log scene
        SceneManager.LoadScene(5);
    }
}

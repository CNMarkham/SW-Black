using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guideScene: MonoBehaviour
{
    
    //once clicked...
    public void OnMouseDown()
    {
        //load scene 4/the guide scene
        SceneManager.LoadScene(4);
    }
}

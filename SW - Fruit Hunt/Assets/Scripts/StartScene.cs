using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        //load scene 1/the game. it's the main plot point of this project.
        SceneManager.LoadScene(1);
    }
}

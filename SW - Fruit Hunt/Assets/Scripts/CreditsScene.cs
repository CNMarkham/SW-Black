using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        //load scene 0/menu when someone presses the "back" button.
        SceneManager.LoadScene(8);
    }
}

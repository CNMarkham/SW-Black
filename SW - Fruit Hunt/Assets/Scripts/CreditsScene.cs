using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        //load scene 8/credits scene
        SceneManager.LoadScene(8);
    }
}

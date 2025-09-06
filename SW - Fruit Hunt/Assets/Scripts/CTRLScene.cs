using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTRLScene : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        //load scene 2/controls scene.
        SceneManager.LoadScene(2);
    }
}

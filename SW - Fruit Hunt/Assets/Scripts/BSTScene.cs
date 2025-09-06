using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BSTScene: MonoBehaviour
{
    
    public void OnMouseDown()
    {
        //load scene 3/backstory scene once the button is pressed.
        SceneManager.LoadScene(3);
    }
}

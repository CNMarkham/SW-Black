using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void OnMouseDown(int scene)
    {
        //load scene 5/the update log scene
        SceneManager.LoadScene(scene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrollTXT : MonoBehaviour
{
    public string scrollTxt;
    public Text TextScroll;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void BST()
    {
        TextScroll.text = scrollTxt;
    }
}

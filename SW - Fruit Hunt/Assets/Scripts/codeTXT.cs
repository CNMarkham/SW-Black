using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class codeTXT : MonoBehaviour
{
    public string codeTxt;
    public Text TextCode;

    public GameObject code;

    public void CH()
    {
        TextCode.text = codeTxt;
    }
}

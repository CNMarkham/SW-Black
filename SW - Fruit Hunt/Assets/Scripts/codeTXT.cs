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
        //make the gameObject "TextCode"'s text equal to what codeTXT is set to.
        TextCode.text = codeTxt;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class codeTXT : MonoBehaviour
{
    public string codeTxt;
    public string fruit;
    public Text TextCode;
    public TextMeshProUGUI bombCode;
    public GameObject code;

    public void codeButton()
    {
        //make the gameObject "TextCode"'s text equal to what codeTXT is set to.
        TextCode.text = fruit + " - " + codeTxt;
        bombCode.text = codeTxt;
    }
}

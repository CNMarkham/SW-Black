using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codesBttn : MonoBehaviour
{
    public GameObject uGot;
    public GameObject Codes;

    // Update is called once per frame
    void Update()
    {
        //if uGot and Codes are both SetActive in the hierarchy
        if(uGot.activeInHierarchy && Codes.activeInHierarchy)
        {
            //the Codes gameObject SetActive false
            Codes.SetActive(false);
        }
    }
}

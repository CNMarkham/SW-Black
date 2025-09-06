using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class erusClose : MonoBehaviour
{
    public GameObject eRUs;

    public void OnMouseDown()
    {
        //the eRUs gameObject will disappear.
        eRUs.gameObject.SetActive(false);
    }
}

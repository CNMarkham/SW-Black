using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RobDoesBigDamage : MonoBehaviour
{
    public int heheSyndrome;

    // Start is called before the first frame update
    void Start()
    {
        heheSyndrome = 100;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rob")
        {
            //HealthBar.value -= 10;
            
            //once colliding with Rob, you get this message in the console...
            Debug.Log("You just lost health.");            
            
           //if your health/"heheSyndrome" is below or equal to 0...
           if(heheSyndrome <= 0)
           {
               //get this message in your console
               Debug.Log("You just died.");
               //and reload to scene 0/menu making the player restart the game.
               SceneManager.LoadScene(0);
           }
        }
    }
}


















































































































































































































































































































































































//IneScaPablE................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................ The Truth Lies Beneath You.





















































































































































































































































































































































//EvenTuaLLy yoUr Fate WiLl fInd yOu.



















































































































































































































































































































































































































































































































































//AnD yoU wOn'T bE abLE tO FinD yOUr waY oUt.
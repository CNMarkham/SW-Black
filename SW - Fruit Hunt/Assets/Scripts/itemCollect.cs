using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if the tag is either fruit, scroll or airtag
        if(collision.gameObject.tag == "Fruit" || collision.gameObject.tag == "Scroll" || collision.gameObject.tag == "AirTag" || collision.gameObject.tag == "Extra")
        {
            //gameObject SetActive false (which means it's not visible) and make the scroll text appear with the code
            collision.gameObject.SetActive(false);
            //calling the BST void from the ScrollTXT script
            collision.gameObject.GetComponent<ScrollTXT>().BST();
            //calling the CH void from the codeTXT script
            collision.gameObject.GetComponent<codeTXT>().CH();
        }
    }
}









































































































































































































































































































































































































































































































































































































































































// Y/N: Love you guys, bye!
// E/N: Bye!
// B: I know you voted for me, you fat, fat, fatty!
// Y/N: I don't even recognize you?!
// B: It's me...
// Y/N: ...
// B: From round one...?
// Y/N: Round one?! Girl we're almost at the finales!
// B: ...
// Y/N: You really stayed this long?
// B: Yeah...
// Y/N: ...
// B: Longer than your dad ever did!
// Y/N: Oh my god.
// B: Still, why would you vote for me?!
// Y/N: Girl what are you on about?
// B: I was the one who played Stacey!
// Y/N: No wonder you got voted out in round one...
// B: Excuse me?!
// Y/N: Nothing, but piece of advice: If you have the choice, don't pick Stacey.
// B: I'm inclusive, unlike you. No way!
// Y/N: Fine. It won't be my fault if you get voted out though!
// B: Oh, it will be.
// N: Next round...
// B: Why am I out first again?! Ugh.
// N: 25 minutes later...
// Y/N: I love you all guys! Bye!
// E: Bye! We'll miss you, Y/N!
// B: So, you made me lose. How pityful!
// Y/N: Maybe if you didn't pick Stacey, you'd win.
// B: I'm including her!
// Y/N: How generous. You know, you're actually pretty decent.
// B: Is that supposed to be an insult?
// Y/N: If it was, it would be more rude.
// V: I'll see you guys next round! Bye!
// E: Goodbye!
// *Y/N and B beefing*
// V: Hey, what is going on?
// Y/N: B's complaining that I'm the reason why she got voted out!
// B: And Y/N's saying it's actually my fault!
// Y/N: She wanted to pick Stacey!
// B: I was being inclusive!
// V: I see. I'm just saying, I don't think Stacey's the best choice to pick.
// B: What do you mean?
// Y/N: People hate her because she's fattest!
// B: She's only a little bit chunkier!
// V: If that's a bit, I'm only a little bit skinnier. *Shows skinniest character.*
// *Meanwhile...*
// M: Guys, read the chat.
// G: Are they beefing? Over Stacey?
// H: Stacey's lowkey ugly and fat.
// A: I'm so glad we voted B out!

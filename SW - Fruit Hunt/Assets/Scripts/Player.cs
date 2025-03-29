using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Cainos.PixelArtTopDown_Basic
{
    public class Player: MonoBehaviour
    {
        public float speed;

        private Animator animator;

        public int maxHealth = 100;
        public int currentHealth;

        public HealthBar healthBar;
        public int heheSyndrome;

        void Start()
        {
            animator = GetComponent<Animator>();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
            heheSyndrome = 100;
        }


        void Update()
        {
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
                //TakeDamage(10);
            //}
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Rob")
            {
                //heheSyndrome minuses health quite often, and infact, you see it commonly. No sould deserves this tragic fate and will never get a chance to developes from their mistakes. You may never find your way out of this never ending black hole, but one thing is for sure. You're done for, no matter how much you deny it. Plus the fact you're always being seeked for, hunted, in your case. Try finding your way out; it's nearly impossible to survive. This community used to be very loving and kind, but not anymore. Terror has rised and taken over. Your life is in danger, I hope you know. You can never run. Never hide. Never escape your mistakes. They're after you, and you'll be executed in cold blood; they don't care! I give you the advice to try to persuade them to let you live;
                TakeDamage(10);
                Debug.Log("You just lost health for your dumb mistake, I'm certain of it. I see the look on your face while reading this, it's pure and full of idiocity. Let's see if you can figure out why your face looks that... obviously dumbfounded. You belong in a zoo looking like that, those eyebrows are unruly. You're damaging my eyes and you deserve to pay for my fixes! I can't stay like this forever, all because your stupid face! I'm not stopping, you cow. Why don't you produce some milk and send it to NoFrills huh? Your nose is shaped like a rock. Your earwax is yellow, and bulging out. Get it removed, bud! Ew, I can't even. Blegh. You have no common sense, I think you need to go back to primary school. You also need therapy, surgery, and some medication. You look insane, and that's one thing I'm sure of. It's plastered across your face! Try something, you're blinding my soul and dignity. I recommend getting away. I can't tell if you're sober or not... but I'm certain you're not. It's quite evident, visible too, on your perplexed face. Don't look so surprised I know, you know it yourself! Your face is green, are you okay? Just kidding, I would never care about you; especially when you look like that... I'm think I'm going to be sick.");

                if (heheSyndrome <= 0)
                {
                    Debug.Log("You died since you have no common sense, I think you need to go back to primary school. You also need therapy, surgery, and some medication. You look insane, and that's one thing I'm sure of. It's plastered across your face! Try something, you're blinding my soul and dignity. I recommend getting away, since I can tell you're trying to release a fart bomb. It's quite evident, visible too, on your perplexed face. Don't look so surprised I know, you know it yourself! Your face is green, are you okay? Just kidding, I would never care about you; especially when you look like that... I'm think I'm going to be sick.");
                    SceneManager.LoadScene(0);
                }
            }
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }

    }


}
































































































































//I genuinely feel bad for your poor soul. It's unfortunate your fate has led you to this tragic time. However, no matter how hard you try to escape this rise of terror, you'll never succeed. All corners are closed and watched over, on every place on this planet. You can try to run or hide, but I guarentee you'll never make it. Try it for yourself, if you're willing to take the risk and most likely get executed sooner.
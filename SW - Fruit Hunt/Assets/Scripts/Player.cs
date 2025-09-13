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

        public Transform pineApple;
        public Vector2 oneDirection;

        public bool isAttacking;

            //bweetres

        void Start()
        {
            //animator is equal to the component Animator
            animator = GetComponent<Animator>();
            //the currentHealth at the beginning of the game is the maxHealth/100
            currentHealth = maxHealth;
            //We set the value of the healthBar to project maxHealth/100
            if(healthBar !=null)
            healthBar.SetMaxHealth(maxHealth);
            //heheSyndrome/Player's health is 100
            heheSyndrome = 100;
        }


        void Update()
        {
            //Vector2's direction is set to 0
            Vector2 dir = Vector2.zero;

            //if the key A or left arrow is pressed...
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                //the x direction is equal to -1
                dir.x = -1;
                //the animator plays the left facing animation.
                animator.SetInteger("Direction", 3);
            } //or else if it's key D or right arrow...
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                //the x direcion is equal to 1
                dir.x = 1;
                //the animator plays the facing right animation.
                animator.SetInteger("Direction", 2);
            }

            //if the key W or up arrow is pressed...
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                //the y direction is equal to 1
                dir.y = 1;
                //the animator plays the facing straight animation.
                animator.SetInteger("Direction", 1);
            } //or else if it's key S or down arrow...
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                //the y direction is equal to -1
                dir.y = -1;
                //the animator plays the facing towards us animation.
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();

            //if dir doesn't equal to Vector2.zero...
            if(dir != Vector2.zero)
            {
                //oneDirection/previous position besides zero is equal to dir
                oneDirection = dir;
            }

            //if the space bar key is pressed...
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //and if isAttacking is false...
                if (isAttacking == false)
                {
                    //we start the corouting Attack
                    StartCoroutine(Attack());
                }
            }

            //the animator sets a bool "isMoving" to check if it's moving, then makes the dir.magnitude greater than zero.
            animator.SetBool("IsMoving", dir.magnitude > 0);

            //getting the component Rigidbody2D.velocity is equal to the speed multiplied by dir
            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }

        //coroutinE!
        IEnumerator Attack()
        {
            //we set isAttacking to true in the beginning of this coroutine
            isAttacking = true;
            pineApple.GetComponent<CapsuleCollider2D>().enabled = true;
            //defining starting position used for lerping later.
            Vector3 startingPosition = pineApple.localPosition;
            //defining that the finalPosition is pineApple's localPosition and the new Vector3 of the past directions.
            Vector3 finalPosition = pineApple.localPosition + new Vector3(oneDirection.x, oneDirection.y) * 2;
            //move from beginning to end
            for(float t = 0; t < 1; t += Time.deltaTime * 2.8f)
            {
                //the localPosition is set to lerp from the startingPosition to finalPosition.
                pineApple.localPosition = Vector3.Lerp(startingPosition, finalPosition, t);
                yield return null;
            }
            //moves back.
            for(float t = 1; t > 0; t -= Time.deltaTime * 2.8f)
            {
                //the localPosition is set to lerp from the startingPosition to finalPosition.
                pineApple.localPosition = Vector3.Lerp(startingPosition, finalPosition, t);
                yield return null;
            }
            //we set isAttacking to false at the end of the code
            isAttacking = false;
            //we get the component on pineApple of CapsuleCollider2D and disable it
            pineApple.GetComponent<CapsuleCollider2D>().enabled = false;
        }

        void Pineapple()
        {
            //the localPosition of pineApple is equal to the new Vector3 position
            pineApple.transform.localPosition = new Vector3(-0.016f, 1.21f, 0);
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            //if the player is colliding with the gameObject with the tag "Rob"...
            if (collision.gameObject.tag == "Rob")
            {
                //we take 10 damage from the player.
                TakeDamage(10);

                //if the variable "heheSyndrome" is less than or equal to zero...
                if (heheSyndrome <= 0)
                {
                    //load scene 0/the menu scene.
                    SceneManager.LoadScene(0);
                }
            }
        }

        void TakeDamage(int damage)
        {
            //the current health minuses the amount of health taking damage took
            currentHealth -= damage;
            //updates it by settubg the healthBar value to currentHealth.
            healthBar.SetHealth(currentHealth);
        }

    }


}
































































































































//I genuinely feel bad for your poor soul. It's unfortunate your fate has led you to this tragic time. However, no matter how hard you try to escape this rise of terror, you'll never succeed. All corners are closed and watched over, on every place on this planet. You can try to run or hide, but I guarentee you'll never make it. Try it for yourself, if you're willing to take the risk and most likely get executed sooner.
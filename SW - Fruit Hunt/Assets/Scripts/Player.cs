using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class Player: MonoBehaviour
    {
        public float speed;

        private Animator animator;

        public int maxHealth = 100;
        public int currentHealth;

        public HealthBar healthBar;

        void Start()
        {
            animator = GetComponent<Animator>();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }


        void Update()
        {
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(10);
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
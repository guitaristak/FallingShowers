using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public GameObject Coins;
    public GameObject Rocks;
    public GameObject GameEnded;
    Animator animator;
    SpriteRenderer sr;
    public static bool isAlive = true;
    public int speed = 5;
    void Awake()
    {
        if(isAlive == true)
        {
            Coins.SetActive(true);
            Rocks.SetActive(true);
            GameEnded.SetActive(false);
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator> ();
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(isAlive)
        {
            float move = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(speed * move, rb.velocity.y);
            if (move < 0)
            {
                sr.flipX = true;
                animator.Play("Running");
            }
            else if (move > 0)
            {
                sr.flipX = false;
                animator.Play("Running");
            }
            else
            {
                animator.Play("Idle");
            }
        }
        else
        {
            animator.Play("Dying");
            Coins.SetActive(false);
            Rocks.SetActive(false);
            GameEnded.SetActive(true);
        }
    }
}

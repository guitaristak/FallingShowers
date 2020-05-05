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

    // Update is called once per frame
    void Update()
    {
        if(isAlive)
        {
            float move = Input.GetAxisRaw("Horizontal"); //DOUBT (why not working with int move)
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
            //StartCoroutine(GameOver());
        }
        //IEnumerator GameOver()
        //{
        //    Coins.SetActive(false);
        //    Rocks.SetActive(false);
        //    GameEnded.SetActive(true);
        //    yield return new WaitForSeconds(1);
        //}
        
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rb.velocity = new Vector2(-speed, rb.velocity.y);
        //    animator.Play("Running");
        //}

        //else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    rb.velocity = new Vector2(speed, rb.velocity.y);
        //    animator.Play("Running");
        //}
    }
}

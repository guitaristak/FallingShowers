using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int numOfHearts;
    public static int health = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (health > numOfHearts)
            {
                health = numOfHearts; //If player takes potion even when his health if full
            }
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
            //if max heart = 10, but health = 4 then only 4 will be visible
            //if(i < numOfHearts)
            //{
            //    hearts[i].enabled = true; 
            //}
            //else
            //{
            //    hearts[i].enabled = false;
            //}
        }
    }
}

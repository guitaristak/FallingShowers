using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayAudio : MonoBehaviour
{
    static AudioSource audSrc;
    public static AudioClip coinCollect, rockHit, gameOver;
    void Start()
    {
        coinCollect = Resources.Load<AudioClip>("coin pickup");
        rockHit = Resources.Load<AudioClip>("rock hit");
        gameOver = Resources.Load<AudioClip>("game over");
        audSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void playSound(string audio)
    {
        switch(audio)
        {
            case "coinCollect":
                audSrc.PlayOneShot(coinCollect);
                break;
            case "rockHit":
                audSrc.PlayOneShot(rockHit);
                break;
            case "gameOver":
                audSrc.PlayOneShot(gameOver);
                break;
        }
    }
}

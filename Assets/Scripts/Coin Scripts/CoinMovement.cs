using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public CoinGenerator CoinGenerator;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 5 * Time.deltaTime, transform.position.z);
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            CameraCoinRespawn();
        }
    }
    public void CameraCoinRespawn()
    {
        var nextPos = CoinGenerator.GetNextCPosition();
        transform.position = new Vector3(nextPos.x, nextPos.y, transform.position.z);
    }
    public void CoinRespawn()
    {
        var nextPos = CoinGenerator.GetNextPPosition();
        transform.position = new Vector3(nextPos.x, nextPos.y, transform.position.z);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            GamePlayAudio.playSound("coinCollect");
            ScoreManager.score += 1;
            CoinRespawn();
        }
    }
}

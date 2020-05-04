using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    public static int health = 3;
    public RockGenerator RockGenerator;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 7 * Time.deltaTime, transform.position.z);
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            RockRespawn();
        }
    }
    public void RockRespawn()
    {
        var nextPos = RockGenerator.GetNextPosition();
        transform.position = new Vector3(nextPos.x, nextPos.y, transform.position.z);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            health -= 1;
            RockRespawn();
        }
    }
}

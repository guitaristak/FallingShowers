using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        //if (transform.position.y < Camera.main.transform.position.y)
        //{
        //    Destroy(gameObject);
        //    //var nextPos = PipeGenerator.GetNextPosition();
        //    //transform.position = new Vector3(nextPos.x, nextPos.y, transform.position.z);
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public int CoinsToSpawn = 10;
    public int CoinDistance = 2;
    public GameObject Coin;
    public float minX = -8.45f;
    public float maxX = 8.35f;
    void Start()
    {
        //for (int i = 0; i < CoinsToSpawn; i++)
        //{
        //    GameObject c = Instantiate(Coin) as GameObject;
        //    Transform coinTransform = c.transform;
        //    coinTransform.transform.position = new Vector3(Random.Range(minX, maxX), c.transform.position.y + (i + 1) * CoinDistance, c.transform.position.z);
        //}
    }
    void spawnCoins()
    {
        
    }
    void Update()
    {
    //    if(transform.position.x < cameraTransform.position.x)
    //    {
    //        Destroy(gameObject);
    //    }
    }
}

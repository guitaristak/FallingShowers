using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public int CoinsToSpawn = 10;
    public GameObject Coin;
    public Transform Coins;
    public int CoinDistance = 10;
    public float minX = -8.45f;
    public float maxX = 8.35f;
    void Start()
    {
        for (int i = 0; i < CoinsToSpawn; i++)
        {
            GameObject c = Instantiate(Coin) as GameObject;
            c.transform.position = new Vector3(Random.Range(minX, maxX), c.transform.position.y + ((i + 1)*CoinDistance), c.transform.position.z);
            c.transform.parent = Coins;
            c.GetComponent<CoinMovement>().CoinGenerator = this;
        }
    }
    public Vector2 GetNextPosition()
    {
        return new Vector2(Random.Range(minX, maxX), 65);
    }
}

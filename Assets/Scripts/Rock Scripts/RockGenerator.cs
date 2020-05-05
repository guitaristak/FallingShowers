using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public int RocksToSpawn = 10;
    public GameObject Rock;
    public Transform Rocks;
    public float minX = -8.45f;
    public float maxX = 8.35f;
    void Start()
    {
        for (int i = 0; i < RocksToSpawn; i++)
        {
            GameObject c = Instantiate(Rock) as GameObject;
            c.transform.position = new Vector3(Random.Range(minX, maxX), c.transform.position.y + ((i + 1)*Random.Range(5,8)), c.transform.position.z);
            c.transform.parent = Rocks;
            c.GetComponent<RockMovement>().RockGenerator = this;
        }
    }
    public Vector2 GetNextPosition()
    {
        return new Vector2(Random.Range(minX, maxX), 60);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coin;
    public BlockManager blockManager;

    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            float randRangeX = Random.Range(2, 9);
            float randRangY = Random.Range(1, 6);
            Debug.Log(i);
            Instantiate(coin, new Vector3((blockManager.blockStartPos +  (i * 10)) + randRangeX, randRangY, 0), Quaternion.identity);


            if (i == 20)
            {
               // bottomBlockSpawnOffset = i;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

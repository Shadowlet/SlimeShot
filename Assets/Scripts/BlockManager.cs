using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject[] blockList;
    public GameObject[] blocksInScene;

    private int blockStartPos;
    private int randID;
    public int topSpawnOffset;
    public int bottomSpawnOffset;

    // Start is called before the first frame update
    void Start()
    {
        blockStartPos = -15;

        // Spawn bottom blocks
        for (int i = 0; i < 20; i++)
        {
           // Debug.Log(i);
            randID = Random.Range(0, 3);
            Instantiate(blockList[randID], new Vector3(blockStartPos + i * 20, 0, 0), transform.rotation);
            

            if (i == 20)
            {
                bottomSpawnOffset = i;
            }
        }

        // Spawn top blocks
        for (int i = 0; i < 20; i++)
        {
            // Debug.Log(i);
            randID = Random.Range(0, 3);
            Instantiate(blockList[randID], new Vector3(blockStartPos + i * 30, 8, 0), transform.rotation);

            if (i == 20)
            {
                topSpawnOffset = i;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMoreBlocks(bool isTop)
    {
        if (isTop)
        {
            // Spawn bottom blocks
            for (int i = 0; i < bottomSpawnOffset + 20; i++)
            {
                randID = Random.Range(0, 3);
                Instantiate(blockList[randID], new Vector3(blockStartPos + i * 20, 0, 0), transform.rotation);

                if (i == bottomSpawnOffset + 20)
                {
                    bottomSpawnOffset = i;
                }
            }
        }
        else
        {
            // Spawn top blocks
            for (int i = 0; i < topSpawnOffset + 20; i++)
            {
                randID = Random.Range(0, 3);
                Instantiate(blockList[randID], new Vector3(blockStartPos + i * 30, 8, 0), transform.rotation);

                if (i == topSpawnOffset + 20)
                {
                    topSpawnOffset = i;
                }
            }
        }
    }
}

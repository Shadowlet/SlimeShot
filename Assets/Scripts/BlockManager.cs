using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject[] blockList;
    //public GameObject[] blocksInScene;
    public GameObject[] groundBlocks;

    
    public int groundStartPosX;
    private int randID;

    public int blockStartPos;
    public int topBlockSpawnOffset;
    public int bottomBlockSpawnOffset;
    public int topGroundOffset;
    public int bottomGroundOffset;



    // Start is called before the first frame update
    void Start()
    {

        blockStartPos = -15;
        groundStartPosX = 0;

        // Spawn bottom blocks
        for (int i = 0; i < 100; i++)
        {
           // Debug.Log(i);
            randID = Random.Range(0, 3);
            Instantiate(blockList[randID], new Vector3(blockStartPos + i * 20, 0, 0), transform.rotation);
            

            if (i == 100)
            {
                bottomBlockSpawnOffset = i;
            }
        }

        // Spawn top blocks
        for (int i = 0; i < 100; i++)
        {
            // Debug.Log(i);
            randID = Random.Range(0, 3);
            Instantiate(blockList[randID], new Vector3(blockStartPos + i * 30, 8, 0), transform.rotation);

            if (i == 100)
            {
                topBlockSpawnOffset = i;
            }
        }

        SpawnMoreGround();
    }

    public void SpawnMoreBlocks(bool isTop)
    {
        if (isTop)
        {
            // Spawn bottom blocks
            for (int i = bottomBlockSpawnOffset; i < bottomBlockSpawnOffset + 100; i++)
            {
                randID = Random.Range(0, 3);
                Instantiate(blockList[randID], new Vector3(blockStartPos + i * 20, 0, 0), transform.rotation);

                if (i == bottomBlockSpawnOffset + 20)
                {
                    bottomBlockSpawnOffset = i;
                }
            }
        }
        else
        {
            // Spawn top blocks
            for (int i = topBlockSpawnOffset; i < topBlockSpawnOffset + 100; i++)
            {
                randID = Random.Range(0, 3);
                Instantiate(blockList[randID], new Vector3(blockStartPos + i * 40, 8, 0), transform.rotation);

                if (i == topBlockSpawnOffset + 100)
                {
                    topBlockSpawnOffset = i;
                }
            }
        }
    }

    public void SpawnMoreGround()
    {
        //Spawn top blocks
        for (int i = topGroundOffset; i < topGroundOffset + 100; i++)
        {
            Instantiate(groundBlocks[0], new Vector3(groundStartPosX + i * 64, 10, 0), Quaternion.identity);

            if (i == topGroundOffset + 100)
            {
                topGroundOffset = i;
            }

        }

        //Spawn bottom blocks
        for (int i = bottomGroundOffset; i < bottomGroundOffset + 100; i++)
        {
            //64 offset
            Instantiate(groundBlocks[1], new Vector3(groundStartPosX + i * 64, -3, 0), Quaternion.identity);

            if (i == bottomGroundOffset + 100)
            {
                bottomGroundOffset = i;
            }
        }

       


    }
}

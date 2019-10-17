using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject[] blockList;
    public GameObject[] blocksInScene;

    private int randID;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Debug.Log(i);
            randID = Random.Range(0, 3);
            Instantiate(blockList[randID], new Vector3(i * 20, 0, 10), transform.rotation);
 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

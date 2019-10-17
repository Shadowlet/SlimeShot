using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public GameObject[] floor;
    public GameObject background;

    private float bgSpeed;
    private float floorSpeed;

    private int randNumber;
    private float xPos;

    private float camYPos = 2;

    void Start()
    {
        /*randNumber = 0;
        xPos = 0;
        InvokeRepeating("SpawnCubes", 1, 1);*/
    }

    private void Update()
    {
        //background.transform.Translate(new Vector3(-1, 0, 0) * bgSpeed * Time.deltaTime);

        for (int i = 0; i < floor.Length; i++)
        {
            //floor[i].transform.Translate(new Vector3(-1, 0, 0) * floorSpeed * Time.deltaTime);
            //Debug.Log(floor[i].transform.position);
        }

        // check the floor x position so we know
        // when its off the screen to the left here!
        // reset the floor position to off the screen
        // to the right side if so
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, camYPos, transform.position.z);
    }
}

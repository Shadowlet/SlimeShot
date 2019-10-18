using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowsBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public Vector3 offset;
    public Vector3 ballPos;

    // Start is called before the first frame update
    void Start()
    {
       // this.transform.position = new Vector3(ballPrefab.transform.position.x + 10, this.transform.position.y, -10);
    }
    
    // Update is called once per frame
    void Update()
    {
        ballPos = ballPrefab.transform.position;

        transform.position = new Vector3(ballPos.x + offset.x, transform.position.y, -10);
        offset.z = -10;

        //Debug.Log("Camera Location" + transform.position);
        //Debug.Log("Ball location" + ballPrefab.transform.position);
    }

    
}


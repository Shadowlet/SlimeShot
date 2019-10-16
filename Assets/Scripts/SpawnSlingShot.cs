using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlingShot : MonoBehaviour
{
    public GameObject slingshotPrefab;
    private Camera mainT;

    //private Touch touch = Input.GetTouch(0);
    private TouchPhase Touchdidbegin = TouchPhase.Began;
    private Vector2 clickPoint;
    private Vector2 clickRelease;

    private Rigidbody2D rb2D;

    float power;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        rb2D.freezeRotation = true;
        mainT = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void MoveSlingshot()
    {
        slingshotPrefab.SetActive(true);
        slingshotPrefab.transform.position = new Vector2(this.transform.position.x, this.transform.position.y);
    }

    void findTouch()
    {

    }

    private void OnMouseDown()
    {
        clickPoint = mainT.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Debug.Log("Testing");

        MoveSlingshot();
    }

    private void OnMouseUp()
    {
        clickRelease = mainT.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

        slingshotPrefab.SetActive(false);
        LaunchSlime();
    }

    private void LaunchSlime()
    {
        power = clickPoint.x - clickRelease.x;
        Debug.Log(power);

        rb2D.AddForce(transform.up * power * 100);
        rb2D.AddForce(transform.right * power * 100);
    }
}





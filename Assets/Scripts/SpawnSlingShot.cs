using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlingShot : MonoBehaviour
{
    public GameObject slingshotPrefab;
    public GameManager gameManager;

    public BlockManager blockManager;
    public GameScore gameScore;

    private Camera mainT;

    //private Touch touch = Input.GetTouch(0);
    //private TouchPhase Touchdidbegin = TouchPhase.Began;
    private Vector2 clickPoint;
    private Vector2 clickRelease;

    private int posX;
    private int posY;

    private Rigidbody2D rb2D;

    float powerX;
    float powerY;

    void Start()
    {
        slingshotPrefab.SetActive(false);

        rb2D = gameObject.GetComponent<Rigidbody2D>();
        rb2D.freezeRotation = true;
        mainT = Camera.main;
        //Debug.Log(mainT);
        

    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerPos();

        
    }

    void MoveSlingshot()
    {
        slingshotPrefab.SetActive(true);
        slingshotPrefab.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
    }

    private void OnMouseDrag()
    {
        
        //clickPoint = mainT.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        //transform.position = clickPoint;

        Debug.Log(Input.mousePosition.x + Input.mousePosition.y);
    }

    private void OnMouseDown()
    {
        rb2D.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

        MoveSlingshot();
        clickPoint = mainT.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        //Debug.Log(clickPoint);

        
    }

    private void OnMouseUp()
    {
        clickRelease = mainT.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

        slingshotPrefab.SetActive(false);
        LaunchSlime();
    }

    private void LaunchSlime()
    {
        rb2D.velocity = new Vector2(0, 0);
        rb2D.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        powerX = clickPoint.x - clickRelease.x;
        powerY = clickPoint.y - clickRelease.y;
        //Debug.Log(power);

        //rb2D.AddForce(transform.up * power * 100);
        //rb2D.AddForce(transform.right * power * 100);

        rb2D.velocity = new Vector2(powerX * 2, powerY * 2);
    }
    private void checkPlayerPos()
    {
        //Check for score
        if (this.transform.position.x >= blockManager.blockStartPos + gameScore.currentScore * 10)
        {
            gameScore.IncrementScore();
        }

        //Check for ground
        if (this.transform.position.x >= blockManager.groundStartPosX + (blockManager.topGroundOffset * 10))
        {
            blockManager.SpawnMoreGround();
        }
        //Check for bottom

        //Check for top
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Debug.Log("Hit block");
            //gameManager.EndGame();
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("HIT2D");
        }

    }


}





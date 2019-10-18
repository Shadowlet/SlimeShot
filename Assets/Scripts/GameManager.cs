using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject m_TitleScreen;
    public GameObject m_Level;
    public GameObject m_Menu;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        m_Level.SetActive(true);
        m_TitleScreen.SetActive(false);
    }

    public void EndGame()
    {
        m_Menu.SetActive(true);
    }

    public void RestartGame()
    {
        //Load level..
    }
}

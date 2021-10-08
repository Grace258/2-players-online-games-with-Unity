using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public int P1_Life;
    public int P2_Life;
    public GameObject P1_Win;
    public GameObject P2_Win;
    public GameObject[] P1_stick;
    public GameObject[] P2_stick;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P1_Life <= 0)
        {
            player1.SetActive(false);
            P2_Win.SetActive(true);
        }
        if (P2_Life <= 0)
        {
            player1.SetActive(false);
            P1_Win.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(mainMenu);
        }
    }

    public void HurtP1()
    {
        P1_Life -= 1;
        for(int i = 0; i < P1_stick.Length; i++)
        {
            if(P1_Life > i)
            {
                P1_stick[i].SetActive(true);
            }
            else
            {
                P1_stick[i].SetActive(false);
            }
        }
    }

    public void HurtP2()
    {
        P2_Life -= 1;
        for (int i = 0; i < P2_stick.Length; i++)
        {
            if (P2_Life > i)
            {
                P2_stick[i].SetActive(true);
            }
            else
            {
                P2_stick[i].SetActive(false);
            }
        }
    }
}

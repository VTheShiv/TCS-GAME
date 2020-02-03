using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public bool defeat, won;
    public static UIController Instance;
    public GameObject gameOver, gameWon;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (defeat)
        {
            gameOver.SetActive(true);
            won = false;
        }

        if (won)
        {
            gameWon.SetActive(true);
            defeat = false;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

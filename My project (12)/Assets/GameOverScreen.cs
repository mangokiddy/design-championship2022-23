using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public static bool GameIsOver;
    public GameObject DeathScreen;


    void Start()
    {
        DeathScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("player").GetComponent<MovementPlayer>().GameEnded == true)
        {
            GameOver();
            Destroy(GameObject.Find("player"), 0.06f);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        DeathScreen.SetActive(false);
        Time.timeScale = 1f;
        GameIsOver = false;
    }

    void GameOver()
    {
        DeathScreen.SetActive(true);
        Time.timeScale = 0f;
        GameIsOver = true;
    }

    public void QuitTheGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

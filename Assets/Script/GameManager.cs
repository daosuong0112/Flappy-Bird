using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOver;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        GOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}

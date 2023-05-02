using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

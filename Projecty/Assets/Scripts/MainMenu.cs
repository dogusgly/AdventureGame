using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void ShopMenu()
    {
        SceneManager.LoadScene(2);
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

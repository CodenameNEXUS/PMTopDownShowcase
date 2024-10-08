using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    string levelsToLoad = "Level1";
    [SerializeField]
    bool menu = false;
    [SerializeField]
    string MainMenu = "Start";
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = menu;
    }

    // Update is called once per frame
    void Update()
    {
        //If the escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            //display the pause menu
            GetComponent<Canvas>().enabled = true;
            //pause the game
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            Resumegame();
        }
    }
    public void Resumegame()
    {
        //hide the pause canvas again
        GetComponent<Canvas>().enabled = false;
        //reset the time scale to 1
        Time.timeScale = 1;
    }

    public void RelaodLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Play()
    {
        SceneManager.LoadScene(levelsToLoad);
        Time.timeScale = 1;
    }
    public void StartMenu()
    {
        SceneManager.LoadScene(MainMenu);
        Time.timeScale = 1;
    }
}

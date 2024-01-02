using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private string LevelName;
    [SerializeField]
    private GameObject PanelMainMenu;
    [SerializeField]
    private GameObject PanelOptions;
    [SerializeField]
    private GameObject PauseGame;
    private static Menu _Instance;
    public static Menu Instance;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GamePause();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(LevelName);
        Time.timeScale = 1;
    }

    public void OpenOptions()
    {
        PanelMainMenu.SetActive(false);
        PanelOptions.SetActive(true);
    }

    public void CloseOptions()
    {
        PanelMainMenu.SetActive(true);
        PanelOptions.SetActive(false);
    }

    public void GamePause()
    {
            PauseGame.SetActive(true);
            Time.timeScale = 0;
    }

    public void ResumeGame()
    { 
            PauseGame.SetActive(false);
            Time.timeScale = 1;
    }

    public void Quit()
    {
        Debug.Log("Game Closed!");
        Application.Quit();
    }
}

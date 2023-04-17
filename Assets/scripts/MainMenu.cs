using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    { }
    public void StartGame()
    {
        Debug.Log("game is started");
        SceneManager.LoadScene("scene1");
    }

    public void LoadSettings()
    {
        Debug.Log("settings");
        SceneManager.LoadScene("settings");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string sceneName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            LoadLevel1();
        }
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("1 PRESSED");
    }
    public void startGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Quitting.");
    }

}

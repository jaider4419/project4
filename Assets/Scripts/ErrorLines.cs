using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ErrorLines : MonoBehaviour
{
    private int sceneBuildIndex;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SceneManager.LoadScene(sceneBuildIndex + 1);
        }
    }
}

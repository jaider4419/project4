using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongWay : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            SceneManager.LoadScene("WrongWay");
        }
    }

}

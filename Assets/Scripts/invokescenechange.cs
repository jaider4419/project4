using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class invokescenechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BacktoLevel3", 3f);
    }

    void BacktoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}

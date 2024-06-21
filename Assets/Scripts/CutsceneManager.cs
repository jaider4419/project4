using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    public GameObject[] cutsceneImages; 
    public string sceneToLoad; 

    private int currentImageIndex = 0;

    void Start()
    {
        
        for (int i = 0; i < cutsceneImages.Length; i++)
        {
            cutsceneImages[i].SetActive(i == 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ShowNextImage();
        }
    }

    void ShowNextImage()
    {
        
        cutsceneImages[currentImageIndex].SetActive(false);

        currentImageIndex++;

        if (currentImageIndex < cutsceneImages.Length)
        {
            
            cutsceneImages[currentImageIndex].SetActive(true);
        }
        else
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

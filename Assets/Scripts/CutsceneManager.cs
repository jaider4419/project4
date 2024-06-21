using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    public GameObject[] cutsceneImages; // Array of GameObjects for the cutscene images
    public string sceneToLoad; // Name of the scene to load after the cutscene
    public float delayBeforeLoading = 0.5f; // Delay before loading the next scene

    private int currentImageIndex = 0;

    void Start()
    {
        // Ensure all images are initially disabled except the first one
        for (int i = 0; i < cutsceneImages.Length; i++)
        {
            cutsceneImages[i].SetActive(i == 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            ShowNextImage();
        }
    }

    void ShowNextImage()
    {
        // Disable the current image
        cutsceneImages[currentImageIndex].SetActive(false);

        currentImageIndex++;

        if (currentImageIndex < cutsceneImages.Length)
        {
            // Enable the next image
            cutsceneImages[currentImageIndex].SetActive(true);
        }
        else
        {
            // Start coroutine to load next scene with a delay
            StartCoroutine(LoadNextSceneAfterDelay());
        }
    }

    System.Collections.IEnumerator LoadNextSceneAfterDelay()
    {
        // Wait for the specified delay before loading the next scene
        yield return new WaitForSeconds(delayBeforeLoading);

        // Load the next scene
        SceneManager.LoadScene(sceneToLoad);
    }
}

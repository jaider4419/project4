using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveHorizontal, moveVertical).normalized;
    }

    void FixedUpdate()
    {

        rb.velocity = moveInput * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Walls")
            {
                string currentSceneName = SceneManager.GetActiveScene().name;

                SceneManager.LoadScene(currentSceneName);

                Debug.Log("Wall hit, reloading scene: " + currentSceneName);
            }
        }

        if (collision.gameObject.tag == "Finish")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
            Debug.Log("Next scene");
        }

        if (collision.gameObject.tag == "Oops")
        {
            SceneManager.LoadScene("WrongWay");
        }

    }

}

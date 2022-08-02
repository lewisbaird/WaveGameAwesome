using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float speed = 20.0f; //speed that the obstacles move towards the player
    private float leftBoundry = -30; //distance at which obstacles get deleted.
    public TextMeshProUGUI DeathText; //Text that displays when you have died
    public GameObject RestartButton; //button to restart the game
    public GameObject WaveDown;
    public GameObject WaveUp;
    private PlayerMovements MovementScript;
    private PlayerTwoMovements MovementScript2;

    void Start()
    {
        MovementScript = WaveDown.GetComponent<PlayerMovements>();
        MovementScript2 = WaveUp.GetComponent<PlayerTwoMovements>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.z < leftBoundry)
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("EvilTriangle"))
        {
            DeathText.gameObject.SetActive(true);
            RestartButton.gameObject.SetActive(true);
            Destroy(gameObject);
            MovementScript.DisableScript();
            MovementScript2.DisableScript();


        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

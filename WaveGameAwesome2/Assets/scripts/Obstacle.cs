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
    //private PlayerMovement MovementScript;
    //private PlayerTwoMovement MovementScript2;

    void Start()
    {
        //MovementScript = WaveDown.GetComponent<PlayerMovement>();
        //MovementScript2 = WaveUp.GetComponent<PlayerTwoMovement>();
    }

    void OnTriggerEnter(Collider other)
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
            //MovementScript.DisableScript();
            //MovementScript2.DisableScript();
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float speed = 20.0f; //speed that the obstacles move towards the player
    private float leftBoundry = -40; //distance at which obstacles get deleted.
    //public TextMeshProUGUI DeathText; //Text that displays when you have died
    //public GameObject restartButton; //button to restart the game
    //private playerDead = false;

    //public GameObject WaveDown;
    //public GameObject WaveUp;
   
    //private PlayerMovement movementScript;
    //private PlayerTwoMovement movementScript2;

    void Start()
    {
        //movementScript = WaveDown.GetComponent<PlayerMovement>();
        //movementScript2 = WaveUp.GetComponent<PlayerTwoMovement>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.x < leftBoundry)
        {
            Destroy(gameObject);
        }

        //if (playerDead = true)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //playerDead = true;
            //DeathText.gameObject.SetActive(true);
            //restartButton.gameObject.SetActive(true);
            //Destroy(gameObject);
            //movementScript.DisableScript();
            //movementScript2.DisableScript();
       }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

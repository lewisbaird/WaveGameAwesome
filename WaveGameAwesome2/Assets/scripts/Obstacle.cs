using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float speed = 20.0f; //speed that the obstacles move towards the player
    private float leftBoundry = -40; //distance at which obstacles get deleted.
    private bool playerDead = false;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.x < leftBoundry)
        {
            Destroy(gameObject);
        }

        if (playerDead == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
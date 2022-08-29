using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    public float speed = 20.0f; //speed that the obstacles move towards the player
    private float leftBoundry = -40; //distance at which obstacles get deleted.

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x < leftBoundry)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

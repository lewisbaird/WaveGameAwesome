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
        if (transform.position.x < leftBoundry) //activates if obstacles goes past or onto the set number
        {
            Destroy(gameObject); //destroying the obstalces if they go too far off the screen
        }
    }

    void OnTriggerEnter(Collider other) //if collision happens
    {

        if (other.CompareTag("Player")) //if the collision is with an object that has the tag player on it
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restart the game/scene from the start removing all points and everything
        }
    }

}

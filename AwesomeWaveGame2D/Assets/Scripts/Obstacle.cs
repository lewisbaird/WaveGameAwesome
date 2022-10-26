using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float speed = 20.0f; //speed that the obstacles move towards the player
    private float leftBoundry = -40; //distance at which obstacles get deleted.

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed); //moves the obstacles to the left towards the player

        if (transform.position.x < leftBoundry) //activates if obstacles goes past or onto the set number
        {
            Destroy(gameObject); //destroying the obstalces if they go too far off the screen
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    public float speed = 20.0f; //speed that the items move towards the player
    private float leftBoundry = -40; //distance at which items get deleted.
    private GameManager gameManager; //game manager

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //detecting game manager
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed); //moves the items to the left towards the player

        if (transform.position.x < leftBoundry)
        {
            Destroy(gameObject); //destroying the items if they go too far off the screen
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.UpdateScore(1); //adding to score when collecting a item

        }
    }
}

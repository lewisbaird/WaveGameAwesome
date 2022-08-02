using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{
    public float speed = 20.0f; //speed that the obstacles move towards the player
    private float leftBoundry = -30; //distance at which obstacles get deleted.

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.z < leftBoundry)
        {
            Destroy(gameObject);
        }
    }
}

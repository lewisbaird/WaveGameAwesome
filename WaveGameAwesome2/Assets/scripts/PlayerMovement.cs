using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20.0f; //speed that the player moves down at
    public float yRangeGoingUp = 16; //The height at which player one is teleported back down
    public float yRangeGoingDown = 4; //The height at which player one is teleported back up
    public bool gameOver = false;

    void Start()
    {

    }

    void Update()
    {
        //keeping the player in bounds (teleportation)
        if (transform.position.y < yRangeGoingDown)
        {
            transform.position = new Vector3(transform.position.x, yRangeGoingUp, transform.position.z);
        }
        if (transform.position.y > yRangeGoingUp)
        {
            transform.position = new Vector3(transform.position.x, yRangeGoingDown, transform.position.z);
        }

        //movement controls/making other player disappear
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            GameObject.Find("WaveDown").transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            GameObject.Find("WaveDown").transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
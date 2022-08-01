using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public float speed = 20.0f; //speed that player one moves up and down at
    public float yRangeGoingUp = 20; //The height at which player one is teleported back down
    public float yRangeGoingDown = -1; //The height at which player one is teleported back up

    void Start()
    {

    }

    void Update()
    {
        //keeping the player in bounds
        if (transform.position.y < yRangeGoingDown)
        {
            transform.position = new Vector3(transform.position.x, yRangeGoingUp, transform.position.z);
        }
        if (transform.position.y > yRangeGoingUp)
        {
            transform.position = new Vector3(transform.position.x, yRangeGoingDown, transform.position.z);
        }

        //movement controls
        if(Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            GameObject.Find("Betterwave2").transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            GameObject.Find("Betterwave2").transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletion : MonoBehaviour
{
    public GameObject levelEasy; //Attaching easy level button to script
    public GameObject levelNormal; //Attaching normal level button to script
    public GameObject levelHard; //Attaching hard level button to script
    public GameObject levelImpossible; //Attaching impossible button level to script
    public GameObject background; //Attaching background to script
    public GameObject playerOne; //Attaching first player asset to script
    public GameObject playerTwo;  //Attaching second player asset to script
    public GameObject completetionWall;  //Attaching completion wall to script
    private GameManager gameManager; //game manager

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //detecting game manager
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            levelEasy.gameObject.SetActive(true); //Once player beats level the easy level button reappears
            levelNormal.gameObject.SetActive(true); //Once player beats level the normal level button reappears
            levelHard.gameObject.SetActive(true); //Once player beats level the hard level button reappears
            levelImpossible.gameObject.SetActive(true); //Once player beats level the impossible level button reappears
            background.gameObject.SetActive(true); //Once player beats level the background reappears
            playerOne.gameObject.SetActive(false); //Once player beats level the first player asset reappears
            playerTwo.gameObject.SetActive(false); //Once player beats level the second player asset reappears
            completetionWall.gameObject.SetActive(false); //Completion wall disappears after beating level
            gameManager.UpdateScore(1); //adding to score when beating a level

        }
    }

}

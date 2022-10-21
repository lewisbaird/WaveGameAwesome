using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletion : MonoBehaviour
{
    public GameObject levelEasy;
    public GameObject levelNormal;
    public GameObject levelHard;
    public GameObject levelImpossible;
    public GameObject background;
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject completetionWall;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            levelEasy.gameObject.SetActive(true);
            levelNormal.gameObject.SetActive(true);
            levelHard.gameObject.SetActive(true);
            levelImpossible.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
            playerOne.gameObject.SetActive(false);
            playerTwo.gameObject.SetActive(false);
            completetionWall.gameObject.SetActive(false);
            gameManager.UpdateScore(1);

        }
    }

}

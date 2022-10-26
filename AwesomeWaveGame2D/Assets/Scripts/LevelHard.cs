using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelHard : MonoBehaviour
{
    public GameObject hardLevelPrefab; //attaching level hard to script

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpawnLevel()
    {
        Instantiate(hardLevelPrefab, transform.position, hardLevelPrefab.transform.rotation); //spawns level hard
    }
}

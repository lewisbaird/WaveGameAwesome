using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelMedium : MonoBehaviour
{
    public GameObject mediumLevelPrefab; //attaching level medium to script

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpawnLevel()
    {
        Instantiate(mediumLevelPrefab, transform.position, mediumLevelPrefab.transform.rotation); //spawns level medium
    }
}

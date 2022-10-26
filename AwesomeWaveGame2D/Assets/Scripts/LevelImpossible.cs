using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelImpossible : MonoBehaviour
{
    public GameObject impossibleLevelPrefab; //attaching level impossible to script

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpawnLevel()
    {
        Instantiate(impossibleLevelPrefab, transform.position, impossibleLevelPrefab.transform.rotation); //spawns level impossible
    }
}

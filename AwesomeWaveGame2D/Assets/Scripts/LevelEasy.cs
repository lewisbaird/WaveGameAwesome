using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelEasy : MonoBehaviour
{
    public GameObject easyLevelPrefab;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpawnLevel()
    {
        Instantiate(easyLevelPrefab, transform.position, easyLevelPrefab.transform.rotation);
    }
}

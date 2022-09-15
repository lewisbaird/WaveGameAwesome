using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelHard : MonoBehaviour
{
    public GameObject hardLevelPrefab;
    private Button button;

    void Start()
    {

    }

    void Update()
    {

    }

    public void RestartGame()
    {
        Instantiate(hardLevelPrefab, transform.position, hardLevelPrefab.transform.rotation);
    }
}

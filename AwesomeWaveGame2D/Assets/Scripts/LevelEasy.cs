using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEasy : MonoBehaviour
{
    public GameObject easyLevelPrefab;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(easyLevelPrefab, transform.position, easyLevelPrefab.transform.rotation);
        }
    }
}

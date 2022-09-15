using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelImpossible : MonoBehaviour
{
    public GameObject impossibleLevelPrefab;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(impossibleLevelPrefab, transform.position, impossibleLevelPrefab.transform.rotation);
        }
    }
}

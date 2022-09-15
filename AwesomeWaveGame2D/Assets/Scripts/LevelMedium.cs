using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedium : MonoBehaviour
{
    public GameObject mediumLevelPrefab;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(mediumLevelPrefab, transform.position, mediumLevelPrefab.transform.rotation);
        }
    }
}

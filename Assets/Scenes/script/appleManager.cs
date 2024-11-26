using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class appleManager : MonoBehaviour
{

    public GameObject apple;
    public float spwanInterval = 1f;


    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spwanInterval);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(16.0f, 36.0f);
        
        Vector3 responPosition = new Vector3(randomX, 47.0f, -7.0f);
        Instantiate(apple, responPosition, Quaternion.identity);
    }
}

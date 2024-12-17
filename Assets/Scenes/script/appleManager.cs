using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class appleManager : MonoBehaviour
{

    public GameObject apple;
    public float spwanInterval = 1f;
    private GameObject player;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spwanInterval);
        player = GameObject.Find("unitychan_dynamic_locomotion");
    }

    void SpawnObject()
    {
        const float minRandom = -66.4f;
        float randomX = Random.Range(16.0f, 36.0f);
        float randomZ = Random.Range(-66.4f, 10.0f);
        Vector3 responPosition = new Vector3(randomX, 100.0f, randomZ);
        Instantiate(apple, responPosition, Quaternion.identity);
    }
}

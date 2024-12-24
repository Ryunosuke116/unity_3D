using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class objectManager : MonoBehaviour
{

    public GameObject SpikeBall;
    public float spwanInterval = 1.5f;
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
        float maxZ = player.transform.position.z;
        float randomX = Random.Range(16.0f, 36.0f);
        float randomZ = Random.Range(minRandom, maxZ);
        Vector3 responPosition = new Vector3(randomX, 100.0f, randomZ);
        Instantiate(SpikeBall, responPosition, Quaternion.identity);
    }
}

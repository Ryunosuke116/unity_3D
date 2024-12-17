using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    private GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //unitychan�̏����擾
        this.player = GameObject.Find("unitychan_dynamic_locomotion");

        //MainCamera��player�Ƃ̑��΋��������߂�
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}

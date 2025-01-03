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
        //unitychanの情報を取得
        this.player = GameObject.Find("unitychan_dynamic_locomotion");

        //MainCameraとplayerとの相対距離を求める
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}

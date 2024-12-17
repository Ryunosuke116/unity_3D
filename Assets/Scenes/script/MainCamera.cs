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
        //unitychan‚Ìî•ñ‚ğæ“¾
        this.player = GameObject.Find("unitychan_dynamic_locomotion");

        //MainCamera‚Æplayer‚Æ‚Ì‘Š‘Î‹——£‚ğ‹‚ß‚é
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    Vector3 initialPos = new Vector3(0f,4f,-4.5f);
    // Start is called before the first frame update
    void Start()
    {
        // initialPos = transform.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + initialPos;
    }
}

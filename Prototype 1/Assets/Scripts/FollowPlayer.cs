﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset = new Vector3(0f, 5f, -7f);

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}

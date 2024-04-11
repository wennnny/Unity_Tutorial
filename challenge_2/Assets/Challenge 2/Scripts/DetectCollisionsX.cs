﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + gameObject.name);
        Destroy(gameObject);
    }
}

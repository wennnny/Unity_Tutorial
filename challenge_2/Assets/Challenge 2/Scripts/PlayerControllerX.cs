using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeBetweenDogs = 0.2f;
    private float timeSinceLastDog = 0f;

    // Update is called once per frame
    void Update()
    {
        timeSinceLastDog += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastDog > timeBetweenDogs)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastDog = 0f;
        }
    }
}

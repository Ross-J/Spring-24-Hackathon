using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;

 void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }
}

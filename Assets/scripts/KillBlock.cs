using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBlock : MonoBehaviour
{
   //Code to kill my character
    
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawn_point.transform.position;
    }
}

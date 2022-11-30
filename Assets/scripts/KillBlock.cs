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
        if(other.tag == "Player")
        {
            player.transform.position = respawn_point.transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
            player.transform.position = respawn_point.transform.position;
        }
    }
}

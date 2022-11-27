using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedz;
   
    
    void Update()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY, 360 * speedX * Time.deltaTime);
    }
}

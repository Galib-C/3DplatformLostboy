using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCoin : MonoBehaviour
{
    public int coins;
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collected");
                coins = coins + 1;
            //col.gameObject.SetActive(false);
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

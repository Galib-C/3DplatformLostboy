using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    GameObject cam;
    private void Start()
    {
        cam = GameObject.Find("Main Camera");
    }
    
    

  
    public float maxspeed = 3.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    
    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxspeed);

        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation,0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));



    }
}

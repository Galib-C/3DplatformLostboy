using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float maxSpeed;
    public float normalspeed = 10.0f;
    public float sprintspeed = 20.0f;

    GameObject cam;
    Rigidbody myRigidbody;
    public float maxSprint = 5.0f;
    public float sprintTimer;
    void Start()
    {
        sprintTimer = maxSprint;
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;

    }
    
    

  
    public float maxspeed = 3.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    
    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 300.0f;

    void Update()
    {
       

        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.3f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }

        if(sprintTimer > maxSprint)
        {
            sprintTimer = maxSprint;
        }

        if(Input.GetKey(KeyCode.LeftShift) && sprintTimer > 0.1F)
        {
            maxSpeed = sprintspeed;
            sprintTimer = sprintTimer - Time.deltaTime;
        }
        else
        {
            maxSpeed = normalspeed;
            if(Input.GetKey(KeyCode.LeftShift) == false) {
                sprintTimer = sprintTimer + Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = sprintspeed;
        }else
        {
            maxSpeed = normalspeed;
        }

        //transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxspeed);
        Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * maxspeed) + (transform.right * Input.GetAxis("Horizontal") * maxspeed);
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation,0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));



    }
}

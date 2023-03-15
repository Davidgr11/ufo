using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float playerSpeed = 3f;

    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller =transform.GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(movement *playerSpeed *Time.deltaTime);

        if(movement != Vector3.zero)
        {
            gameObject.transform.forward= movement;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public float vehicleSpeed = 2.0f;

    private Vector3 vehiclePos;
    private Vector3 initialPos;
    
    void Awake()
    {
        vehiclePos = transform.position;
        initialPos = vehiclePos;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Condition to check vehicle position
        if(initialPos.x < 0f)
        {
            Vector3 vehicleMove = transform.TransformDirection(1, 0, 0);
            vehiclePos += vehicleMove * vehicleSpeed * Time.deltaTime;
            transform.position = vehiclePos;
        }else if(initialPos.x > 0f)
        {
            Vector3 vehicleMove = transform.TransformDirection(1, 0, 0);
            vehiclePos -= vehicleMove * vehicleSpeed * Time.deltaTime;
            transform.position = vehiclePos;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Condition checks if vehicle triggered the Road collider on exit
        if(other.tag == "Road")
        {
            // Debug.Log("Vehicle Enters Trigger...");
            // Reverse the translation of the pedestrian
            vehicleSpeed *= -1;
        }
    }
}

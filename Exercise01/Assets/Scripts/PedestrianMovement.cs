using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianMovement : MonoBehaviour
{
    public float pedestrianSpeed = 1.0f;
    private Vector3 pedestrianPos;
    private Vector3 initialPos;

    void Awake()
    {
        pedestrianPos = transform.position;
        initialPos = pedestrianPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Condition to check pedestrian position
        if(initialPos.x < 0f)
        {
            Vector3 pedestrianMove = transform.TransformDirection(1, 0, 0);
            pedestrianPos += pedestrianMove * pedestrianSpeed * Time.deltaTime;
            transform.position = pedestrianPos;
        }else if(initialPos.x > 0f)
        {
            Vector3 pedestrianMove = transform.TransformDirection(1, 0, 0);
            pedestrianPos -= pedestrianMove * pedestrianSpeed * Time.deltaTime;
            transform.position = pedestrianPos;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Condition checks if vehicle triggered the Road collider on exit
        if (other.tag == "Road")
        {
            // Debug.Log("Pedestrian Enters Trigger");
            // Reverse the translation of the pedestrian
            pedestrianSpeed *= -1;
        }
        
    }
}

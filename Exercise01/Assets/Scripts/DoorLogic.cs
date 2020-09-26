using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    public GameObject building;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        // Builing collision is disabled once character enters through door
        if(other.tag == "Character")
        {
            building.GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Builing collision is enabled once character exits through door
        if (other.tag == "Character")
        {
            building.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

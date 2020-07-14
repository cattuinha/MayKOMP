using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Door")
        {
            instructions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) { }
                //mudar cena
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Door")
        {
            instructions.SetActive(false);
        }
    }
}

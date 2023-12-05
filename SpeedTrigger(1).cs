using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.8f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}

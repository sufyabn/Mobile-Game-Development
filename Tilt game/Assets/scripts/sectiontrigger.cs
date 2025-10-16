using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class sectiontrigger : MonoBehaviour
{
    public GameObject road;

    private void OnTriggerEnter(Collider other)
        
    {
        if (other.gameObject.CompareTag("trigger"))
        {
            Instantiate(road);
            Debug.Log("Contact");
        }

    }

}

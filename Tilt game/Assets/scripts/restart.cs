using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    
public class restart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("anything");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Triggered");
            SceneManager.LoadScene(0);
        }
    }
}
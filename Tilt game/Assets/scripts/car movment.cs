using System.Collections.Generic;
using System.Collections;
using UnityEngine;
public class carmovment : MonoBehaviour  // code for camera to follow the car.
{
[SerializeField] GameObject player;
    void Start()
{
    
}
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 2, 7);
    }

}

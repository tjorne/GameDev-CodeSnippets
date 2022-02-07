using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceSnippet : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    public Rigidbody rigidbody;

    void Update()
    {

        // Note: 
        // The Vector3.Distance is a somewhat performance heavy. Placing this in the update method is not good practice. 
        // Alternatives could be InvokeRepeating and avoid the Vector3.Distance. 

        float distance = Vector3.Distance(cube1.transform.position, cube2.transform.position);

        Debug.Log(distance);
    }
}
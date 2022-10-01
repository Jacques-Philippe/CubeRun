using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody rigidBody;

    public float ForwardForceMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        this.MoveForward();   
    }

    void MoveForward()
    {
        this.rigidBody.AddForce(-this.transform.forward * this.ForwardForceMagnitude * Time.deltaTime);
    }


}

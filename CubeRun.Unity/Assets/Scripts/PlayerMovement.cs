using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float sidewaysForceMagnitude;

    private Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = this.GetComponent<Rigidbody>();
    }

    public void MoveLeft()
    {
        this.rigidBody.AddForce(-this.transform.right * this.sidewaysForceMagnitude * Time.deltaTime);
    }

    public void MoveRight()
    {
        this.rigidBody.AddForce(this.transform.right * this.sidewaysForceMagnitude * Time.deltaTime);
    }
}

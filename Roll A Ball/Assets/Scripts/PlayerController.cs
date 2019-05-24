using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    void FixedUpdate()
    {
        float moveHori = Input.GetAxis("Horizontal");
        float moveVerti = Input.GetAxis("Vertical");

        Vector3 moveMent = new Vector3(moveHori,0.0f,moveVerti);
        rb.AddForce(moveMent * speed);
    }
}

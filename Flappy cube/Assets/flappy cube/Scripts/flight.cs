using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class flight : MonoBehaviour

{
    public float force = 10;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * force);
        }
    }
}

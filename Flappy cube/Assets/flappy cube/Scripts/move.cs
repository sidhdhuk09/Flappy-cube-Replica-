using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float val;
    public float speed;
    private void Update()
    {
        this.transform.position += Vector3.left * Time.deltaTime * speed;
        if(this.transform.position.x<val)
        {
            Destroy(this.gameObject);
        }
    }

}

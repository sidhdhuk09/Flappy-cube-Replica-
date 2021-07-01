using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float interwal;
    public float timer;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    
if(timer<0)
        {
            Instantiate(prefab, this.transform.position, this.transform.rotation);
            timer = interwal;
        }
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}

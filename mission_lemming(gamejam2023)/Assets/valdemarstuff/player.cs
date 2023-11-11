using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody playerrb;
    
    float vinput;
    public GameObject cameraobject;

    //coolstuff
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       playerrb=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vinput = Input.GetAxis("Vertical");
        
        playerrb.AddForce(cameraobject.transform.forward * speed * vinput * Time.deltaTime);

    }
}

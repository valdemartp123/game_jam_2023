using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody playerrb;
    public GameObject pivot;
    float vinput;
    public GameObject cameraobject;
    public float jumpheight;
    bool touchground;

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
        gameObject.transform.rotation = pivot.transform.rotation;
        vinput = Input.GetAxis("Vertical");
        
        playerrb.AddForce(cameraobject.transform.forward * speed * vinput * Time.deltaTime);

        if (  touchground==true&& Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("if");
            playerrb.AddForce(Vector3.up * jumpheight * Time.deltaTime, ForceMode.Impulse);
            touchground = false; 
        }


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("collision");
            touchground = true;
        }
    }


}

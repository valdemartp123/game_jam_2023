using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody playerrb;
  
    float vinput;
    public GameObject cameraobject;
    public float jumpheight;
    public bool touchground;
    public lemmingmanager lemmingmanager;
    float Hinput;
    public float rotatespeed;
    public Animator playeranimator;

    //coolstuff

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        playeranimator = gameObject.GetComponent<Animator>();
        lemmingmanager=GameObject.Find("lemmingmanager").GetComponent<lemmingmanager>();
        playerrb =gameObject.GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
       

        vinput = Input.GetAxis("Vertical");
        Hinput = Input.GetAxis("Horizontal");
        Vector3 force = (cameraobject.transform.forward * speed * vinput * Time.deltaTime);
        lemmingmanager.forces.Add(force);
        playerrb.AddForce(force);
        Vector3 rotation = (Vector3.up * Hinput * Time.deltaTime * rotatespeed);
        lemmingmanager.rotations.Add(rotation);
        transform.Rotate(rotation);
        if (  touchground==true&& Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log ("HOP!");
            Vector3 jumpforce = (jumpheight * Time.deltaTime * Vector3.up);
            playerrb.AddForce(jumpforce);
            lemmingmanager.jumpforces.Add(jumpforce);
            touchground = false; 
        } else { lemmingmanager.jumpforces.Add(new Vector3(0, 0, 0)); }


        //check for idlestate
        if (playerrb.velocity.magnitude <= 0.5f) { playeranimator.SetInteger("animstate", 1); }
        //check for walk
        if (playerrb.velocity.magnitude > 0.5f) { playeranimator.SetInteger("animstate", 2); }
        //check for jump
        if (playerrb.velocity.y > 0f) { playeranimator.SetInteger("animstate", 3); }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followerscript : MonoBehaviour
{

    float lemmingdelay;
    public int lemmingstartdelay;
    public lemmingmanager lemmingmanager;
    private Rigidbody lemmingrb;
    public GameObject player;
    public int forceIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        lemmingdelay = Time.deltaTime;
        lemmingmanager = GameObject.Find("lemmingmanager").GetComponent<lemmingmanager>();
        InvokeRepeating("programbit", lemmingstartdelay, lemmingdelay);
        lemmingrb = gameObject.GetComponent<Rigidbody>();
        forceIndex = 0 - lemmingstartdelay;
    }

   

    // Update is called once per frame
    void Update()
    {

        if(lemmingstartdelay >= 0)
        {
            Vector3 rotation = lemmingmanager.rotations[lemmingstartdelay];
            Vector3 force = lemmingmanager.forces[lemmingstartdelay];
            transform.GetComponent<Rigidbody>().AddForce(force);
            transform.Rotate(rotation);
            
            
                Vector3 jumpforce = lemmingmanager.jumpforces[lemmingstartdelay];
                transform.GetComponent<Rigidbody>().AddForce(jumpforce);

            
             
        }

        lemmingstartdelay++;


    }

    public void programbit()
    {
        

       // HashSet<string> frame = lemmingmanager.commands[index];
        //index++;

       // foreach(string command in frame)
        //{
       //     switch (command)
            //{
            //    case "W": 
             //       gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * player.GetComponent<player>().speed * Time.deltaTime);
              //      break;
              //  case "S":
              //      gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * player.GetComponent<player>().speed * Time.deltaTime*-1);
                //    break;

          //      default: break;
           // }
        //}


    }

}

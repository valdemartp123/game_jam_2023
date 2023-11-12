using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemmingmanager : MonoBehaviour
{

    public List<Vector3> forces = new List<Vector3>();
    public List<Vector3> rotations = new List<Vector3>();
    public List<Vector3> jumpforces = new List<Vector3>();

    public List<HashSet<string>> commands = new List<HashSet<string>>();
    public float lemmingpoint;
    public GameObject[] lemminger;
    public GameObject lemmingprefab;
    public int startlemmings;
    public int lemmingspacing;
    public GameObject lemmingstartposition;
    // Start is called before the first frame update
    void Start()
    {
        spawnstartlemmings();
    }

    // Update is called once per frame
    void Update()
    {
       /* HashSet<string> frame = new HashSet<string>();
        if (Input.GetKey(KeyCode.W))
        {
            frame.Add("W");
        }
         if (Input.GetKey(KeyCode.A))
        {

            frame.Add("A");
        }
         if (Input.GetKey(KeyCode.S))
        {
            frame.Add("S");

        }
         if (Input.GetKey(KeyCode.D))
        {
            frame.Add("D");

        }
         if (Input.GetKey(KeyCode.Space))
        {
            frame.Add("SPACE");
        }

        commands.Add(frame);*/
    }

    public void spawnstartlemmings()
    {
        float currentdelay= lemmingspacing;
        for (int i = 0; i < startlemmings; i++)
        {
            
            Instantiate(lemmingprefab, lemmingstartposition.transform.position, lemmingprefab.transform.rotation).gameObject.GetComponent<followerscript>().lemmingstartdelay = lemmingspacing *-1* i;
            currentdelay += lemmingspacing;
            lemmingstartposition.transform.Translate(Vector3.back*2);
        }

    }


}

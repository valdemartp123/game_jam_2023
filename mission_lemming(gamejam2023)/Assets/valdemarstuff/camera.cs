using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float Hinput;
    public float rotatespeed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position;
        Hinput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Hinput * Time.deltaTime * rotatespeed);
    }
}

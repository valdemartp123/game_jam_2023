using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
   
   [SerializeField] float distanceToCover;
   [SerializeField] float speed;

   private Vector3 startingPosition;
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startingPosition;
        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAcceleration : MonoBehaviour
{
    public GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Wall") == false && collider.CompareTag("Floor") == false && controller.GetComponent<Acceleration>().accelerate == false)
        {
            controller.GetComponent<Acceleration>().setObject(collider.gameObject);
            controller.GetComponent<Acceleration>().accelerate = true;
            controller.GetComponent<Acceleration>().correctVelocity();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Wall") == false && collider.CompareTag("Floor") == false && controller.GetComponent<Acceleration>().accelerate == false)
        {
            controller.GetComponent<Acceleration>().setObject(collider.gameObject);
            controller.GetComponent<Acceleration>().accelerate = true;
            controller.GetComponent<Acceleration>().correctVelocity();
        }
    }
}

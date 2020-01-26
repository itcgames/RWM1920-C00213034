using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m_ball;
    public float Timer = 3.0f;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        if(Timer <= 0)
        {
            Instantiate(m_ball, transform.position,transform.rotation);
            Timer = 3.0f;
        }
    }
}

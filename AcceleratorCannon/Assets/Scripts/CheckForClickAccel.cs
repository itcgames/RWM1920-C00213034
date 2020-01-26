using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForClickAccel : MonoBehaviour
{
    public bool m_drag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        m_drag = true;
        Debug.Log("Click");
    }
    public void OnMouseUp()
    {
        m_drag = false;
    }
}

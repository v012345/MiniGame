using QFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ActionKit.Repeat().Delay(2.0f, () =>
        {
            Debug.Log(Time.time);
        }).Start(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

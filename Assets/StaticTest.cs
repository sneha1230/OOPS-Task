using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    //static variable creation
    static int score=0;

    static void IncrementScore()
    {
        Debug.Log("updated score is: "+ ++score);
    }
    void Start()
    {
        StaticTest myTest= new StaticTest();
        IncrementScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

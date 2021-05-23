using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {

    }
    private void Start()
    {
        //StartCoroutine("ColorTest");
        ColorsTest();
    }
    IEnumerator ColorTest()
    {
        print("Start of Coroutine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color=Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color=Color.green;
        yield return null;//wait for the end of frame
        print("end of coroutine");

    }
    void ColorsTest()
    {
        print("Start of normal function");
        GetComponent<Renderer>().material.color=Color.red;
        GetComponent<Renderer>().material.color=Color.green;
        print("end of normal function");
    }
}

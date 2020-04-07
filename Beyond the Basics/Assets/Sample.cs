using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public int numberToDisplay;
    // Start is called before the first frame update
    void Start()
    {
        SayHelloWorld();   
    }

    // Update is called once per frame
    private void SayHelloWorld()
    {
        for(int i = 0; i < numberToDisplay; i++){
            Debug.Log("hello world");
        }
    }
}
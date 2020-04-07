using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSceneController : MonoBehaviour
{
    public List<Shape> gameShapes;
    public int numberToCountTo;
    private Coroutine countToNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //        countToNumber = StartCoroutine(CountToNumber());
    //        StartCoroutine(SetShapesBlue());
    //        Debug.Log("Keypress Complete");
    //     }
    //     if (Input.GetKeyDown(KeyCode.S)){
    //         StopCoroutine(countToNumber);
    //     }
    // }
    // private IEnumerator SetShapesBlue(){
    //     foreach (Shape shape in gameShapes)
    //     {
    //         shape.SetColor(Color.blue);
    //         yield return new WaitForSeconds(2);
    //     }
    // }

    // private IEnumerator CountToNumber(){
    //     for(int i = 0; i < numberToCountTo; i++){
    //         Debug.Log(i);
    //         yield return null;
    //     }
    // }
}

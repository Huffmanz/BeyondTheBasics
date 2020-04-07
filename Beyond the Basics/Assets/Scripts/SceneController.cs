using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public List<Shape> gameShapes;
    public Dictionary<string, Shape> shapeDictionary;
    public Queue<Shape> shapeQueue;
    public Stack<Shape> shapeStack;
    // Start is called before the first frame update
    void Start()
    {
        shapeDictionary = new Dictionary<string, Shape>();
        shapeQueue = new Queue<Shape>();
        shapeStack = new Stack<Shape>();
        foreach (Shape shape in gameShapes)
        {
            shapeDictionary.Add(shape.Name,shape);
        }
        shapeQueue.Enqueue(shapeDictionary["Triangle"]);
        shapeQueue.Enqueue(shapeDictionary["Square"]);
        shapeQueue.Enqueue(shapeDictionary["Octagon"]);
        shapeQueue.Enqueue(shapeDictionary["Circle"]);

        shapeStack.Push(shapeDictionary["Triangle"]);
        shapeStack.Push(shapeDictionary["Square"]);
        shapeStack.Push(shapeDictionary["Octagon"]);
        shapeStack.Push(shapeDictionary["Circle"]);

    }

    private void setRedByName(string name){
        shapeDictionary[name].SetColor(Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            setRedByName("Square");
        }
        if(Input.GetKeyDown(KeyCode.C)){
            setRedByName("Circle");
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            //if(shapeQueue.Count > 0){
            if(shapeStack.Count > 0){
                //Shape shape = shapeQueue.Dequeue();
                Shape shape = shapeStack.Pop();
                shape.SetColor(Color.blue);
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObjects : MonoBehaviour
{
    // Start is called before the first frame update
    //create a car instance
    //public Car myBigCar;
    //const float pi=3.141f;//only used for constant values
    public enum Direction{East,West,South,North}

    void Start()
    {
        Direction myDirection;

        myDirection=GetMyDirection(Direction.East);
        Debug.Log("my direction is "+myDirection);
        
    }

    // Update is called once per frame
    Direction GetMyDirection(Direction direction)
    {
        Direction dir;
        dir=Direction.East;
        if(direction==Direction.East)
        {
            dir=Direction.North;
        }
        return dir;
    }
}

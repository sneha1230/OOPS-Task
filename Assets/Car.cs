using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is empty car class
[System.Serializable]
public class Car 
{
    //attributes or properties
    public string carName;
    public int makeYear;
    public float maxSpeed;
    
    //constructor
    public Car()
    {
        Debug.Log("car defualt constructor called");
    }
    public Car(float maximumSpeed)
    {
        maxSpeed=maximumSpeed;
        Debug.Log("second constructor called");
        Debug.Log("Maximum Speed:"+maxSpeed);
    }
    public Car(int makeYear, string carName)
    {
        this.makeYear=makeYear;
        this.carName=carName;
    }
    //behaviors or methods
    public void Drive()
    {
        Debug.Log("this drive car name is "+carName);
    }
   public  void ApplyBrake()
    {
        Debug.Log("this is to apply a car brake");
    }
    /*public float Speed()
    {
        Debug.Log("the max speed of the car:" + maxSpeed);
        return maxSpeed;
    }*/
    public void PrintCarDetails()
    {
        Debug.Log("the car name is "+carName);
        Debug.Log("the car make year is "+makeYear);
        Debug.Log("the car max speed is "+maxSpeed);
    }
}

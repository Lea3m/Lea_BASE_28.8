using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class elevator : MonoBehaviour
{
    int CurrentFloor;
    int BottomFloor;
    int UpperFloor;
    bool isShabat;
    bool Direction;

    public elevator()
    {
        this.CurrentFloor = 0;
        this.BottomFloor = 0;
        this.UpperFloor = 10;
    }

    public void GoUp(int floorCount)
    {
        Debug.Log($"The elevator will go up {floorCount} floors");
        this.CurrentFloor += floorCount;
    }
    public void GoDown(int floorCount)
    {
        Debug.Log($"The elevator will go down {floorCount} floors");
        this.CurrentFloor -= floorCount;

    }
  
    public void Shabat(int floorCount)
    {
        if (this.isShabat == true)
        {

            if (this.Direction == true)
            {
                GoUp(1);
            }

            if (this.Direction == false)
            {
               GoDown(1);
            }

            if (CurrentFloor == BottomFloor)
            {
                this.Direction = true;
            }
            if (CurrentFloor == UpperFloor)
            {
                this.Direction = false;
            }
        }


    }
    public void Start()
    {
        this.GoDown(1);
        this.GoUp(4);
        Debug.Log($"The elevetor now on floor: {this.CurrentFloor}.");
    }

}

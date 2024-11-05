using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Method(5);
        Method(10);
        Method(-5);
        SwitchNumber(1);
        SwitchNumber(2);
        SwitchNumber(3);
    }
    static void Method(int Number)
    {
        int result = Number * 2;
        Debug.Log(result);

        if (result > 0)
        {
            Debug.Log("The result bigger that 0");
        }

        else
        {
            Debug.Log("The result smaller that 0");

        }
    }
    static void SwitchNumber(int Numbers)
    {
        switch (Numbers)
        {
            case 1:
                Debug.Log("The switch number is 1");
                break;
            case 2:
                Debug.Log("The  switch number is 2");
                break;
            case 3:
                Debug.Log("The  switch number is 3");
                break;
        }
    }
}


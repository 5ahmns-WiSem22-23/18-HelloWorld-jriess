using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    int[,] intArray = new int[5,2];

    private void Start()
    {
        PrintArray();
    }

    void PrintArray()
    {
        
        for (int x = 0; x < intArray.GetLength(0); x++)
        {
            for (int y = 0; y < intArray.GetLength(1); y++)
            {
                Debug.Log(intArray[x, y]);
            }
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloHUE : MonoBehaviour
{
    char[,] myArray = new char[3, 4];
    int characterIndex;

    private void Start()
    {
        LoopThroughArray();      
    }

    void LoopThroughArray()
    {
        characterIndex = 65;
        for (int y = 0; y < myArray.GetLength(0); y++)
        {
            for (int x = 0; x < myArray.GetLength(1); x++)
            {               
                myArray[y, x] = (char)characterIndex;
                characterIndex++;
                Debug.Log(myArray[y,x]);
            }
        }
    }
}

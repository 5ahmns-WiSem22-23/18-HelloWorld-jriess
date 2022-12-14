using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //2) Instanzvariable nutzen
    int startValue = 0;

    //3) Der Wert, der dazugezählt wird, ist bei Deklaration noch nicht bekannt
    // z.B.: Random oder User Input
    int startValue_2;

    //4) copyByValue
    int startValue_3 = 10;

    //5) Return
    int startValue_4 = 20;

    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        //at 2) Instanzvariable nutzen
        Debug.Log("before startValue: " + startValue);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue);

        //at 3) Random value nutzen
        Debug.Log("before startValue: " + startValue_2);
        IncrementByX(Random.Range(1,10));
        Debug.Log("after startValue: " + startValue_2);

        //at 4)
        Debug.Log("before startValue: " + startValue_3);
        DecrementByOne(startValue_3);
        Debug.Log("after startValue: " + startValue_3);

        //at 5) 
        Debug.Log("before startValue: " + startValue_4);
        startValue_4 = DecrementByX(startValue_4, 5);
        Debug.Log("before startValue: " + startValue_4);
    }

    int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    void IncrementByX(int valToAdd)
    {
        startValue_2 += valToAdd;
    }
    
    void IncrementByOne()
    {
        startValue++;
        //startValue = startValue + 1;
    }
}

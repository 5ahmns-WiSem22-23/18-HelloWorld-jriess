using UnityEngine;

public class RefactureHelloMethoden : MonoBehaviour
{
    enum Operators
    {
        plus,
        minus,
        multiplicate,
        divide
    }

    Operators operatorToTake;

    private void Start()
    {
        IncrementValue(1, 4, operatorToTake);
    }

    int IncrementValue(int baseValue, int valueToAdjust, Operators operators)
    {
        if(operators == Operators.plus)
        {
            baseValue += valueToAdjust;
        }
        else if(operators == Operators.minus)
        {
            baseValue -= valueToAdjust;
        }
        else if(operators == Operators.multiplicate)
        {
            baseValue *= valueToAdjust;
        }
        else if(operators == Operators.divide)
        {
            baseValue /= valueToAdjust;
        }
        
        return baseValue;
    }
}

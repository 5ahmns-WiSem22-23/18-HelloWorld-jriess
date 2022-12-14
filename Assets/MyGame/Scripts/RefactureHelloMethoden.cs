using UnityEngine;

public class RefactureHelloMethoden : MonoBehaviour
{
    enum Operators
    {
        plus,
        minus,
    }

    Operators operatorToTake;

    private void Start()
    {
        operatorToTake = Operators.plus;
        ChangeValue(1, 4, operatorToTake);
    }

    int ChangeValue(int baseValue, int valueToAdjust, Operators operators)
    {
        if(operators == Operators.plus)
        {
            baseValue += valueToAdjust;
        }
        else if(operators == Operators.minus)
        {
            baseValue -= valueToAdjust;
        }
        
        return baseValue;
    }
}

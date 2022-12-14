using UnityEngine;

public class RefactureHelloMethoden : MonoBehaviour
{
    enum Operators
    {
        plus,
        minus,
    }

    private void Start()
    {
        Debug.Log(ChangeValue(8, 3, Operators.plus));
        Debug.Log(ChangeValue(8, 3, Operators.minus));
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

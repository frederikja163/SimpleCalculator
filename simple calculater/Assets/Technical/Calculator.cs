using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    private string str;

    private void Start()
    {
        str = "";
    }

    public void AddInput(char input)
    {
        str += input;
    }

}

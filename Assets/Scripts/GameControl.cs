using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Button okButtom;
    public InputField answerField; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PrintAnswer()
    {
        print(answerField.text);
    }
    // Update is called once per frame
    void Update()
    {
       //print(answerField.text);
    }
}

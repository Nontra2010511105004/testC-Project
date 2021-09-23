using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Button okButtom;
    public Button PlayAgain;
    public InputField answerField; 
    public Text displayText;
    string[] answers;
    string[] Question;
    int currentQuestionNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        answers = new string[3];
        Question = new string[] {"What is your name?",
                            "How old are you? ",
                            "What do you like to do at freetime??" };
        //string randomText = Question[Random.Range(0, Question.Length)];
        //displayText.text = randomText;
        displayText.text = Question[currentQuestionNumber];
    }
    public void PrintAnswer()
    {       
            answers[currentQuestionNumber] = answerField.text;
            answerField.text = "";

            displayText.text = "";
           
            answerField.text = (answers[0]+answers[1]+answers[2]);
            currentQuestionNumber= currentQuestionNumber+1;
                    
            print(answers[0]+answers[1]+answers[2]);
        //print(answerField.text);
        if (currentQuestionNumber<=2)
        {
            displayText.text = Question[currentQuestionNumber];
        }          
        else 
        {
            displayText.text = " Your name is "+answers[0]+
                                "\n Your old is  "+answers[1]+
                                "\n and like to "+answers[2]+
                                "\n Tired .me too about learn online HAHA";
            
            okButtom.gameObject.SetActive(false);
            answerField.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
       //print(answerField.text);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   }

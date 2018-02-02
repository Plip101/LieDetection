using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Questions : MonoBehaviour
{
    public Text questions;
    public int number;
    // Use this for initialization
    void Start()
    {
        questions = GetComponent<Text>();
       
    }

    // Update is called once per frame
    void Update()
    {
        number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;
        if (number == 1)
        {
            questions.text = "Is the Shape to your left blue?";
        }
        else if (number == 2)
        {
            questions.text = "Do you live in 4 privet drive?";
        }
        else if(number == 3)
        {
            questions.text = "Have you ever cheated on a college exam?";
        }
        else if(number == 4)
        {
            questions.text = "Am I the only other person in this room?";
        }
        else if(number == 5)
        {
            questions.text = "Do you ever doubt if you belong in your college course?";
        }
        else if(number == 6)
        {
            questions.text = "Is your name William Moulton Marston?";
        }
        else if(number == 7)
        {
            questions.text = "Are you 432 years old?";
        }
        else if(number == 8)
        {
            questions.text = "Have you ever stolen a physical good?";
        }
        else if(number == 9)
        {
            questions.text = "Are the shapes on the table infront of us cubes?";
        }
        else if(number == 10)
        {
            questions.text = "Have you ever been attracted to a family member?";
        }
        else if(number > 10)
        {
            questions.text = "Congrats, Finished!";
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSounds : MonoBehaviour
{
    public AudioClip question1, question2, question3, question4, question5, question6, question7, question8, question9, question10;
    public AudioSource question11;
    public int number;
    public bool play;
    // Use this for initialization
    void Start()
    {
        question11 = GetComponent<AudioSource>();
        number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;
        play = false;


    }

    // Update is called once per frame
    void Update()
    {
        number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;
        if (Input.GetKeyDown("space"))
        {
            play = false;
        }
        if (number == 0 && play == false)
        {
            question11.PlayOneShot(question1, 2.0f);
            play = true;
        }
        if (number == 1 && play != true)
        {
            question11.PlayOneShot(question2, 2.0f);
            play = true;
           
        }
        else if (number == 2 && play != true)
        {
            question11.PlayOneShot(question3, 2.0f);
            play = true;

        }
        else if (number == 3 && play != true)
        {
            question11.PlayOneShot(question4, 2.0f);
            play = true;

        }
        else if (number == 4 && play != true)
        {
            question11.PlayOneShot(question5, 2.0f);
            play = true;

        }
        else if (number == 5 && play != true)
        {
            question11.PlayOneShot(question6, 2.0f);
            play = true;

        }
        else if (number == 6 && play != true)
        {
            question11.PlayOneShot(question7, 2.0f);
            play = true;

        }
        else if (number == 7 && play != true)
        {
            question11.PlayOneShot(question8, 2.0f);
            play = true;

        }
        else if (number == 8 && play != true)
        {
            question11.PlayOneShot(question9, 2.0f);
            play = true;

        }
        else if (number == 9 && play != true)
        {
            question11.PlayOneShot(question10, 2.0f);
            play = true;

        }
    }
}

       
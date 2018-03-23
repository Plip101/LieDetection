using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSounds : MonoBehaviour
{
    public AudioClip question1, question2, question3, question4, question5, question6, question7, question8, question9, question10;
    public AudioSource question11;
    public int number;
    public bool play1, play2, play3, play4, play5, play6, play7, play8, play9, play10;
    // Use this for initialization
    void Start()
    {
        question11 = GetComponent<AudioSource>();
        //number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;
        play1 = false;
        play2 = false;
        play3 = false;
        play4 = false;
        play5 = false;
        play6 = false;
        play7 = false;
        play8 = false;
        play9 = false;
        play10 = false;

    }

    // Update is called once per frame
    void Update()
    {
        number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;
        /*if (Input.GetKeyDown("space"))
        {
            play = false;
        }*/
        if (number == 1 && play1 != true)
        {
            question11.PlayOneShot(question1, 2.0f);
            play1 = true;
        }
        if (number == 2 && play2 != true)
        {
            question11.PlayOneShot(question2, 2.0f);
            play2 = true;

        }
        else if (number == 3 && play3 != true)
        {
            question11.PlayOneShot(question3, 2.0f);
            play3 = true;

        }
        else if (number == 4 && play4 != true)
        {
            question11.PlayOneShot(question4, 2.0f);
            play4 = true;

        }
        else if (number == 5 && play5 != true)
        {
            question11.PlayOneShot(question5, 2.0f);
            play5 = true;

        }
        else if (number == 6 && play6 != true)
        {
            question11.PlayOneShot(question6, 2.0f);
            play6 = true;

        }
        else if (number == 7 && play7 != true)
        {
            question11.PlayOneShot(question7, 2.0f);
            play7 = true;

        }
        else if (number == 8 && play8 != true)
        {
            question11.PlayOneShot(question8, 2.0f);
            play8 = true;

        }
        else if (number == 9 && play9 != true)
        {
            question11.PlayOneShot(question9, 2.0f);
            play9 = true;

        }
        else if (number == 10 && play10 != true)
        {
            question11.PlayOneShot(question10, 2.0f);
            play10 = true;

        }
    }
}

       
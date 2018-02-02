using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSounds : MonoBehaviour {
    public AudioClip question1, question2, question3, question4, question5, question6, question7, question8, question9, question10;
    public AudioSource question11, question12, question13, question14, question15, question16, question17, question18, question19, question20;
    public int number;
    // Use this for initialization
    void Start () {
      question11  = GetComponent<AudioSource>();
      question12  = GetComponent<AudioSource>();
      question13  = GetComponent<AudioSource>();
      question14  = GetComponent<AudioSource>();
      question15  = GetComponent<AudioSource>();
      question16  = GetComponent<AudioSource>();
      question17  = GetComponent<AudioSource>();
    



    }

    // Update is called once per frame
    void Update () {
        number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;

        if (number == 0)
        {
            question11.clip = question1;
            question11.Play();
        }
        else if (number == 1)
        {
            question12.clip = question2;
            question12.Play();
        }
       else if (number == 2)
        {
            question13.clip = question3;
            question12.Play();
        }
        //else { question11.Stop(); }

        /* if (number == 2)
         { question2.Play(); }
         /*else { question2.Stop(); }
         if (number == 3)
         { question3.Play(); }
         else { question3.Stop(); }
         if (number == 4)
         { question4.Play(); }
         else { question4.Stop(); }
         if (number == 5)
         { question5.Play(); }
         else { question5.Stop(); }
         if (number == 6)
         { question6.Play(); }
         else { question6.Stop(); }
         if (number == 7)
         { question7.Play(); }
         else { question7.Stop(); }
         if (number == 8)
         { question8.Play(); }
         else { question8.Stop(); }
         if (number == 9)
         { question9.Play(); }
         else { question9.Stop(); }
         if (number == 10)
         { question10.Play(); }
         else { question10.Stop(); }
         */
    }
}

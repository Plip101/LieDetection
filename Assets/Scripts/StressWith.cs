using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class StressWith : MonoBehaviour
{

    public Text with;
    public string line;
    public int number;
    public int withrelaxed, withstressed, withneutral;
    public int[] withrelax;
    public int[] withstress;
    public int[] withneut;
    public bool enumer;
    public int finalresults;
    public int counter;
    // Use this for initialization
    void Start()
    {
        withrelaxed = 0;
        withstressed = 0;
        withneutral = 0;
        finalresults = 0;
        withrelax = new int[10];
        withstress = new int[10];
        withneut = new int[10];
        with = GetComponent<Text>();

    }
    void readTextFileWith(string file_path)
    {
        StreamReader inp_stm = new StreamReader(file_path);
        while ((line = inp_stm.ReadLine()) != null)
        {
            for (int i = 1; i < 15; i++)
            {
                if (line.Contains(i + "0.") || line.Contains(i + "1.") || line.Contains(i + "2.") || line.Contains(i + "3.") || line.Contains(i + "4.") || line.Contains(i + "5.") || line.Contains(i + "6.") || line.Contains(i + "7.") || line.Contains(i + "8.") || line.Contains(i + "9."))
                {
                    if (line.Contains(",1,"))
                    {
                        if (i < 11)
                        {
                            withrelax[i - 1] += 1;
                        }
                        //relaxed += 1;
                    }
                    if (line.Contains(",2,"))
                    {
                        if (i < 11)
                        {
                            withstress[i - 1] += 1;
                        }
                    }
                    if (line.Contains(",3,"))
                    {
                        if (i < 11)
                        {
                            withneut[i - 1] += 1;
                        }

                    }

                }
            }
            if (line.Contains(",1,"))
            {

                withrelaxed += 1;

                //relaxed += 1;
            }
            if (line.Contains(",2,"))
            {

                withstressed += 1;

            }
            if (line.Contains(",3,"))
            {

                withneutral += 1;


            }
            counter++;
        }

        
        inp_stm.Close();
        System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen.  
        System.Console.ReadLine();
    }
    IEnumerator Questions()
    {

        enumer = true;
        for (int i = 1; i < 11; i++)
        {
            with.text = "Question " + i + "- Stress reduction -" + "\n" + "Relaxed: " + withrelax[i - 1] + "\n" + "Stressed: " + withstress[i - 1] + "\n"
                + "Neutral: " + withneut[i - 1];
            Debug.Log(with.text);
            finalresults += 1;
            yield return new WaitForSeconds(5f);
        }


        enumer = false;
    }
    // Update is called once per frame
    void Update()
    {
        //stress.text = "Relaxed: " + relaxed;
        int number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;

        if (Input.GetKeyDown("d"))
        {


            if (enumer == false && number >= 10)
            {
                readTextFileWith("C:/Users/Bazma/OneDrive/Documents/GitHub/LieDetection/Assets/Test with.EDA");
                StartCoroutine("Questions");
            }
        }
        if (Input.GetKeyDown("f"))
        {
            if (finalresults >= 10 && number >= 10)
            {
                with.text = "Total: " + " - No stress reduction -" + "\n" + "Relaxed: " + withrelaxed + "\n" + "Stressed: " + withstressed + "\n"
                + "Neutral: " + withneutral;
                finalresults += 1;
            }
        }

    }
}



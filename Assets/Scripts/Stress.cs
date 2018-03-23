using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Stress : MonoBehaviour
{

    public Text without;
    public Text question;
    public string line;
    public int number;
    public int withoutrelaxed, withoutstressed, withoutneutral;
    public int relaxed;
    public int counter;
    public int[] withoutrelax;
    public int[] withoutstress;
    public int[] withoutneut;
    public bool enumer;
    public bool[] lie;
    public int finalresults;
    // Use this for initialization
    void Start()
    {
        withoutrelaxed = 0;
        withoutstressed = 0;
        withoutneutral = 0;
        finalresults = 0;
        enumer = false;
        withoutrelax = new int[10];
        withoutstress = new int[10];
        withoutneut = new int[10];
        lie = new bool[10];
        without = GetComponent<Text>();
        question = GetComponent<Text>();

    }
    void readTextFileWithout(string file_path)
    {
        StreamReader inp_stm = new StreamReader(file_path);

        while ((line = inp_stm.ReadLine()) != null)
        {
            for (int i = 1; i < 15; i++)
            {
                if (line.Contains(i+"0.") || line.Contains(i + "1.") || line.Contains(i + "2.") || line.Contains(i + "3.") || line.Contains(i + "4.") || line.Contains(i + "5.") || line.Contains(i + "6.") || line.Contains(i + "7.") || line.Contains(i + "8.") || line.Contains(i + "9."))
                {
                    if (line.Contains(",1,"))
                    {
                        if (i < 11)
                        {
                            withoutrelax[i - 1] += 1;
                        }
                            //relaxed += 1;
                    }
                    if (line.Contains(",2,"))
                    {
                        if (i < 11)
                        {
                            withoutstress[i - 1] += 1;
                        }
                    }
                    if (line.Contains(",3,"))
                    {
                        if (i < 11)
                        {
                            withoutneut[i - 1] += 1;
                        }

                    }
                    
                }
            }
            if (line.Contains(",1,"))
            {
                
                    withoutrelaxed += 1;
                
                //relaxed += 1;
            }
            if (line.Contains(",2,"))
            {
                
                    withoutstressed += 1;
                
            }
            if (line.Contains(",3,"))
            {
               
                    withoutneutral += 1;
               

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
            if(withoutrelax[i-1] < withoutstress[i-1])
            {
                lie[i - 1] = true;
                question.text = "Lie";
            }
            else if (withoutrelax[i - 1] > withoutstress[i - 1])
            {
                lie[i - 1] = false;
                question.text = "True";
            }

            without.text = "Question " + i + " - No stress reduction -" + "\n" + "Relaxed: " + withoutrelax[i-1] + "\n" + "Stressed: " + withoutstress[i-1] + "\n"
                + "Neutral: " + withoutneut[i-1];
            Debug.Log(without.text);
            Debug.Log(lie[i - 1]);
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
                readTextFileWithout("C:/Users/Bazma/OneDrive/Documents/GitHub/LieDetection/Assets/Test without.EDA");
                StartCoroutine("Questions");
            }
            
        }
        if (Input.GetKeyDown("f"))
        {
            if (finalresults >= 10 && number >= 10)
            {
                without.text = "Total: " + " - No stress reduction -" + "\n" + "Relaxed: " + withoutrelaxed + "\n" + "Stressed: " + withoutstressed + "\n"
                + "Neutral: " + withoutneutral;
                finalresults += 1;
            }
        }

    }
}



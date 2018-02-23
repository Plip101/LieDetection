﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionIndicator : MonoBehaviour {
    private GameObject table1, table2, table3, table4, table5, table6, table7, table8, table9, table10, blueshape;
    private GameObject[] tables_array;
    public int number;
    // Use this for initialization
    void Start () {
        
        table1 = GameObject.Find("/Tabel items/Table1");
        table2 = GameObject.Find("/Tabel items/Table2");
        table3 = GameObject.Find("/Tabel items/Table3");
        table4 = GameObject.Find("/Tabel items/Table4");
        table5 = GameObject.Find("/Tabel items/Table5");
        table6 = GameObject.Find("/Tabel items/Table6");
        table7 = GameObject.Find("/Tabel items/Table7");
        table8 = GameObject.Find("/Tabel items/Table8");
        table9 = GameObject.Find("/Tabel items/Table9");
        table10 = GameObject.Find("/Tabel items/Table10");
        blueshape = GameObject.Find("Blue Shape");

        number = 0;
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] tables_array =
            {
            table1, table2, table3, table4, table5, table6,table7,table8,table9,table10
            };
        if (Input.GetKeyDown("space"))
        {
            tables_array[number].GetComponent<Renderer>().material.color = Color.red;
            number += 1;
            print(number);
            

            
        }
        if (number == 1)
        {
            blueshape.GetComponent<Renderer>().material.color = Color.blue;
        }
        else { blueshape.GetComponent<Renderer>().material.color = Color.white; }
	}
}
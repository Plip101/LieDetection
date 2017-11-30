using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionIndicator : MonoBehaviour {
    private GameObject table1, table2, table3, table4, table5, table6, table7, table8, table9, table10;
    private GameObject[] tables_array;
    int counter;
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
        
        counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] tables_array =
            {
            table1, table2, table3, table4, table5, table6,table7,table8,table9,table10
            };
        if (Input.GetKeyDown("space"))
        {
            tables_array[counter].GetComponent<Renderer>().material.color = Color.red;

            print(counter);
            counter += 1;

            
        }
	}
}

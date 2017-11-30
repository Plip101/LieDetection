using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour {
    int counter;
    private GameObject wallcube, wallcube2, wallcube3;

	// Use this for initialization
	void Start () {
        counter = 10;
        wallcube = GameObject.Find("/Wall items/Cube");
        wallcube2 = GameObject.Find("/Wall items/Cube (1)");
        wallcube3 = GameObject.Find("/Wall items/Cube (2)");
        
    }
	
	// Update is called once per frame
	void Update () {
        counter += 1;  
        if(Input.GetKeyDown("w"))
        {
            counter += 1;
        }

        if (counter > 10 && counter < 20 )
        {
            wallcube.GetComponent<Renderer>().material.color = Color.red;
        }
        else { wallcube.GetComponent<Renderer>().material.color = Color.white; }

        if (counter > 20 && counter < 30)
        {
            wallcube2.GetComponent<Renderer>().material.color = Color.red;
        }
        else { wallcube2.GetComponent<Renderer>().material.color = Color.white; }

        if (counter > 30 && counter < 40)
        {
            wallcube3.GetComponent<Renderer>().material.color = Color.red;
        }
        else { wallcube3.GetComponent<Renderer>().material.color = Color.white; }

   
        if (counter >= 40)
        {
            counter = 0;
        }
        
    }
}

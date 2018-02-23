using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMove : MonoBehaviour {
    public GameObject Horse;
	// Use this for initialization
	void Start () {
        Horse = GameObject.Find("/Calm/Horse");
    }
	
	// Update is called once per frame
	void Update () {
        Horse.transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public int number;
    public int walls;
    public Material Skybox1;
    public Material Skybox2;
    public Material Skybox3;
    public GameObject Calm;
    private GameObject LongWall1, LongWall2, ShortWall1, ShortWall2, Ceiling;
    public GameObject g;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public int play;
    // Use this for initialization
    void Start () {
        LongWall1 = GameObject.Find("/Room/Long wall 1");
        LongWall2 = GameObject.Find("/Room/Long wall 2");
        ShortWall1 = GameObject.Find("/Room/Short wall 1");
        ShortWall2 = GameObject.Find("/Room/Short wall 2");
        Ceiling = GameObject.Find("/Room/Ceiling");
        walls = 0;
        RenderSettings.skybox = Skybox1;
        play = 0;
        MusicSource = GetComponent<AudioSource>();
        MusicSource.clip = MusicClip;
        

    }
	
	// Update is called once per frame
	void Update () {
        number = GameObject.Find("Tabel items").GetComponent<QuestionIndicator>().number;
        
        if (Input.GetKeyDown("o"))
        {
            walls = 1;
            RenderSettings.skybox = Skybox2;
            play = 1;
            MusicSource.volume = 0.0f;
            MusicSource.Play();
            /*if (Calm != null)
            {
                GameObject g = Instantiate(Calm, new Vector3(-3.168f, 13.704f, 6.2451f), new Quaternion(0,0,0,0)) as GameObject;
                Debug.Log("Gay");
                g.name = "Calm";
            }*/
        }
        if (Input.GetKeyDown("p"))
        {
            walls = 2;
            play = 2;
            
            //Destroy(g);
        }
        Debug.Log(MusicSource.volume);
        if (play == 1)
        {
            
            if (MusicSource.volume < 1.0f)
            {
                MusicSource.volume += 0.01f;
            }
        }
        
        if (play == 2)
        {
            
            if (MusicSource.volume > 0.1f)
            {
                MusicSource.volume -= 0.011f;
            }
            if (MusicSource.volume <= 0.1f)
            {
                
                MusicSource.volume = 0.0f;
            }
            if(MusicSource.volume == 0.0f)
            {
                MusicSource.Pause();
            }
        }
        
        if (walls == 1)
        {
            if (LongWall1.transform.rotation.eulerAngles.x <= 89.0f)
            {
                Ceiling.transform.Translate(Vector3.forward * 6.0f * Time.deltaTime);
                LongWall1.transform.Rotate(Vector3.down * 40.0f * Time.deltaTime);
                LongWall1.transform.Translate(Vector3.forward * 4.0f * Time.deltaTime);

                LongWall2.transform.Rotate(Vector3.up * 40.0f * Time.deltaTime);
                LongWall2.transform.Translate(Vector3.back * 4.0f * Time.deltaTime);

                ShortWall1.transform.Rotate(Vector3.left * 40.0f * Time.deltaTime);
                ShortWall1.transform.Translate(Vector3.back * 4.0f * Time.deltaTime);

                ShortWall2.transform.Rotate(Vector3.right * 40.0f * Time.deltaTime);
                ShortWall2.transform.Translate(Vector3.forward * 4.0f * Time.deltaTime);
                

            }
        }
        
        if (walls == 2)
        {
            if (LongWall1.transform.rotation.eulerAngles.x > 3.0f)
            {
                
                Ceiling.transform.Translate(Vector3.forward * -6.0f * Time.deltaTime);
                LongWall1.transform.Rotate(Vector3.down * -40.0f * Time.deltaTime);
                LongWall1.transform.Translate(Vector3.forward * -4.0f * Time.deltaTime);

                LongWall2.transform.Rotate(Vector3.up * -40.0f * Time.deltaTime);
                LongWall2.transform.Translate(Vector3.back * -4.0f * Time.deltaTime);

                ShortWall1.transform.Rotate(Vector3.left * -40.0f * Time.deltaTime);
                ShortWall1.transform.Translate(Vector3.back * -4.0f * Time.deltaTime);

                ShortWall2.transform.Rotate(Vector3.right * -40.0f * Time.deltaTime);
                ShortWall2.transform.Translate(Vector3.forward * -4.0f * Time.deltaTime);
                
            }
            
        }
    }
}


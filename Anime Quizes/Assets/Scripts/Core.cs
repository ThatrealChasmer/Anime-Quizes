using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour {

    public Object[] uniforms;
    public List<Object> uniList;
    public List<string> uniNames;
    public bool gameEnded = false;
    public bool turnEnded = false;
    public int qNumber;
    public Text answer;
    public Image question;
    public GameObject pauseCanvas;
    public GameObject checkCanvas;
    public bool taken = false;
    public bool answered = false;


	// Use this for initialization
	void Start () {
        uniforms = Resources.LoadAll("Uniforms");

        for(int i = 0; i < uniforms.Length; i++)
        {
            uniList.Add(uniforms[i]);
        }

        string path = "Assets/Resources/UniformList.txt";

        string[] lines = System.IO.File.ReadAllLines(path);

        for (int j = 0; j < uniforms.Length; j++)
        {
            uniNames.Add(lines[j]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Turn(string player)
    {
        qNumber = Random.Range(0, uniList.Count);
        question.sprite = (Sprite)uniList[qNumber];
        answer.text = uniNames[qNumber];
        
    }

    public void Check()
    {
        checkCanvas.SetActive(true);
    }
}

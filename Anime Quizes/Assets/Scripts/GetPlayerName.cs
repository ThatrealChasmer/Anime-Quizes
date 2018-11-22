using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerName : MonoBehaviour {

    // Use this for initialization
    private string textAreaString = "";

    void OnGUI()
    {
        textAreaString = GUI.TextArea(new Rect(25, 25, 100, 30), textAreaString);
    }

    // Update is called once per frame
    public void GetName()
    {
        transform.GetComponent<PlayerData>().AddPlayer(textAreaString, 0);
    }
    
    public void RemoveName()
    {
        for(int i = 0; i < transform.GetComponent<PlayerData>().players.Count; i++)
        {
            if(transform.GetComponent<PlayerData>().players[i].name == textAreaString)
            {
                transform.GetComponent<PlayerData>().RemovePlayer(i);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour {

    public class Player
    {

        public string name;
        public int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    public List<Player> players;
    public Text namePrefab;
    public Text nameText;
    public GameObject playerList;

    private void Awake()
    {
        players = new List<Player>();

        players = Static.players;

        for (int i = 0; i < players.Count; i++)
        {
            nameText = Instantiate(namePrefab, new Vector3(725, 400 - i * 30, 0), Quaternion.identity, playerList.transform);
            nameText.text = players[i].name;
        }
    }
    
	// Use this for initialization
	void Start () {
        
    }

        // Update is called once per frame
    public void AddPlayer(string name, int score)
    {
        players.Add(new Player(name, score));
        foreach (Transform child in playerList.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        for (int i = 0; i < players.Count; i++)
        {
            nameText = Instantiate(namePrefab, new Vector3(725, 400 - i * 30, 0), Quaternion.identity, playerList.transform);
            nameText.text = players[i].name;
        }
    }

    public void RemovePlayer(int k)
    {
        players.RemoveAt(k);
        foreach (Transform child in playerList.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        for (int i = 0; i < players.Count; i++)
        {
            nameText = Instantiate(namePrefab, new Vector3(725, 400 - i * 30, 0), Quaternion.identity, playerList.transform);
            nameText.text = players[i].name;
        }
    }
}



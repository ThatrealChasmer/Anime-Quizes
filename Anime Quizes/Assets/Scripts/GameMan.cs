using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour {

    public GameObject playerManager;

    public void StartGame()
    {
        Static.players = playerManager.GetComponent<PlayerData>().players;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

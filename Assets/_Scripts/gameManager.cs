using System;

using UnityEngine;

public class gameManager : MonoBehaviour
{

    private StartButton _startButtonScript;

    private void Start()
    {
       _startButtonScript = GameObject.Find("Start Game Button").GetComponent<StartButton>();
    }

    private void Update()
    {
        if (_startButtonScript.gameStarted == true)
        {
            Debug.Log("Game Started");
        }
    }
}

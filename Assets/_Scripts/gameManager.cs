using System;

using UnityEngine;

public class gameManager : MonoBehaviour
{
    private StartButton _startButtonScript;
    private PlayerController _playerController;

    [SerializeField] private GameObject _playerObject;
    [SerializeField] private GameObject _titleUI;

    private void Start()
    {
        _startButtonScript = GameObject.Find("Start Game Button").GetComponent<StartButton>();
        _playerController = GameObject.Find("PlayerObject").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (_startButtonScript.gameStarted == true)
        {
          
            _titleUI.SetActive(false);

            _playerController.MovePlayer();
        }
    }
}   
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // The GameObjects Scripts.
    private StartButton _startButtonScript;
    private PlayerController _playerController;


    // The player Object.
    [SerializeField] private GameObject _playerObject;
    // UI Objects.
    [SerializeField] private GameObject _titleUI;
    [SerializeField] private GameObject _resetButton;

    // Game score.
    private float _score;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Start()
    {
        // Get the Scripts form the game objects.
        _startButtonScript = GameObject.Find("Start Game Button").GetComponent<StartButton>();
        _playerController = GameObject.Find("PlayerObject").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (_startButtonScript.gameStarted == true)
        {
            _playerObject.GetComponent<Renderer>().enabled = true;

            _resetButton.SetActive(true);
            _titleUI.SetActive(false);

            _playerController.MovePlayer();

            AddToScore(0);
        }
    }

    public void AddToScore(float points)
    {
        _score += points;
        _scoreText.text = "Score: " + _score;
    }
}
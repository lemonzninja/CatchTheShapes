using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public bool gameStarted;

    private Button _button;

    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(StartGame);
    }
    

    private void StartGame()
    {
        gameStarted = true;
    }
}

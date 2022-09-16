using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
       _button.onClick.AddListener(Reset);
    }

    private void Reset()
    {
        SceneManager.LoadScene(0);

        Debug.Log("Reset");
    }
}

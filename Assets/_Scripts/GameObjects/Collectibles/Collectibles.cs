using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private float offScreenToDestroySpot;
    [SerializeField] public int pointsValue;

    private gameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<gameManager>();
    }

    private void Update()
    {
        // Move Down.
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        if (transform.position.y <= offScreenToDestroySpot)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            // TODO: Update score in gameManager.
        }
    }
}

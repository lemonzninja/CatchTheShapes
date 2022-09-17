using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    private StartButton _startButtonScript;



    [SerializeField] private GameObject[] collectibleObjectsArray;

    [SerializeField] private float spawnOnScreenPos;

    private Transform _transform;
    private Vector3 _position;


    private void Start()
    {
        _transform = transform;
        _position = _transform.position;

        _startButtonScript = GameObject.Find("Start Game Button").GetComponent<StartButton>();

        InvokeRepeating(nameof(SpawnCollectibles), 2, 2);
    }

    public void SpawnCollectibles()
    {
       if(_startButtonScript.gameStarted == true)
        {
            // Pick a random object to spawn.
            var randomCollectibles = Random.Range(0, collectibleObjectsArray.Length);
            // pick a random position to spawn.
            var randomXPos = Random.Range(-spawnOnScreenPos, spawnOnScreenPos);
            // set the spawn position to the object.
            var randomPos = new Vector3(randomXPos, _position.y, _position.z);

            // Spawn a random object at the the random spot
            Instantiate(collectibleObjectsArray[randomCollectibles], randomPos, _transform.rotation);
        }

    }

}

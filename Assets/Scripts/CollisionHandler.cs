using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    GameSceneManager gameSceneManager;

    private void Start() 
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "EndGame")
        {
            SceneManager.LoadScene("End");
        }
        else
        {
            gameSceneManager.ReloadLevel();
            Debug.Log("OntriggerEnter");   
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    
}

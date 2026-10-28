using UnityEngine;
using UnityEngine.SceneManagement;

public class Stars : MonoBehaviour
{
    [SerializeField] private string _sceneName = "Victoria"; // Nombre exacto de tu escena de victoria

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}

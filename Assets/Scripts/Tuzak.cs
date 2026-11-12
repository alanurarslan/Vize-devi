using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuzak : MonoBehaviour
{
    [SerializeField] float x = 0;
    [SerializeField] float y = 0;
    [SerializeField] float z = 0;

    void Start()
    {
        transform.Rotate(x, y, z);
    }

    void Update()
    {
        transform.Rotate(x, y, z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        SceneManager.LoadScene(0);
    }
}

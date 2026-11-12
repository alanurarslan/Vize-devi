using UnityEngine;

public class Kutular : MonoBehaviour
{
    [SerializeField] int skorDegeri = 50;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Score puanHesap = FindFirstObjectByType<Score>();
            puanHesap.SkorEkle(skorDegeri);
            Destroy(gameObject);
        }
    }

}

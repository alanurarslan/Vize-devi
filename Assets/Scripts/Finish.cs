using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Finish : MonoBehaviour
{
    public Score scr;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (scr.score >= 50)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene(0);
                print("Kazandınız!");

            }
            else if (scr.score < 50)
            {
                print("puanınız yetersiz");
            }

        }

    }


}



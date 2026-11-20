using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jump = 5f;
    [SerializeField] AudioClip yesilSes;
    [SerializeField] AudioClip kirmiziSes;
    [SerializeField] AudioClip zıplamaSes;
    AudioSource ses;
    
    

    Rigidbody rb;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ses = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            ses.PlayOneShot(zıplamaSes);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float ad = Input.GetAxis("Horizontal");
        float ws = Input.GetAxis("Vertical");
        Vector3 hareket = new Vector3(ad, 0f, ws);
        rb.AddForce(hareket * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KirmiziTop"))
        {
            ses.PlayOneShot(kirmiziSes);
        }
        else if (other.gameObject.CompareTag("YesilTop"))
        {
            ses.PlayOneShot(yesilSes);
        }
    }

}

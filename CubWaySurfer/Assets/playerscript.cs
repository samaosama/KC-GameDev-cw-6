using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{
    public Transform max;
    public Transform min;
    public AudioSource src;
    public float inc;

    void Start()
    {
        src = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x+ inc, min.position.x, max.position.x), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, min.position.x, max.position.x), transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
            src.Play();
            Invoke("Restart", 1f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}

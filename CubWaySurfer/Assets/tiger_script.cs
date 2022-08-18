using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tiger_script : MonoBehaviour
{
    Rigidbody RB;
    public Text ScoreText;
    public int score = 0;
    public int increase = 1;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            score=score+increase;
            ScoreText.text=score.ToString();

        }
    }
    public float speed;
 


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector3(0, 0, speed);
    }


}

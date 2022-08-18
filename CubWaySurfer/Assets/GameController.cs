using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawn;
    public Transform spawn_left;
    public Transform spawn_right;

    public GameObject enemy;
    public int delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void spawnEnemy()
    {
        int randNum = Random.Range(1, 4);
        if (randNum == 1)
        {
            Instantiate(enemy, spawn_left);
        }
        else if(randNum == 2)
        {
            Instantiate(enemy, spawn);

        }
        else if (randNum == 3)
        {
            Instantiate(enemy, spawn_right);

        }
    }
}

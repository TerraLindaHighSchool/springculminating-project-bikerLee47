using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameObject;
    private Transform target;
    private float speed = 0.07f;
    //private float startDelay;
    //private float repeatRate;
    private PlayerController playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            transform.LookAt(target.transform);
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime / speed);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameObject;
    private Transform target;
    private float speed = 0.07f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime / speed);
    }
}

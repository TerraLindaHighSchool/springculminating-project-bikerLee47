using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private GameManager gameManager;
    private float speed = 20.0f;
    private float turnSpeed = 70.0f;
    private float horizontalInput;
    private float forwardInput;
    public bool gameOver = false;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            //This is where we get player input
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
            // We move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            //We turn the vehicle
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        
    }
    
    //slow when not on the road
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            speed = 10.0f;
        }
        else
        {
            speed = 20.0f;
        }

        if (collision.gameObject.CompareTag("Damage"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }

}
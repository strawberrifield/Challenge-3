using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float speed = 12;
    private PlayerControllerX playerControllerXScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerXScript = 
        GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerXScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

            if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            }
        }
    }

    
}
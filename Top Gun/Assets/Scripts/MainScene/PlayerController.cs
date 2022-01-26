using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 150f;
    private float xRange = 180;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            CheckBounds(); // ABSTRACTION
            MovePlayer(); // ABSTRACTION
        }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            // No longer necessary to Instantiate prefabs
            // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            // Get an object object from the pool
            //GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
            //if (pooledProjectile != null)
            //{
                //pooledProjectile.SetActive(true); // activate it
                //pooledProjectile.transform.position = transform.position; // position it at player
            //}
        //}
    }

    private void CheckBounds()
    {
        // Check for left and right bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
    private void MovePlayer()
    {
        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

}

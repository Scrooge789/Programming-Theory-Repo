using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    
    protected float movementSpeed; // ENCAPSULATION
    private float zBound = -50;

    void Update()
    {
        if (GameManager.Instance.isGameActive)
        {
            MoveBackwards();
        }

    }

    public virtual void MoveBackwards()
    {
        transform.Translate(-Vector3.forward * movementSpeed * Time.deltaTime);

        if (transform.position.z < zBound && gameObject.CompareTag("Civilian"))
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.isGameActive = false;
            }
        }
    }


}

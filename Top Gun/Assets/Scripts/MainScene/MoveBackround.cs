using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackround : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPos;
    private float repeatWith;
    private float speed = 300;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWith = GetComponent<BoxCollider>().size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z - repeatWith)
        {
            transform.position = startPos;
        }
        // Stop Movement when GameOver
        if (true)//GameManager.Instance.isGameActive)
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

    }
}

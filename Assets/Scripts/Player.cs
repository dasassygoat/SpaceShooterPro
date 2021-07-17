using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speedzValue = 3.5f;

    [SerializeField]
    private GameObject _laserPrefab;
    
    [SerializeField]
    private float _fireRate = 0.150f;

    private float nextFire = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 startingPosition = new Vector3(0f, 0f, 0f);

        transform.position = startingPosition;

        

    }

        // Update is called once per frame
    void Update()
    {
        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > nextFire)
            {
                
                nextFire = Time.time + _fireRate;
                Instantiate(_laserPrefab, transform.position, Quaternion.identity);
            }
            else
            {
                Debug.Log("too soon");
            }
        }
    }


    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //horizontal move
        transform.Translate(Vector3.right * horizontalInput * _speedzValue * Time.deltaTime);


        //vertical move, I like to see the box move, not the screen
        transform.Translate(Vector3.up * verticalInput * _speedzValue * Time.deltaTime);

        if (transform.position.y > 1)
        {
            transform.position = Vector3.zero;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speedzValue = 3.5f;

    [SerializeField]
    private GameObject _laserPrefab;
    
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
            Debug.Log("Space key pressed");
            Instantiate(_laserPrefab);
        }
    }


    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //horizontal move
        transform.Translate(Vector3.left * horizontalInput * _speedzValue * Time.deltaTime);


        //vertical move, I like to see the box move, not the screen
        transform.Translate(Vector3.down * verticalInput * _speedzValue * Time.deltaTime);

        if (transform.position.y > 1)
        {
            transform.position = Vector3.zero;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 startingPosition = new Vector3(0f, 0f, 0f);

        transform.position = startingPosition;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime);
    }
}
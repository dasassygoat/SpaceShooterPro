using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float _laserSpeed = 8f;

    [SerializeField] private float _laserOffset = 0.8f;
    // Start is called before the first frame update
    void Start()
    {

        transform.Translate(transform.position.x,transform.position.y + _laserOffset,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the laser shot
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);
        DestroyOffScreen();
    }

    private void DestroyOffScreen()
    {
        if (transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
    }
}

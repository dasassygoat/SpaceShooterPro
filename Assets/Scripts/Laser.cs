using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float _laserSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);
        if (transform.position.y > 8f)
        {
            Destroy(this);
            
        }
    }
}

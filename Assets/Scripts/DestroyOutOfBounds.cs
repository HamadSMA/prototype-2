using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperBound;
    public float lowerBound;
    public float sideBound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            // Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            // Debug.Log("Game Over");
            Destroy(gameObject);
        }

    }
}

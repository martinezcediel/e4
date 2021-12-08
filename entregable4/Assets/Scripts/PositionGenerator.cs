using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 Rango;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Rango = RandomPosition();
            transform.position = Rango;
        }
    }

    public Vector3 RandomPosition()
    {
        Vector3 posAleatoria = new Vector3(Random.Range(0, 8), Random.Range(0, 8), Random.Range(0, 8));
        return posAleatoria;
    }
}

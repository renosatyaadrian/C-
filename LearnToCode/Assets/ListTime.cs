using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTime : MonoBehaviour
{

    public GameObject cubePrefab;

    GameObject[] cubes = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
  
        for (int i=0; i<cubes.Length; i++)
        {
            GameObject cube = Instantiate (cubePrefab);
            cubes[i] = cube;
            cube.transform.position = new Vector3(i, cube.transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

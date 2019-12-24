using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGround : MonoBehaviour
{
    public GameObject ground;
    int height = 100;
    int width = 100;

    private void Awake()
    {
        SetGround();
    }

    void SetGround()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Vector3 vec = new Vector3();
                GameObject grounds = Instantiate(ground);
                grounds.transform.position = new Vector3(i, 0, j);
                grounds.transform.parent = this.transform;

            }
        }
    }
}

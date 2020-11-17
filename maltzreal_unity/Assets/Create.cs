using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{

    public GameObject Duplicate;
    void OnMouseDown()
    {
        GameObject Clone = Instantiate(Duplicate);
        Clone.transform.position = new Vector3(3, 3, -2);

    }
}

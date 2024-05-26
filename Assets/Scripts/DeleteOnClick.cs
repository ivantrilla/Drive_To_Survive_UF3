using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnClick : MonoBehaviour
{
    public GameObject GO;

    void OnMouseDown()
    {
        GO.SetActive(false);
        Debug.Log("algo");
    }
}

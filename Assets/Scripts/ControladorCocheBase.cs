﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCocheBase : MonoBehaviour
{
    public GameObject Coche;

    public float AnguloDeGiro;
    public float velocidad;

    void Start()
    {
        Coche = FindObjectOfType<Coche>().gameObject;
    }

    void Update()
    {
        float GiroEnZ = 0;
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * velocidad * Time.deltaTime);

        GiroEnZ = Input.GetAxis("Horizontal") * -AnguloDeGiro;

        Coche.transform.rotation = Quaternion.Euler(0, 0, GiroEnZ);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 posisimouse;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        posisimouse = mainCam.ScreenToWorldPoint(Input.mousePosition);//menerima posisi mouse di layar

        Vector3 rotation = posisimouse - transform.position;

        float rotZ = MathF.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        //wes mboh iki diapakno aku yo ora paham
    }
}

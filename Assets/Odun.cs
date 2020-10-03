using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odun : MonoBehaviour
{
    private float posX, posY = 3, posZ = 5.8f;
    private readonly float rotX = 0, rotY=0, rotZ = 90;
    private float scaleX, scaleY, scaleZ;
    
    public GameObject cylinder;

    public Rigidbody rb;

    public Material mt1 = Resources.Load("BrownTree", typeof(Material)) as Material;
    public Material mt2 = Resources.Load("WhiteTree", typeof(Material)) as Material;

    public Odun(float pX, float sX, float sY)
    {
        posX = pX; scaleX = sX; scaleY = sY;  scaleZ = scaleX;
        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        
        cylinder.transform.position = new Vector3(posX, posY, posZ); //pozisyon y ve z sabit x odunun büyüklüğüne göre max 0.5 ile min -0.5
        cylinder.transform.Rotate(rotX,rotY,rotZ);
        cylinder.transform.localScale = new Vector3(scaleX,scaleY,scaleZ); //scale değerleri max (1,0.6,1) olmalı ve her zaman scaleX=scaleZ!!
        
        rb = cylinder.AddComponent<Rigidbody>();
        rb.useGravity = true;

        if(new System.Random().Next() % 2 == 1)
            cylinder.GetComponent<Renderer>().material = mt1;
        else
            cylinder.GetComponent<Renderer>().material = mt2;
    }
}

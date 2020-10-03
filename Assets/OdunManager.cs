using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdunManager : MonoBehaviour
{
    public Odun od;
    void Start()
    {
        InvokeRepeating("createOdun",0f,5f);
        
    }
    void createOdun()
    {
        od = new Odun(Random.Range(-0.2f, 0.2f), Random.Range(0.1f, 1), Random.Range(0.1f, 0.6f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private readonly float posX = 0.01f, posY, posZ;
    private readonly float rotX = 100;

    public GameObject sphere;

    public Player()
    {
        posY = sphere.GetComponent<Transform>().position.y;
        posZ = sphere.GetComponent<Transform>().position.z;
    }
    void Update()
    {
        //klavye ile sağa sola hareket
        if (Input.GetKey("right") || Input.GetKey("d"))
            sphere.GetComponent<Transform>().Translate(posX,posY,posZ);
        else if (Input.GetKey("left") || Input.GetKey("a"))
            sphere.GetComponent<Transform>().Translate(-posX,posY,posZ);

        sphere.GetComponent<Transform>().Rotate(rotX,0,0);

        //aşağıdaki karışık kısım testereyi belli boundaryler içinde tutmak için 
        sphere.GetComponent<Transform>().position = new Vector3(Mathf.Clamp(sphere.GetComponent<Transform>().position.x,-1f,1f),
                                                                            sphere.GetComponent<Transform>().position.y, //buraya ve alttaki satıra posY ve posZ yazınca çalışmadı nedense
                                                                            sphere.GetComponent<Transform>().position.z);
    }
    public void CutWood()
    {
        
    }
}

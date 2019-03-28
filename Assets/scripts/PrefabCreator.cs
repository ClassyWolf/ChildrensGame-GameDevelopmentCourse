using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    public Transform block1;
    public Transform block2;
    public Transform block3;
    public Transform block4;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;

    public List<Rigidbody2D> blockBodies = new List<Rigidbody2D>();

    public void CreateBlock1()
    {
        Transform blockClone =  Instantiate(block1, spawn1.position, spawn1.rotation);
        blockBodies.Add(blockClone.GetComponent<Rigidbody2D>());
    }

    public void CreateBlock2()
    {
        Transform blockClone = Instantiate(block2, spawn2.position, spawn2.rotation);
        blockBodies.Add(blockClone.GetComponent<Rigidbody2D>());
    }

    public void CreateBlock3()
    {
        Transform blockClone = Instantiate(block3, spawn3.position, spawn3.rotation);
        blockBodies.Add(blockClone.GetComponent<Rigidbody2D>());
    }

    public void CreateBlock4()
    {
        Transform blockClone = Instantiate(block4, spawn4.position, spawn4.rotation);
        blockBodies.Add(blockClone.GetComponent<Rigidbody2D>());
    }
}

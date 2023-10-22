using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject objectShell;
    public int addLife = 10;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name.Equals("Player"))
        {
            var player = other.gameObject.GetComponent<Player>();
            player.LifeUpdate(addLife);
            Destroy(objectShell);
        }
    }

    private void OnDestroy()
    {
        print("Item destroyed");
    }
}

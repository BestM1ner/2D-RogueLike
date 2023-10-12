using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject Character;
    public float minX, minY, maxX, maxY;
    void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(minX, minY), Random.Range(maxX, maxY), 1);
        PhotonNetwork.Instantiate(Character.name, randomPos, Quaternion.identity);
    }
 
}

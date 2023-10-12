using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Character(Clone)");
    }

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(Player.transform.position.x, Player.transform.position.y), Time.deltaTime * 2f);
    }
}

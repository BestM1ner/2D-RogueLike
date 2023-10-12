using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;

    PhotonView view;
    private Rigidbody2D miner;

    private void Start()
    {
        miner = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    void FixedUpdate()
    {
        if(view.IsMine) 
        {
            float moveHor = Input.GetAxis("Horizontal");
            float moveVer = Input.GetAxis("Vertical");

            Vector2 direction = new Vector2(moveHor, moveVer);
            miner.velocity = direction * speed;
        }

    }
}

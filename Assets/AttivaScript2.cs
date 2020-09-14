﻿using UnityEngine;
using System.Collections;

public class AttivaScript2 : MonoBehaviour
{
    private int n_persone;
    bool flagInizio = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.inRoom)
        {
            if (!flagInizio) { n_persone = PhotonNetwork.room.playerCount; flagInizio = true; }
            if (PhotonNetwork.room.playerCount != n_persone) { GetComponent<MovingPlatform2>().enabled = false; n_persone = PhotonNetwork.room.playerCount; }
            else GetComponent<MovingPlatform2>().enabled = true;
        }
    }
}


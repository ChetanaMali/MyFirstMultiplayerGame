using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Photon.Pun;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] GameObject playerPref;
    [SerializeField] float minX, maxX, minY, maxY;

    private void Start()
    {
        // instantiate player at random postion
        PhotonNetwork.Instantiate(playerPref.name, new Vector2(Random.Range(minX,maxX), Random.Range(minY,maxY)), Quaternion.identity);
    }
}

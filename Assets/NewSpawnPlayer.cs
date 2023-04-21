using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NewSpawnPlayer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    [SerializeField] public GameObject PlayerAvatarPrefab;
    [SerializeField] public GameObject spawnArea;
    [SerializeField] public Transform UIPanel;

    void Start()
    {
        float rand = Random.Range(-5.0f, 5.0f);

        Vector3 randomPosition = new Vector3(spawnArea.transform.position.x, spawnArea.transform.position.y + 0.4f, spawnArea.transform.position.z + rand);

        GameObject xrplayer = PhotonNetwork.Instantiate(PlayerAvatarPrefab.name, randomPosition, Quaternion.identity);
        //xrplayer.transform.LookAt(UIPanel.transform);
        //Transform body = xrplayer.transform.Find("body");
        //body.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

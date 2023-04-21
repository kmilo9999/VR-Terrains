using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaterCollision : MonoBehaviourPun
{

    //[SerializeField] TextMeshProUGUI waterQuantityText;
    [SerializeField] Image[] energyPoints;
   
    [SerializeField] GameObject counterObj;

    public int waterQuantity = 0;

    private float energy = 0;
    private float maxEnergy = 6;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //waterQuantityText.text = waterQuantity.ToString();

        for (int i = 0; i < waterQuantity; i++)
        {
            //Debug.Log("waterQuantity");
            //energyPoints[i].gameObject.SetActive( true);
            energyPoints[i].gameObject.GetComponent<ChangeEnergyColor>().ChangeColor();
        }

        if (waterQuantity >= maxEnergy)
        {
            counterObj.GetComponent<TimeCounter>().startCounting = false;
        }
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo != null)
        {
            if (collisionInfo.collider.tag == "waterStone")
            {
                waterQuantity++;
                photonView.RPC("ChangeWaterQuantity", RpcTarget.Others, "jup", "and jup.");
                Destroy(collisionInfo.gameObject);
            }
        }
        

        Debug.Log("Something hit the water machine");
    }

    [PunRPC]
    void ChangeWaterQuantity(string a, string b, PhotonMessageInfo info)
    {
        // the photonView.RPC() call is the same as without the info parameter.
        // the info.Sender is the player who called the RPC.
        //Debug.LogFormat("Info: {0} {1} {2}", info.Sender, info.photonView, info.SentServerTime);
        waterQuantity++;
    }

    private bool DisplayEnergyPoint(int pointNumber)
    {
        return pointNumber < waterQuantity;
    }
}

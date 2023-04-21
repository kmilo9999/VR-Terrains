using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class VRHeadMovement : MonoBehaviourPun
{
    
    [SerializeField]public Transform XROriginHead;
    //private PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        //photonView = GetComponent<PhotonView>();
        XROrigin xrOrigin = FindObjectOfType<XROrigin>();

        XROriginHead = xrOrigin.transform.Find("Camera Offset/Main Camera");

        //XROriginHead  = GameObject.Find("Hand").tr;
    }

    // Update is called once per frame
    void Update()
    {
          if(this.photonView.IsMine )
            {
              
                transform.rotation = XROriginHead.rotation;
                transform.position = XROriginHead.position;
            }
       
    }


}

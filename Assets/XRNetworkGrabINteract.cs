using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class XRNetworkGrabINteract : XRGrabInteractable
{
    private PhotonView m_View;
    // Start is called before the first frame update
    void Start()
    {
        m_View = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        m_View.RequestOwnership();
        base.OnSelectEntered(interactor);
    }
}

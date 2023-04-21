using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResstartItems : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tennisGo;
    public GameObject hammerGo;
    private Vector3 initTennisBallPosition;
    private Vector3 initHammerPosition;
    private Quaternion initTennisBallRotation;
    private Quaternion initHammerRotation;

    void Start()
    {
        initTennisBallPosition = tennisGo.transform.position;
        initHammerPosition = hammerGo.transform.GetChild(0).position;
        initTennisBallRotation = tennisGo.transform.rotation;
        initHammerRotation = hammerGo.transform.GetChild(0).rotation;
        Debug.Log("initHammerPosition "+initHammerPosition);
    }

    public void ResetItemsTrasnform()
    {
        Debug.Log("ACA 1");
        tennisGo.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        tennisGo.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        tennisGo.transform.rotation = initTennisBallRotation;
        tennisGo.transform.position = initTennisBallPosition;
        //tennisGo.transform = initTennisBallTransform;

        //hammerGo.transform.GetChild(0).GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //hammerGo.transform.GetChild(0).GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        hammerGo.transform.GetChild(0).rotation = initHammerRotation;
        Debug.Log("BEFORE " + hammerGo.transform.position);
        hammerGo.transform.GetChild(0).transform.position = initHammerPosition;
        
        Debug.Log("AFTER " + hammerGo.transform.position);

        //hammerGo.transform = initHammerTansform;
        Debug.Log("ACA 2");
    }

    public void PlanetSelection(int index)
    {
        switch (index)
        {
            case 0:
                SceneManager.LoadScene("Earth", LoadSceneMode.Single);
                break;
            case 1:
                SceneManager.LoadScene("Moon1", LoadSceneMode.Single);
                break;
            case 2:
                SceneManager.LoadScene("Venus", LoadSceneMode.Single);
                break;
            case 3:
                SceneManager.LoadScene("Mars", LoadSceneMode.Single);
                break;
        }
    }
}

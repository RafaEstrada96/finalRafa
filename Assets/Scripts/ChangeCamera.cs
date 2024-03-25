using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject thirdCamera;
    public GameObject firstCamera;
    public int camMode;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera")){
            if (camMode == 1){
                camMode = 0;
            } else {
                camMode += 1;
            }
            StartCoroutine(CamChange());
        }
    }

    IEnumerator CamChange(){
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0){
            thirdCamera.SetActive(true);
            firstCamera.SetActive(false);
        }
        if (camMode == 1){
            thirdCamera.SetActive(false);
            firstCamera.SetActive(true);
        }
    }
}

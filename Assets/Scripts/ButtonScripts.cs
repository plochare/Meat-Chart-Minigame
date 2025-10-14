using UnityEngine;
using DG.Tweening;

public class ButtonScripts : MonoBehaviour
{
    public GameObject CameraObj;
    public GameObject StartButtonObj;

    public void StartGame(){
        // Hide Button
        StartButtonObj.SetActive(false);
        // TWeen Move Camera
        CameraObj.transform.DOMove(new Vector3(1.9f, 3.3f ,10.5f), 1.5f)
        .SetEase(Ease.OutQuad);
        CameraObj.transform.DORotate(new Vector3(90,90,0), 1.5f);
    }

}

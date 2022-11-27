using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class twingkle : MonoBehaviour
{
    public Image arrow2;
    public GameObject toastPanal;
    public IEnumerator EMarkerGrid()
    {
        int count = 0;
        this.gameObject.SetActive(true);

        while (Input.GetMouseButtonDown(0))
        {
            this.arrow2.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            this.arrow2.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            count++;
        }
    }

}

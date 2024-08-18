using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addPlayer : MonoBehaviour
{


    public GameObject panelPrefab;   
    public Canvas canvas;
    // Start is called before the first frame update
   
    public void createPlayerPanel()
    {
        GameObject newPanel = Instantiate(panelPrefab);

        newPanel.transform.SetParent(canvas.transform, false); // 'false' keeps the local scale and position



        RectTransform rectTransform = newPanel.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(100, 100);

    }
}

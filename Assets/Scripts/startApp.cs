using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    using UnityEngine.SceneManagement;

public class startApp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach (Touch touch in Input.touches)
        {

            if (touch.fingerId == 0)

            {
                SceneManager.LoadSceneAsync(1);

            }
        }
    }
}

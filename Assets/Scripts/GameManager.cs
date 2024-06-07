using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SceneManagerクラスを呼び出すのに必要
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0)
        {
            SceneManager.LoadScene("Clear");
        }    
    }

}

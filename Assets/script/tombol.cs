using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        
    }

    public void scale(float scale)
    {
        transform.localScale = new Vector3(1 / scale, 1 * scale, 1);
    }

    public void scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    void Update()
    {
        
    }
}
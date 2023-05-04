using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
   public void btn_change_scene(string scene_name)
    {
        //SceneManager.LoadScene(scene_name);
        Debug.Log("Open next scene");
    }


    public void CustomOnPressed()
    {
        Debug.LogError("I got pressed!");
    }
}

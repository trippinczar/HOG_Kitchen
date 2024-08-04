using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidSceneController : MonoBehaviour
{
    public void Continue()
    {
        AudioManager.Instance.PlaySFX("Click");
        Debug.Log("button pressed");
        SceneManager.LoadScene("Level1");
    }
}

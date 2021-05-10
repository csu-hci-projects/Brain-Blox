using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Level01":
                SceneManager.LoadScene("Scene02");
                break;
            case "Level02":
                SceneManager.LoadScene("Tetris Cube");
                break;
        }

    }
}

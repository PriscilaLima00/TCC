using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMainMenu", 10f);
    }

    private void LoadMainMenu()
    {
        GameManager.Instance.LoadMainMenu();
    }
}

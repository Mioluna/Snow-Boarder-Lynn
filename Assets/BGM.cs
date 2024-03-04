using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject); // Destroy duplicate AudioManager
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Keep this GameObject when loading new scenes
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Options;
    public void AppearOptions()
    {
        Options.SetActive(true);
        Time.timeScale = 0;
    }
    public void DissapearOptions()
    {
        Options.SetActive(false);
        Time.timeScale = 1;
    }
}

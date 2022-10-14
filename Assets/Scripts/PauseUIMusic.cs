using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUIMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MusicBackground.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bgm : MonoBehaviour
{
    
    public AudioClip[] audioGroup;

    
    private int playingIndex;

   
    private bool canPlayAudio;

    
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();

        canPlayAudio = true;

        playingIndex = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (canPlayAudio)
        {
            PlayAudio();

            canPlayAudio = false;
        }

        if (!audioSource.isPlaying)
        {
            playingIndex++;

            if (playingIndex >= audioGroup.Length)
            {
                playingIndex = 0;
            }

            canPlayAudio = true;
        }
    }
    private void PlayAudio()
    {
        audioSource.clip = audioGroup[playingIndex];
        audioSource.Play();
    }


}

using UnityEngine;
using UnityEngine.UI;

public class SesKontrol : MonoBehaviour
{
    private AudioSource sesKaynagi;

    void Start()
    {
        sesKaynagi = GetComponent<AudioSource>();
    }

    public void SesAcKapa()
    {
        if (sesKaynagi.isPlaying)
        {
            sesKaynagi.Pause(); 
        }
        else
        {
            sesKaynagi.Play();
        }
    }

    void OnDisable()
    {
        if (sesKaynagi != null)
        {
            sesKaynagi.Stop();
        }
    }
}
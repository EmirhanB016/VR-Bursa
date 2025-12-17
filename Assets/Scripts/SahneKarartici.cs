using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
using System.Collections; 

public class SahneKarartici : MonoBehaviour
{
    public Image siyahPerdeResmi; 
    public float gecisSuresi = 1.0f; 

    void Start()
    {
        if (siyahPerdeResmi != null)
        {
             StartCoroutine(Aydinlan());
        }
    }

    public void KarartVeGit(string sahneAdi)
    {
        StartCoroutine(KararVeYukle(sahneAdi));
    }

    IEnumerator Aydinlan()
    {
        float gecenSure = 0f;
        Color anlikRenk = siyahPerdeResmi.color;
        while (gecenSure < gecisSuresi)
        {
            gecenSure += Time.deltaTime;
            anlikRenk.a = Mathf.Lerp(1f, 0f, gecenSure / gecisSuresi);
            siyahPerdeResmi.color = anlikRenk;
            yield return null; // Bir sonraki kareyi bekle
        }
         anlikRenk.a = 0f;
         siyahPerdeResmi.color = anlikRenk;
         siyahPerdeResmi.raycastTarget = false; 
    }

    IEnumerator KararVeYukle(string sahneAdi)
    {
        siyahPerdeResmi.raycastTarget = true;
        float gecenSure = 0f;
        Color anlikRenk = siyahPerdeResmi.color;
        while (gecenSure < gecisSuresi)
        {
            gecenSure += Time.deltaTime;
            anlikRenk.a = Mathf.Lerp(0f, 1f, gecenSure / gecisSuresi);
            siyahPerdeResmi.color = anlikRenk;
            yield return null;
        }
        anlikRenk.a = 1f;
        siyahPerdeResmi.color = anlikRenk;
        
        SceneManager.LoadScene(sahneAdi);
    }
}
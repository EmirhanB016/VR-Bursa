using UnityEngine;
using UnityEngine.UI; // UI elementlerini (Image) kullanmak için gerekli

public class IkonRenk : MonoBehaviour
{
    public Image daireResmi; // Renk değiştireceğimiz resim
    public Color normalRenk = Color.cyan; // Normalde ne renk olsun? (Mavi tonu)
    public Color parlamaRenki = Color.yellow; // Lazer değince ne renk olsun?

    // Lazer değince bunu çalıştıracağız
    public void Parla()
    {
        if (daireResmi != null)
            daireResmi.color = parlamaRenki;
    }

    // Lazer gidince bunu çalıştıracağız
    public void Sonur()
    {
        if (daireResmi != null)
            daireResmi.color = normalRenk;
    }
}
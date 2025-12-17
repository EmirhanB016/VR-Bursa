using UnityEngine;
using UnityEngine.UI;

public class IkonRenk : MonoBehaviour
{
    public Image daireResmi;
    public Color normalRenk = Color.cyan;
    public Color parlamaRenki = Color.yellow;

    public void Parla()
    {
        if (daireResmi != null)
            daireResmi.color = parlamaRenki;
    }

    public void Sonur()
    {
        if (daireResmi != null)
            daireResmi.color = normalRenk;
    }
}
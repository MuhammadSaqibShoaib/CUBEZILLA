using UnityEngine.Audio;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public void OnHoverBTN()
    {
        FindObjectOfType<AudioManager>().PlaySound("OnHover");
    }
    public void OnClickBTN()
    {
        FindObjectOfType<AudioManager>().PlaySound("OnClick");
    }
}

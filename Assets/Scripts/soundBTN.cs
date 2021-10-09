using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class soundBTN : MonoBehaviour
{
    
    public  Toggle tg;

    private void Awake()
    {
        tg.isOn = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = tg.isOn;
    }

    public void OnMutePressed()
    {
        
        AudioListener.pause = tg.isOn;
        PlayerPrefs.SetInt("MUTED", tg.isOn ? 1 : 0);
    }
    
}

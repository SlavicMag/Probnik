using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator AnimCanvas;

    public void FadeIn()
    {
        AnimCanvas.SetBool("fade", true);
    }

    public void FadeOut()
    {
        AnimCanvas.SetBool("fade", false);
    }
}

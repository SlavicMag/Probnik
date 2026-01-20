using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator anim_canvas;

    public void FadeIn()
    {
        anim_canvas.SetBool("fade", true);
    }

    public void FadeOut()
    {
        anim_canvas.SetBool("fade", false);
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RawImageAnimator : MonoBehaviour
{
    public RawImage rawImage;
    public Texture[] frames;
    public float frameRate = 10f;

    private int index = 0;
    private bool isPlaying = false;
    private Coroutine animCoroutine;

    void Start()
    {
        // ✅ 不要在 Start() 里启动动画！
        // 什么都不写，让动画一开始是静止的。
    }

    public void PlayAnimation()
    {
        if (isPlaying) return;

        isPlaying = true;
        animCoroutine = StartCoroutine(Animate());
    }

    public void StopAnimation()
    {
        if (!isPlaying) return;

        isPlaying = false;
        if (animCoroutine != null)
        {
            StopCoroutine(animCoroutine);
        }
    }

    IEnumerator Animate()
    {
        while (isPlaying)
        {
            rawImage.texture = frames[index];
            index = (index + 1) % frames.Length;
            yield return new WaitForSeconds(1f / frameRate);
        }
    }
}

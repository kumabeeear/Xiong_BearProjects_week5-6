using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public RawImageAnimator[] animators; // 所有 RawImage 动画脚本

    public void OnButtonClicked()
    {
        foreach (var anim in animators)
        {
            anim.PlayAnimation(); // 让每个 RawImage 开始播放
        }
    }
}

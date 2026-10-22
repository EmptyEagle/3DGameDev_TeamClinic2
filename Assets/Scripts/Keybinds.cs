using JetBrains.Annotations;
using UnityEngine;

public class Keybinds : MonoBehaviour
{
    public AnimationTriggers animationTriggers;
    [SerializeField] KeyCode keyForward;
    [SerializeField] KeyCode keyBack;
    [SerializeField] KeyCode keyLeft;
    [SerializeField] KeyCode keyRight;
    [SerializeField] KeyCode keyBlock;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyForward) || Input.GetKeyDown(keyBack) || Input.GetKeyDown(keyLeft) || Input.GetKeyDown(keyRight))
        {
            animationTriggers.StartWalking();
        }
        else if (Input.GetKeyUp(keyForward) || Input.GetKeyUp(keyBack) || Input.GetKeyUp(keyLeft) || Input.GetKeyUp(keyRight))
        {
            animationTriggers.StopWalking();
        }
        if (Input.GetKeyDown(keyBlock))
        {
            animationTriggers.TriggerBlock();
        }
    }
}

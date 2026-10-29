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
    [SerializeField] KeyCode keyRun;
    //[SerializeField] KeyCode keyAttack;

    // Update is called once per frame
    void Update()
    {
        // WALK
        if (Input.GetKey(keyForward) || Input.GetKey(keyBack) || Input.GetKey(keyLeft) || Input.GetKey(keyRight))
        {
            animationTriggers.StartWalking();
        }
        else if (!(Input.GetKey(keyForward) || Input.GetKey(keyBack) || Input.GetKey(keyLeft) || Input.GetKey(keyRight))) 
        {
            animationTriggers.StopWalking();
        }

        // RUN
        if (Input.GetKeyDown(keyRun))
        {
            animationTriggers.StartRunning();
        }
        else if (Input.GetKeyUp(keyRun))
        {
            animationTriggers.StopRunning();
        }

        // BLOCK
        if (Input.GetKeyDown(keyBlock))
        {
            animationTriggers.TriggerBlock();
        }

        // ATTACK
        if (Input.GetMouseButtonDown(0))
        {
            animationTriggers.TriggerAttack();
        }
    }
}

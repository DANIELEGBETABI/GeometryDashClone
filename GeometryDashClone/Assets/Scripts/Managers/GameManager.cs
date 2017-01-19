using UnityEngine;
using System.Collections;
[RequireComponent(typeof(InputController),typeof(ResourceManager))]
public class GameManager : MonoBehaviour {

    public InputController      inputManager;
    public ResourceManager      resourseManager;
    public PlayerController     player;
    public SegmentController    segmentController;
   

    void Awake()
    {
        resourseManager = (resourseManager == null) ? FindObjectOfType<ResourceManager>() : resourseManager;
        if (resourseManager == null)
        {
            print("Resource manager is null");
        }
       
        inputManager = (inputManager == null) ? FindObjectOfType<InputController>() : inputManager;
        if (inputManager == null)
        {
            print("Input manager is null");
        }
    }

    void Start() {
        AddNextSegment();
        inputManager.AddJumpObserver(player.Jump);
        player.OnPlayerDeath += PlayerDeath;
	}

    private void PlayerDeath()
    {
        player.gameObject.SetActive(false);
    }

    public void AddNextSegment()
    {
        GameObject segment = resourseManager.GetSegment();
        if (segment!=null)
        {
            SegmentController tmpSegmentController;
            tmpSegmentController = segment.GetComponentInChildren<SegmentController>();
            tmpSegmentController.OnExitSegmentBegin += AddNextSegment;
            tmpSegmentController.OnExitSegmentEnd   += RemoveSegment;
        }
    }

    private void RemoveSegment(SegmentController segment)
    {
        segment.OnExitSegmentBegin  -= AddNextSegment;
        segment.OnExitSegmentEnd    -= RemoveSegment;
        resourseManager.RemoveSegment(segment);
    }
}

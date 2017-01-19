using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    private Transform player;
    public ResourceManager resourseManager;
    public GameManager gameManager;
    [Range(0,100)]
    public float offset = 5;

    void Start()
    {
        player = gameManager.player.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, -offset);
    }
}

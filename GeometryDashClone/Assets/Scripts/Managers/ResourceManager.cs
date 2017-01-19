using UnityEngine;
using System.Collections;
[RequireComponent(typeof(GameManager))]
public class ResourceManager : MonoBehaviour {

    public  GameObject[]        segments; 
    public  GameObject          playerPrefab;
    public  PlayerController    player;
    public  GameManager         gameManager;
    private Vector3             position;
    private int                 count = 0;
    private float               Distance;

    void Awake()
    {
        PlayerController player = Instantiate(playerPrefab).GetComponent<PlayerController>();
        gameManager.player = player;
        Distance = segments[0].transform.Find("Segment/Ground").localScale.x;
        position = segments[0].transform.position - Vector3.right * Distance;
    }

    public GameObject GetSegment()
    {
        if (count<segments.Length)
        {
            Vector3 direction = (count == 0) ? new Vector3(0, 0, 0) : Vector3.right;
            GameObject segment = (GameObject)Instantiate(segments[count], position + direction * Distance, Quaternion.identity);
            position = segment.transform.position;
            ++count;
            return segment;    
        }
        return null;
    }

    public void RemoveSegment(SegmentController segment)
    {
        Destroy(segment.transform.parent.gameObject);
    }
}

using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject AmongusPrefab;
    public int spawn_amount = 5;

    public void Start()
    {
        spawnAmogus();
    }
    void spawnAmogus()
    {
        for (int i = 0; i < spawn_amount; i++)
        {
            Instantiate(AmongusPrefab, transform.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnAmogus();
        }
    }
}

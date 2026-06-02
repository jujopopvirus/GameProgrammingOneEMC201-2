using UnityEngine;

public class StartRandomPrefab : MonoBehaviour
{
    public GameObject leg01;
    public GameObject leg02;

    private SpriteRenderer spriteRenderer;
    private SpriteRenderer leg01Renderer;
    private SpriteRenderer leg02Renderer;

    public AudioClip[] amongusAudio;
    private AudioSource AMONGUS;

    private Color assigned_color;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        AMONGUS = GetComponent<AudioSource>();

        leg01Renderer = leg01.GetComponent<SpriteRenderer>();
        leg02Renderer = leg02.GetComponent<SpriteRenderer>();
        amongus();


        randomizedColor();
        randomizedTransform();

    }

    void randomizedColor()
    {
        assigned_color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        spriteRenderer.color = assigned_color;
        leg01Renderer.color = assigned_color;
        leg02Renderer.color = assigned_color;
    }

    void randomizedTransform()
    {
        int randomRot = Random.Range(-50, 50);
        transform.Rotate(0, 0, randomRot);
    
        int randomPos = Random.Range(-10, 10);
        transform.position += new Vector3(randomPos, 0, 0);
    }

    void amongus()
    {
        if (amongusAudio == null || amongusAudio.Length == 0) ;

        int randIndex = Random.Range(0, amongusAudio.Length);

        AMONGUS.PlayOneShot(amongusAudio[randIndex]);
        
    }

}

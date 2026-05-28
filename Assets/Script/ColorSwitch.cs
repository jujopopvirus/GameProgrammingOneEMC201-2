using UnityEngine;
using UnityEngine.InputSystem;

public enum spriteColor 
{
    black,
    white,
    defaultcolor
}

public class ColorSwitching : MonoBehaviour
{

    private SpriteRenderer visualRender;
    private Transform transform;
    [SerializeField] private Color DefaultColor;
    public string[] colorLevel = {"black", "white", "default"};



    private void Start()
    {
        visualRender = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
    }

    public int Colorlevel = 0;


    void Update()
    {
        SwitchColor();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Colorlevel < colorLevel.Length - 1)
            {
                Colorlevel += 1;
            }
            else
            {
                Colorlevel = 0;
            }

            Debug.Log(Colorlevel);

            changeColorbyLevel(Colorlevel);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            changeColorbyLevel(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            changeColorbyLevel(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            changeColorbyLevel(2);
        }

    }

    public spriteColor color;

    public void changeColorbyLevel(int level = 0)
    {
        switch (colorLevel[level])
        {
            case "default":
                color = spriteColor.defaultcolor;
                break;
            case "black":
                color = spriteColor.black;
                break;
            case "white":
                color = spriteColor.white;
                break;
            default:
                color = spriteColor.defaultcolor;
                break;
        }
    }

    public void SwitchColor()
    {
        switch (color)
        {
            case spriteColor.black:
                visualRender.color = Color.black;
                transform.Rotate(0, 1, 0);
                break;
            case spriteColor.white:
                visualRender.color = Color.white;
                transform.Rotate(0, 0, 1);
                break;
            default:
                visualRender.color = DefaultColor;
                transform.Rotate(0, 0, 0);
                break;

        }
    }
}


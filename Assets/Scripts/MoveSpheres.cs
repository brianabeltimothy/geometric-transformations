using UnityEngine;

public class MoveSpheres : MonoBehaviour
{
    public GameObject[] spheres;
    public float movementRange = 7.0f;
    private int xDirection = 1;
    private int yDirection = 1;
    private int diagXDir = 1;
    private int diagYDir = 1;
    private int diagXDir2 = -1;
    private int diagYDir2 = 1;

    void FixedUpdate()
    {
        MoveSpheresHorizontal(spheres[0]);
        MoveSpheresVertical(spheres[1]);
        MoveSpheresDiagonal(spheres[2]);
        MoveSpheresDiagonal2(spheres[3]);
    }

    void MoveSpheresHorizontal(GameObject sphere)
    {
        float moveX = sphere.transform.position.x + (10f * xDirection * Time.deltaTime);

        if (moveX > movementRange || moveX < -movementRange)
        {
            xDirection *= -1;
        }

        sphere.transform.position = new Vector3(moveX, sphere.transform.position.y, sphere.transform.position.z);
    }

    void MoveSpheresVertical (GameObject sphere)
    {
        float moveY = sphere.transform.position.y + (9f * yDirection * Time.deltaTime);

        if(moveY > movementRange || moveY < -movementRange)
        {
            yDirection *= -1;
        }

        sphere.transform.position = new Vector3(sphere.transform.position.x, moveY, sphere.transform.position.z);
    }

    void MoveSpheresDiagonal(GameObject sphere)
    {
        float moveX = sphere.transform.position.x + (8f * diagXDir * Time.deltaTime);
        float moveY = sphere.transform.position.y + (8f * diagYDir * Time.deltaTime);

        if(moveX > movementRange || moveX < -movementRange)
        {
            diagXDir *= -1;
        }

        if (moveY > movementRange || moveY < -movementRange)
        {
            diagYDir *= -1;
        }

        sphere.transform.position = new Vector3(moveX, moveY, sphere.transform.position.z);
    }
    void MoveSpheresDiagonal2(GameObject sphere)
    {
        float moveX = sphere.transform.position.x + (7f * diagXDir2 * Time.deltaTime);
        float moveY = sphere.transform.position.y + (7f * diagYDir2 * Time.deltaTime);

        if(moveX > movementRange || moveX < -movementRange)
        {
            diagXDir2 *= -1;
        }

        if (moveY > movementRange || moveY < -movementRange)
        {
            diagYDir2 *= -1;
        }

        sphere.transform.position = new Vector3(moveX, moveY, sphere.transform.position.z);
    }
}

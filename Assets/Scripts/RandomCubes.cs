using UnityEngine;

public class RandomCubes : MonoBehaviour
{
    //Checks
    int i;
    //gameobject
    public GameObject[] Cubes;
    public GameObject Large, Medium, Small;
    float delay = 3f,
            timer = 0f;
            
    void Update()
    {
        //Checking
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 1.5f, Random.Range(-10, 11));
        //     Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        //     //Ok done sa check
        // }
        if (Time.time > timer)
        {
            SpawnCubes();
            timer = Time.time + delay;
        }

    }

    void SpawnCubes()
    {
        for (i = 0; i < 3; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 1.5f, Random.Range(-10, 11));
            //rotation transform
            transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 90), 0));

            timer += Time.deltaTime;
            //range of the array, Cube Spawning
            int Array = Random.Range(0, 2),
                CubeRotation = Random.Range(80, 90);
            if (timer >= 3f)
            {
                Instantiate(Cubes[Array], randomSpawnPosition, transform.rotation);
                timer = 0f;
            }
            //Note to self; Too random I need to make the Maze more specific
        }
    }
}

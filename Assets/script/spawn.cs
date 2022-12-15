using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] sampah;
    public float spawanrate;
    [SerializeField] private float SpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SampahSpawn());
    }

    private IEnumerator SampahSpawn(){
        while(true){
            var wanted = Random.Range(SpawnPosition, SpawnPosition);
            var position = new Vector3(transform.position.x, wanted);
            GameObject gameObject = Instantiate(sampah[Random.Range(0,sampah.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(spawanrate);
            Destroy(gameObject, 20f);
        }
    }
}

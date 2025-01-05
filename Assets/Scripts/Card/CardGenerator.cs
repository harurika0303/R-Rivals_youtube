using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardPrefab;

    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        Instantiate(cardPrefab);
    }
}

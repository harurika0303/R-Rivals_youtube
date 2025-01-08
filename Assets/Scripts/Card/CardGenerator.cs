using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardPrefab;

    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Spawn(i);
        }
    }

    public void Spawn(int number)
    {
        Card card = Instantiate(cardPrefab);
        card.Set(cardBases[number]);
    }
}

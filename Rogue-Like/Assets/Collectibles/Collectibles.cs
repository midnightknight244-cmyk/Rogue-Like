using UnityEngine;

[CreateAssetMenu(fileName = "Collectibles", menuName = "ScriptableObjects/CollectiblesScriptableObject", order = 4)]
public class Collectibles : ScriptableObject
{
    public LevelStats levelStats;

    public GameObject prefabCoinRegular;
    public GameObject prefabCoinRed;
    public GameObject prefabCoinBlue;
    public GameObject prefabHourglass;

    public bool isRewardGenerated;
    public int whichCoin;
    public int whichHourglass;
    public int totalCollectiblesTypes; //each type of collectibles - NOT THE AMOUNT THAT THE PLAYER HAS ON HAND!!!

    public void ResetValues()
    {
        whichCoin = 100;
        isRewardGenerated = false;
        whichHourglass = 100;
        totalCollectiblesTypes = 2;
    }

    public void GenerateCoin()
    {
        whichCoin = 0;//CHANGE TO RANDOM.RANGE

        if (whichCoin == 0)
        {
            GameObject newCoin = Instantiate(prefabCoinRegular);
        }
        else if (whichCoin == 1)
        {
            GameObject newCoin = Instantiate(prefabCoinRed);
        }
        else if (whichCoin == 2)
        {
            GameObject newCoin = Instantiate(prefabCoinBlue);
        }

        isRewardGenerated = true;
        whichCoin = 100;
    }

    public void GenerateHourglass()
    {
        whichHourglass = 0; //CHANGE TO RANDOM.RANGE IF THERE IS OTHER HOURGLASSES

        if (whichHourglass == 0)
        {
            GameObject newHourglass = Instantiate(prefabHourglass);
        }

        isRewardGenerated = true;
        whichHourglass = 100;
    }
}

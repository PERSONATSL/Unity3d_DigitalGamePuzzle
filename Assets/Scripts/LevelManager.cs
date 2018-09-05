using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    //单例模式
    #region single instance

    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }

    void Awake()
    {
        instance = this;
    }

    #endregion

    public Transform emptyPointTransform;//记录一开始的空位置的坐标
    [HideInInspector]//在面板上隐藏掉这个公共变量
    public Vector3 empty;//方块移动时存储的空位置的坐标
    public GameObject[] pieces;//存储各个方块
    private Vector3[] piecePositions;//存储各个方块的位置,用作判断是否完成游戏
    private bool isSwaped;//记录是否调用SwapPiece()方法,用作判断是否完成游戏

    public static int steps;//移动步数
    public int time;//用时
    private float timer;

    public Text textOfSteps,textOfTime;

    public GameObject successTip;
    public Text successTips;

    public string levelName;

    public HighScore hs;
    void Start()
    {
        
        successTip.SetActive(false);
        empty = emptyPointTransform.position;         //初始化empty,piecePositions的值s
        piecePositions = new Vector3[pieces.Length];
        for (int i = 0; i < pieces.Length; i++)
        {
            piecePositions[i] = pieces[i].transform.position;
        }
        SwapPiece();

    }


    void Update()
    {
        timer += Time.deltaTime;
        time = (int)timer;
        textOfTime.text = "Time：" + time.ToString() + " s";
        textOfSteps.text = "Steps: " + steps.ToString();
    }


    public void SwapPiece()//打乱方块的方法
    {
        if(levelName == "1")
        {
            int[] step = { -1, 1, -3, 3 };
            int emptyIndex = pieces.Length - 1;//空白方块的索引
            int i = 0;
            while (i < 300)//随机点击各个方块,每点击一次就交换了一次方块
            {
                var index = emptyIndex + step[Random.Range(0, 4)];
                if (index < 8 && index >= 0)
                {
                    pieces[index].GetComponent<Block_3>().OnMouseDown();
                    i++;
                }
                emptyIndex = index;
            }
            isSwaped = true;
            steps = 0;
            timer = 0;
            successTip.SetActive(false);
        }
        if(levelName == "2")
        {
            int[] step = { -1, 1, -4, 4 };
            int emptyIndex = pieces.Length - 1;//空白方块的索引
            int i = 0;
            while (i < 500)//随机点击各个方块,每点击一次就交换了一次方块
            {
                var index = emptyIndex + step[Random.Range(0, 4)];
                if (index < 15 && index >= 0)
                {
                    pieces[index].GetComponent<Block_4>().OnMouseDown();
                    i++;
                }
                emptyIndex = index;
            }
            isSwaped = true;
            steps = 0;
            timer = 0;
            successTip.SetActive(false);
        }
        if (levelName == "3")
        {
            int[] step = { -1, 1, -5, 5 };
            int emptyIndex = pieces.Length - 1;//空白方块的索引
            int i = 0;
            while (i < 800)//随机点击各个方块,每点击一次就交换了一次方块
            {
                var index = emptyIndex + step[Random.Range(0, 4)];
                if (index < 24 && index >= 0)
                {
                    pieces[index].GetComponent<Block_5>().OnMouseDown();
                    i++;
                }
                emptyIndex = index;
            }
            isSwaped = true;
            steps = 0;
            timer = 0;
            successTip.SetActive(false);
        }

    }
    public void SwapEmpty(Vector3 targer)//主要是判断游戏结果
    {
        empty = targer;
        if (emptyPointTransform.position == empty)
        {
            bool isWin = true;
            for (int i = 0; i < pieces.Length; i++)
            {
                if (pieces[i].transform.position != piecePositions[i])
                {
                    isWin = false;
                    break;
                }
            }
            if (isWin && isSwaped)
            {
                successTip.SetActive(true);
                successTips.text = "SUCCESS!" + "\n" + "\n" + "\n" + "Time：" + time +" s";
                if (levelName == "1")
                {
                    hs.RollHighScore1(time);
                }
                if (levelName == "2")
                {
                    hs.RollHighScore2(time);
                }
                if (levelName == "3")
                {
                    hs.RollHighScore3(time);
                }
                isSwaped = false;
            }
        }
    }
}

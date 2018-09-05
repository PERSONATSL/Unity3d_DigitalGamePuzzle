using UnityEngine;
using System.Collections;

public class Block_3 : MonoBehaviour
{
    public void OnMouseDown()
    {
        //判断与空方块的距离,如果不是与空方块相邻的物体这不能交换
        if (Vector3.Distance(transform.position, LevelManager.Instance.empty) <= 11f)
        {
            var temp = transform.position;
            transform.position = LevelManager.Instance.empty;//交换位置
            LevelManager.steps++;
            LevelManager.Instance.SwapEmpty(temp);//每次交换都需要根据空方块的位置,进行判定是否已经完成游戏
        }
    }

}

using UnityEngine;
using System.Collections;

public class LoadPuzzleGame : MonoBehaviour
{

    [SerializeField]
    private GameObject puzzleLevelSelectPanel;

    [SerializeField]
    private Animator puzzleLevelSelectAnim;

    [SerializeField] private GameObject 
        puzzleGamePanel,
        puzzleGamepanel2,
        puzzleGamepanel3,
        puzzleGamepanel4,
        puzzleGamepanel5;

    [SerializeField] private Animator puzzleGamePanelAnim1,
        puzzleGamePanelAnim2,
        puzzleGamePanelAnim3,
        puzzleGamePanelAnim4,
        puzzleGamePanelAnim5;

    public void LoadPuzzle(int level, string puzzle)
    {
        
    }
}

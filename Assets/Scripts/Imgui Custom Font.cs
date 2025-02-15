using ImGuiNET;
using UnityEngine;

public class ImguiCustomFont : MonoBehaviour
{
#region Private Variables

    private readonly string fontPath = $"{Application.streamingAssetsPath}/NotoSansTC-Regular.otf";

#endregion

#region Public Methods

    public void AddChineseFont(ImGuiIOPtr io)
    {
        io.Fonts.AddFontFromFileTTF(fontPath , 20 , null , io.Fonts.GetGlyphRangesChineseFull());
    }

#endregion
}

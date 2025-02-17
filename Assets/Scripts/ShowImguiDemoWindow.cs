using UImGui;
using UnityEngine;

public class ShowImguiDemoWindow : MonoBehaviour
{
    private void OnEnable()
    {
        UImGuiUtility.Layout += OnLayout;
    }

    private void OnDisable()
    {
        UImGuiUtility.Layout -= OnLayout;
    }

    private void OnLayout(UImGui.UImGui uImGui)
    {
        //顯示Demo視窗
        ImGuiNET.ImGui.ShowDemoWindow();
    }
}
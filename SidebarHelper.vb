Imports System.Drawing
Imports System.Windows.Forms

Public Class SidebarHelper

    ' Sidebar configuration
    Public Const SidebarWidth As Integer = 280
    Public Const HideX As Integer = -280
    Public Const ShowX As Integer = 0

    ' Color configuration
    Public Shared ReadOnly Color_Normal_White As Color = Color.White
    Public Shared ReadOnly Color_Hover_Gold As Color =
        Color.FromArgb(212, 175, 55)

    ' Initialize Sidebar
    Public Shared Sub InitializeSidebar(
        frm As Form,
        panelSidebar As Panel,
        panelHeader As Panel,
        timerSidebar As Timer)

        If panelSidebar Is Nothing OrElse panelHeader Is Nothing Then
            Return
        End If

        ' Make sure Sidebar belongs to the Form
        If Not frm.Controls.Contains(panelSidebar) Then
            frm.Controls.Add(panelSidebar)
        End If

        ' Set Sidebar size
        panelSidebar.Size = New Size(
            SidebarWidth,
            frm.ClientSize.Height - panelHeader.Height)

        ' Start hidden
        panelSidebar.Location =
            New Point(HideX, panelHeader.Height)
        panelSidebar.GetType().InvokeMember(
    "DoubleBuffered",
    Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.SetProperty,
    Nothing,
    panelSidebar,
    New Object() {True}
)
        panelSidebar.BringToFront()

        ' Animation speed
        If timerSidebar IsNot Nothing Then
            timerSidebar.Interval = 10
        End If

    End Sub

    ' Resize Sidebar
    Public Shared Sub ResizeSidebar(
    frm As Form,
    panelSidebar As Panel,
    panelHeader As Panel)

        If panelSidebar Is Nothing OrElse panelHeader Is Nothing Then
            Return
        End If

        panelSidebar.Top = panelHeader.Bottom
        panelSidebar.Height = frm.ClientSize.Height - panelHeader.Height

    End Sub

    ' Open / Close Sidebar
    Public Shared Sub ToggleSidebar(
        panelSidebar As Panel,
        timerSidebar As Timer)

        If panelSidebar Is Nothing OrElse timerSidebar Is Nothing Then
            Return
        End If

        panelSidebar.BringToFront()
        timerSidebar.Start()

    End Sub

    ' Sidebar animation
    Public Shared Sub HandleSidebarTick(
        panelSidebar As Panel,
        panelHeader As Panel,
        timerSidebar As Timer,
        ByRef isOpen As Boolean)

        If panelSidebar Is Nothing OrElse
           panelHeader Is Nothing OrElse
           timerSidebar Is Nothing Then

            Return
        End If

        Dim currentX As Integer =
            panelSidebar.Location.X

        Dim headerHeight As Integer =
            panelHeader.Height

        If isOpen Then

            ' Closing
            currentX -= 30

            If currentX <= HideX Then

                panelSidebar.Location =
                    New Point(HideX, headerHeight)

                isOpen = False
                timerSidebar.Stop()

            Else

                panelSidebar.Location =
                    New Point(currentX, headerHeight)

            End If

        Else

            ' Opening
            currentX += 30

            If currentX >= ShowX Then

                panelSidebar.Location =
                    New Point(ShowX, headerHeight)

                isOpen = True
                timerSidebar.Stop()

            Else

                panelSidebar.Location =
                    New Point(currentX, headerHeight)

            End If

        End If

    End Sub

    ' Initialize Navigation Buttons
    Public Shared Sub InitializeNavButtonStyles(
        navButtons() As Button,
        clickHandler As EventHandler)

        For Each btn As Button In navButtons

            If btn IsNot Nothing Then

                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0

                btn.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(40, 212, 175, 55)

                btn.BackColor = Color.Transparent
                btn.ForeColor = Color_Normal_White

                AddHandler btn.Click, clickHandler

                AddHandler btn.MouseEnter,
                    AddressOf NavButton_MouseEnter

                AddHandler btn.MouseLeave,
                    AddressOf NavButton_MouseLeave

            End If

        Next

    End Sub

    ' Mouse Enter
    Public Shared Sub NavButton_MouseEnter(
        sender As Object,
        e As EventArgs)

        Dim btn As Button =
            TryCast(sender, Button)

        If btn IsNot Nothing Then
            btn.ForeColor = Color_Hover_Gold
        End If

    End Sub

    ' Mouse Leave
    Public Shared Sub NavButton_MouseLeave(
        sender As Object,
        e As EventArgs)

        Dim btn As Button =
            TryCast(sender, Button)

        If btn IsNot Nothing Then
            btn.ForeColor = Color_Normal_White
        End If

    End Sub

End Class
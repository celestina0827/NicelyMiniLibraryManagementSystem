'NG ZHENG KAI - A25DW0669 (Section J1)
Imports System.Drawing
Imports System.Windows.Forms

Public Class SplashScreen

    Private progressValue As Integer = 0
    Private animationTick As Integer = 0
    Private readyTicks As Integer = 0
    Private isFinishing As Boolean = False

    Private logoTarget As Rectangle
    Private welcomeTargetY As Integer
    Private titleTargetY As Integer
    Private taglineTargetY As Integer
#Region "Design"
    Private ReadOnly GoldColour As Color =
        Color.FromArgb(212, 175, 55)

    Private Sub SplashScreen_Load(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles MyBase.Load

        'Reset animation values
        progressValue = 0
        animationTick = 0
        readyTicks = 0
        isFinishing = False

        'Form settings
        Me.AutoScaleMode = AutoScaleMode.None
        Me.ClientSize = New Size(720, 432)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.ShowInTaskbar = False
        Me.DoubleBuffered = True
        Me.Opacity = 0

        'Save the final control positions
        logoTarget = lblLogo.Bounds
        welcomeTargetY = lblWelcome.Top
        titleTargetY = lblTitle.Top
        taglineTargetY = lblTagline.Top

        'Start with a smaller logo
        Dim startSize As Integer = 42

        lblLogo.SetBounds(
            logoTarget.Left +
            ((logoTarget.Width - startSize) \ 2),
            logoTarget.Top +
            ((logoTarget.Height - startSize) \ 2),
            startSize,
            startSize
        )

        'Move the text slightly downward initially
        lblWelcome.Top = welcomeTargetY + 18
        lblTitle.Top = titleTargetY + 22
        lblTagline.Top = taglineTargetY + 25

        'Progress bar settings
        pnlProgressFill.Width = 0

        lblLoading.Text = "Starting system..."
        lblPercent.Text = "0%"

        lblLoading.ForeColor = Color.Silver
        lblPercent.ForeColor = GoldColour

        lblLoading.Visible = True
        lblPercent.Visible = True

        lblLoading.BringToFront()
        lblPercent.BringToFront()

        'Start splash animation
        tmrSplash.Interval = 20
        tmrSplash.Start()

    End Sub
#End Region

#Region "Timer"
    Private Sub tmrSplash_Tick(
        ByVal sender As System.Object,
        ByVal e As System.EventArgs
    ) Handles tmrSplash.Tick

        animationTick += 1

        'Fade out after loading is completed
        If isFinishing Then

            Me.Opacity =
                Math.Max(0, Me.Opacity - 0.05)

            If Me.Opacity <= 0 Then

                tmrSplash.Stop()
                OpenLoginForm()

            End If

            Return

        End If

        'Fade in
        If Me.Opacity < 1 Then

            Me.Opacity =
                Math.Min(1, Me.Opacity + 0.04)

        End If

        AnimateLogo()
        AnimateText()

        'Start progress after opening animation
        If animationTick > 38 Then
            UpdateProgress()
        End If

    End Sub
#End Region

#Region "Animate"
    Private Sub AnimateLogo()

        If lblLogo.Width < logoTarget.Width Then

            Dim newWidth As Integer =
                Math.Min(
                    logoTarget.Width,
                    lblLogo.Width + 2
                )

            Dim newHeight As Integer =
                Math.Min(
                    logoTarget.Height,
                    lblLogo.Height + 2
                )

            lblLogo.SetBounds(
                logoTarget.Left +
                ((logoTarget.Width - newWidth) \ 2),
                logoTarget.Top +
                ((logoTarget.Height - newHeight) \ 2),
                newWidth,
                newHeight
            )

        Else

            'Small floating animation
            Dim floatingPosition As Integer =
                CInt(
                    Math.Sin(animationTick / 8.0) * 2
                )

            lblLogo.Top =
                logoTarget.Top + floatingPosition

        End If

    End Sub

    Private Sub AnimateText()

        If animationTick > 12 AndAlso
            lblWelcome.Top > welcomeTargetY Then

            lblWelcome.Top -= 1

        End If

        If animationTick > 20 AndAlso
            lblTitle.Top > titleTargetY Then

            lblTitle.Top -= 1

        End If

        If animationTick > 28 AndAlso
            lblTagline.Top > taglineTargetY Then

            lblTagline.Top -= 1

        End If

    End Sub
#End Region

#Region "Progress"
    Private Sub UpdateProgress()

        If progressValue < 100 Then

            progressValue += 1

            pnlProgressFill.Width =
                CInt(
                    pnlProgressTrack.ClientSize.Width *
                    (progressValue / 100.0)
                )

            lblPercent.Text =
                progressValue.ToString() & "%"

            If progressValue < 25 Then

                lblLoading.Text =
                    "Starting system..."

            ElseIf progressValue < 55 Then

                lblLoading.Text =
                    "Loading library records..."

            ElseIf progressValue < 85 Then

                lblLoading.Text =
                    "Preparing user interface..."

            Else

                lblLoading.Text =
                    "Almost ready..."

            End If

        Else

            lblLoading.Text = "Ready"
            lblPercent.Text = "100%"

            readyTicks += 1

            If readyTicks >= 25 Then
                isFinishing = True
            End If

        End If

    End Sub
#End Region

#Region "Open Login Form"
    Private Sub OpenLoginForm()

        tmrSplash.Stop()
        Me.Hide()

        Using frmLogin As New LoginForm()
            frmLogin.ShowDialog()
        End Using

        Me.Close()

    End Sub
#End Region
End Class